using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMC.Shared;
using TMC.Shared.Factories;

namespace TMC.Web.Shared
{
    /// <summary>
    /// Contains common methods to be cached,
    /// Author		: Nagarro
    /// </summary>
    /*public static class CacheMethods
    {
        #region "Methods"
        /// <summary>
        /// This Method is used to get the list of states and put in cache
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static IList<IStateDTO> FetchAllStates()
        {
            if (CacheManager<StateProvinceState>.Data.StateProvinces == null)
            {
                OperationResult<IList<IStateDTO>> states = null;
                IOrganizationFacade organizationFacadeFacade = (IOrganizationFacade)FacadeFactory.Instance.Create(FacadeType.Organization);
                states = organizationFacadeFacade.FetchAllStates();
                if (states != null && states.IsValid())
                {
                    CacheManager<StateProvinceState>.Data.StateProvinces = states.Data;
                }
                else
                {
                   throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Company.BusinessLocation.NotificationMessage.FetchAllStatesFailure));
                }
            }
            return CacheManager<StateProvinceState>.Data.StateProvinces;
        }

                /// <summary>
        /// This Method is used to get the list of states and put in cache
        /// </summary>
        [SuppressMessage(SuppressMessageConstants.DesignCategory, SuppressMessageConstants.NestedTypeShouldNotBeVisible)
        ]
        public static IList<IOrganizationLocationTypeDTO> FetchAllOrganizationLocaationTypes()
        {
            if (CacheManager<OrganizationLocationTypeState>.Data.OrganizationLocationTypeStates == null)
            {
                OperationResult<IList<IOrganizationLocationTypeDTO>> locationTypes = null;
                IOrganizationFacade organizationFacadeFacade = (IOrganizationFacade)FacadeFactory.Instance.Create(FacadeType.Organization);
                locationTypes = organizationFacadeFacade.FetchAllOrganizationLocaationTypes();
                if (locationTypes != null && locationTypes.IsValid())
                {
                    CacheManager<OrganizationLocationTypeState>.Data.OrganizationLocationTypeStates = locationTypes.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Company.BusinessLocation.NotificationMessage.FetchAlllocationTypesFailure));
                }
            }
            return CacheManager<OrganizationLocationTypeState>.Data.OrganizationLocationTypeStates;
        }

        /// <summary>
        /// Fetch all company types.
        /// </summary>
        /// <returns>
        /// List of company types <see cref="IList"/>.
        /// </returns>
        public static IList<ICompanyTypeDTO> FetchAllCompanyTypes()
        {
            if (CacheManager<CompanyTypeState>.Data.CompanyTypes == null)
            {
                OperationResult<IList<ICompanyTypeDTO>> companyTypes = null;
                var organizationFacade = (IOrganizationFacade)FacadeFactory.Instance.Create(FacadeType.Organization);
                companyTypes = organizationFacade.FetchAllCompanyTypes();
                if (companyTypes != null && companyTypes.IsValid())
                {
                    CacheManager<CompanyTypeState>.Data.CompanyTypes = companyTypes.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Company.CompanyProfile.NotificationMessage.FetchAllCompanyTypeFailure));
                }
            }
            return CacheManager<CompanyTypeState>.Data.CompanyTypes;
        }

        /// <summary>
        /// The fetch all contact types.
        /// </summary>
        /// <returns>
        /// List of contact types <see cref="IList"/>.
        /// </returns>
        public static IList<IContactTypeDTO> FetchAllContactTypes()
        {
            if (CacheManager<ContactTypeState>.Data.ContactTypes == null)
            {
                OperationResult<IList<IContactTypeDTO>> companyTypes = null;
                var organizationFacade = (IOrganizationFacade)FacadeFactory.Instance.Create(FacadeType.Organization);
                companyTypes = organizationFacade.FetchAllContactTypes();
                if (companyTypes != null && companyTypes.IsValid())
                {
                    CacheManager<ContactTypeState>.Data.ContactTypes = companyTypes.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Company.BusinessContact.Validation.FailedToFetchContactTypes));
                }
            }
            return CacheManager<ContactTypeState>.Data.ContactTypes;
        }

        /// <summary>
        /// Fetch all affiliation types.
        /// </summary>
        /// <returns>
        /// List of affiliation types <see cref="IList"/>.
        /// </returns>
        public static IList<IAffiliationTypeDTO> FetchAllAffiliationTypes()
        {
            if (CacheManager<AffiliationTypeState>.Data.AffiliationTypes == null)
            {
                OperationResult<IList<IAffiliationTypeDTO>> affiliationTypes = null;
                var trainingPlanFacade = (ITrainingPlanFacade)FacadeFactory.Instance.Create(FacadeType.TrainingPlan);
                affiliationTypes = trainingPlanFacade.FetchAllAffiliationTypes();
                if (affiliationTypes != null && affiliationTypes.IsValid())
                {
                    CacheManager<AffiliationTypeState>.Data.AffiliationTypes = affiliationTypes.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Training.TrainingPlan.Index.Messages.FailedToFetchAffiliationTypes));
                }
            }
            return CacheManager<AffiliationTypeState>.Data.AffiliationTypes;
        }

        /// <summary>
        /// Fetch all certificate regulations.
        /// </summary>
        /// <returns>
        /// List of certificate regulations <see cref="IList"/>.
        /// </returns>
        public static IList<ICertificateRegulationDTO> FetchAllCertificateRegulations()
        {
            if (CacheManager<CertificateReglationState>.Data.CertificateReglations == null)
            {
                OperationResult<IList<ICertificateRegulationDTO>> cetrificateRegulations = null;
                var trainingPlanFacade = (ITrainingPlanFacade)FacadeFactory.Instance.Create(FacadeType.TrainingPlan);
                cetrificateRegulations = trainingPlanFacade.FetchAllCertificateRegulations();
                if (cetrificateRegulations != null && cetrificateRegulations.IsValid())
                {
                    CacheManager<CertificateReglationState>.Data.CertificateReglations = cetrificateRegulations.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Training.TrainingPlan.Index.Messages.FetchCertificateRegulationsFailure));
                }
            }
            return CacheManager<CertificateReglationState>.Data.CertificateReglations;
        }

        /// <summary>
        /// Fetch all certificate frequencies.
        /// </summary>
        /// <returns>
        /// List of certificate frequencies <see cref="IList"/>.
        /// </returns>
        public static IList<ICertificateFrequencyDTO> FetchAllCertificationFrequencies()
        {
            if (CacheManager<CertificateFequencyState>.Data.CertificateFequencies == null)
            {
                OperationResult<IList<ICertificateFrequencyDTO>> certificateFrequencies = null;
                var trainingPlanFacade = (ITrainingPlanFacade)FacadeFactory.Instance.Create(FacadeType.TrainingPlan);
                certificateFrequencies = trainingPlanFacade.FetchAllCertificateFrequencies();
                if (certificateFrequencies != null && certificateFrequencies.IsValid())
                {
                    CacheManager<CertificateFequencyState>.Data.CertificateFequencies = certificateFrequencies.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Training.TrainingPlan.Index.Messages.FetchCertificateFrequenciesFailure));
                }
            }
            return CacheManager<CertificateFequencyState>.Data.CertificateFequencies;
        }

        /// <summary>
        /// Fetch all certificate types.
        /// </summary>
        /// <returns>
        /// List of certificate types <see cref="IList"/>.
        /// </returns>
        public static IList<ICertificationTypeDTO> FetchAllCertificationTypes()
        {
            if (CacheManager<CertificationTypeState>.Data.CertificationTypes == null)
            {
                OperationResult<IList<ICertificationTypeDTO>> cetrificationTypes = null;
                var trainingPlanFacade = (ITrainingPlanFacade)FacadeFactory.Instance.Create(FacadeType.TrainingPlan);
                cetrificationTypes = trainingPlanFacade.FetchAllCertificationTypes();
                
                if (cetrificationTypes != null && cetrificationTypes.IsValid())
                {
                    CacheManager<CertificationTypeState>.Data.CertificationTypes = cetrificationTypes.Data;
                }
                else
                {
                    throw new Exception(ResourceUtility.GetCaptionFor(ResourceConstants.Training.TrainingPlan.Index.Messages.FetchCertificateRegulationsFailure));
                }
            }
            return CacheManager<CertificationTypeState>.Data.CertificationTypes;
        }



        #endregion
    }*/
}
