
using EntityDataModel.EntityModels;

namespace TMC.Data
{
    #region Namespaces

    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.IO;
    using System.Linq;
    using TMC.Shared;
 

    #endregion

    /// <summary>
    /// Implementation for Organization DAC.
    /// </summary>
    public class BlogDAC 
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationDAC"/> class.
        /// </summary>
        public BlogDAC()
        { }
        #endregion

        #region Public Methods


        public List<BlogDTO> ReadAllBlogs()
        {
             List<BlogDTO> blogList = new List<BlogDTO>();

            try
            {
                if (1 > 0)
                {
                    using (var tmcDBContext = new TMCContext())
                    {
                        var blogs = (from blog in tmcDBContext.Blogs
                                                     select blog).ToList();
                        foreach (var blog in blogs)
                        {
                            var blogDTO = new BlogDTO();
                            blogDTO.BlogId = blog.Id;
                            blogDTO.Description = blog.Description;

                            blogList.Add(blogDTO);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionManager.HandleException(ex);
                //throw new DACException("Error while fetching the organization locations.", ex);
            }
            return blogList;
        }

        /*/// <summary>Get organization details on the bases of organization id</summary>
        /// <param name="organizationId">organization id</param>
        /// <returns>The <see cref="IOrganizationDTO"/></returns>
        public BlogDTO GetOrganizationDetails(int organizationId)
        {
            IOrganizationDTO organization = null;
            var relationShipManagerContactTypeId = Enum.ContactType.RelationshipManager.GetHashCode();
            try
            {
                using (var jccSemsDbContext = new JCCSemsContext())
                {
                    organization = (IOrganizationDTO)DTOFactory.Instance.Create(DTOType.Organization);

                    var organizationLocation = from loc in jccSemsDbContext.ORG_LOCATION
                                               where loc.organization_id == organizationId && loc.primary_address == 1
                                               select loc;

                    var organizationEntity = (from org in jccSemsDbContext.ORGANIZATIONs
                                              join orgLoc in organizationLocation on org.organization_id
                                                  equals orgLoc.organization_id into ol
                                              from organizationLoc in ol.DefaultIfEmpty()
                                              where (org.organization_id == organizationId)
                                              select
                                                  new { Organization = org, OrgnizationLocation = organizationLoc }).ToList();

                    var relationShipManagersLinqQuery = (from orgLoc in jccSemsDbContext.ORG_LOCATION
                                                         join ind in jccSemsDbContext.INDIVIDUALs on orgLoc.org_location_id
                                                             equals ind.org_location_id
                                                         join indContType in jccSemsDbContext.IndividualContactTypes on
                                                             ind.individual_id equals indContType.IndividualId
                                                         join contType in jccSemsDbContext.ContactTypes on
                                                             indContType.ContactTypeId equals contType.ContactTypeId
                                                         where
                                                             orgLoc.organization_id == organizationId
                                                             && contType.ContactTypeId == relationShipManagerContactTypeId && indContType.IsActive
                                                         select new { Individuals = ind, IndividualTypes = indContType });
                    string relationShipManagersQuery = ((ObjectQuery)relationShipManagersLinqQuery).ToTraceString();
                    var relationShipManagers = relationShipManagersLinqQuery.ToList();

                    if (organizationEntity.Any())
                    {
                        EntityConverter.FillDTOFromEntity(organizationEntity.First().Organization, organization);
                        var orgLocations = organizationEntity.FirstOrDefault().OrgnizationLocation;

                        if (orgLocations != null)
                        {
                            organization.OrganizationLocation = (IOrganizationLocationDTO)DTOFactory.Instance.Create(DTOType.OrganizationLocation);
                            EntityConverter.FillDTOFromEntity(orgLocations, organization.OrganizationLocation);
                        }

                        var relManager = relationShipManagers.FirstOrDefault(rsm => rsm.IndividualTypes.IsPrimary);

                        if (relManager != null)
                        {
                            organization.PrimaryRelationshipManager = (IIndividualDTO)DTOFactory.Instance.Create(DTOType.Individual);
                            EntityConverter.FillDTOFromEntity(relManager.Individuals, organization.PrimaryRelationshipManager);
                        }

                        var allRelationShipManagers = relationShipManagers.Select(rsm => rsm.Individuals).Distinct();

                        if (allRelationShipManagers.Any())
                        {
                            organization.RelationshipManagers = new List<IIndividualDTO>();
                            foreach (var individual in allRelationShipManagers)
                            {
                                var relManagerDTO = (IIndividualDTO)DTOFactory.Instance.Create(DTOType.Individual);
                                EntityConverter.FillDTOFromEntity(individual, relManagerDTO);
                                organization.RelationshipManagers.Add(relManagerDTO);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the company details.", ex);
            }
            return organization;
        }*/

        /*/// <summary>
        /// Get organization by org Id.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <returns></returns>
        public IOrganizationDTO ReadOrganizationByOrgId(int organizationId)
        {
            IOrganizationDTO organizationDTo = null;
            try
            {
                using (JCCSemsContext jccSemsEntitites = new JCCSemsContext())
                {
                    var query = from orgEntity in jccSemsEntitites.ORGANIZATIONs
                                where orgEntity.organization_id == organizationId
                                select orgEntity;

                    ORGANIZATION organization = query.SingleOrDefault();

                    if (organization != null)
                    {
                        organizationDTo = (IOrganizationDTO)DTOFactory.Instance.Create(DTOType.Organization);
                        EntityConverter.FillDTOFromEntity(organization, organizationDTo);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the company details.", ex);
            }
            return organizationDTo;
        }

        /// <summary>
        /// Update organization details.
        /// </summary>
        /// <param name="organizationDTO">
        /// Organization DTO.
        /// </param>
        /// <returns>
        /// Success/Failure <see cref="bool"/>.
        /// </returns>
        public bool UpdateOrganizationDetails(IOrganizationDTO organizationDTO)
        {
            bool result = false;
            var relationShipManagerContactTypeId = Enum.ContactType.RelationshipManager.GetHashCode();
            try
            {
                using (var jccSemsDbContext = new JCCSemsContext())
                {
                    var organization =
                        jccSemsDbContext.ORGANIZATIONs.Single(
                            org => org.organization_id == organizationDTO.OrganizationId);
                    organization.sems_training_required = organizationDTO.SemsTrainingRequired;
                    organization.CompanyTypeId = organizationDTO.CompanyTypeId;
                    organization.organization_logo_file_id = organizationDTO.OrganizationLogoFileId;

                    var individualsContactTypes = (from orgLoc in jccSemsDbContext.ORG_LOCATION
                                                   join ind in jccSemsDbContext.INDIVIDUALs on orgLoc.org_location_id
                                                       equals ind.org_location_id
                                                   join indContType in jccSemsDbContext.IndividualContactTypes on
                                                       ind.individual_id equals indContType.IndividualId
                                                   join contType in jccSemsDbContext.ContactTypes on
                                                       indContType.ContactTypeId equals contType.ContactTypeId
                                                   where
                                                       orgLoc.organization_id == organizationDTO.OrganizationId
                                                       && contType.ContactTypeId == relationShipManagerContactTypeId
                                                       && indContType.IsActive
                                                   select indContType).ToList();

                    if (individualsContactTypes.Any())
                    {
                        foreach (var individualsContactType in individualsContactTypes)
                        {
                            individualsContactType.IsPrimary = false || individualsContactType.IndividualId
                                                                == organizationDTO.PrimaryRelationshipManager.IndividualID;
                        }
                    }

                    result = jccSemsDbContext.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new DACException("Error while fetching the company details.", ex);
            }

            return result;
        }

        */

         

        #endregion
    }
}