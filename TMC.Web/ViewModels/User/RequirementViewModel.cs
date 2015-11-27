using System;
using TMC.Shared;
using TMC.Web.Shared;

namespace TMC.Web.ViewModels
{
    public class RequirementViewModel : ViewModelBase
    {
        public RequirementViewModel()
        {
           
        }
        public long RequirementId { get; set; }
        public long UserId { get; set; }
        public string RequirementTitle { get; set; }
        public string Description { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public int AbuseCount { get; set; }
        public short LevelId { get; set; }
        public short AdditionalInfoId { get; set; }
    }
}