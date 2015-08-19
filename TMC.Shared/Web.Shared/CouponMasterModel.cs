using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMC.Shared;

namespace TMC.Shared
{
    public class ProductMasterModel
    {
        public ProductMasterModel()
        {
            this.CouponMasterID = long.MinValue;
            this.Title = string.Empty;
            this.Content = string.Empty;
            this.ContentText = string.Empty;
            this.CreatedBy = long.MinValue;
            this.CreatedOn = DateTime.MinValue;
            this.ModifiedBy = long.MinValue;
            this.ModifiedOn = DateTime.MinValue.ToShortDateString();
            this.HelpAbsolutePath = string.Empty;
        }

        /*public HelpMasterModel(IHelpDTO helpTemplate)
        {
            this.HelpMasterID = helpTemplate.HelpMasterID;
            this.SiteID = helpTemplate.SiteID;
            this.HelpCode = helpTemplate.HelpCode;
            this.IsFolder = helpTemplate.IsFolder;
            this.ParentCode = helpTemplate.ParentCode;
            this.HelpDetailID = helpTemplate.HelpDetailID;
            this.Title = helpTemplate.Title;
            this.Content = helpTemplate.Content;
            this.ContentText = helpTemplate.ContentText;
            this.LanguageID = helpTemplate.LanguageID;
            this.CreatedBy = helpTemplate.CreatedBy;
            this.CreatedOn = helpTemplate.CreatedOn;
            this.ModifiedBy = helpTemplate.ModifiedBy;
            this.ModifiedOn = helpTemplate.ModifiedOn.ToShortDateString();
            this.HelpAbsolutePath = helpTemplate.HelpAbsolutePath;
            this.VersionWorkflowStep = helpTemplate.VersionWorkflowStatus.ToString();
            this.Comment = helpTemplate.Comment;
            this.ProcessedBy = helpTemplate.ModifiedBy;
            this.Published = helpTemplate.Published;
            this.ModifiedByName = helpTemplate.ModifiedByName;
            this.HelpVersion = helpTemplate.Version.ToString();
            this.WorkflowLastModifierName = helpTemplate.WorkflowLastModifierName;
        }*/

        public long CouponMasterID { get; set; }   
        public string Title { get; set; }
        public string Content { get; set; }
        public string ContentText { get; set; } 
        public long CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public long ModifiedBy { get; set; }
        public string ModifiedOn { get; set; }
        public string HelpAbsolutePath { get; set; } 
        public long ProcessedBy { get; set; }
        public string Comment { get; set; }  
        public string SuccessMessage { get; set; }
        public string ModifiedByName { get; set; } 
    }
}
