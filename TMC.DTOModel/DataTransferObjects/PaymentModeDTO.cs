using System;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for PaymentModeDTO DTO.
    /// </summary>
    [DataContract(Name = "ListingPaymentMode", Namespace = "TMC.DTOModel")]
    [EntityMapping("EntityDataModel.EntityModels.ListingPaymentMode", MappingType.TotalExplicit)]
    [Serializable]
    [ViewModelMapping("TMC.Web.ViewModels.PaymentModeViewModel", MappingType.TotalExplicit)]
    public class PaymentModeDTO : DTOBase, IPaymentModeDTO
    {
        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingPaymentModeId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingPaymentModeId")]
        public long ListingPaymentModeId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "ListingId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "ListingId")]
        public long ListingId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "PaymentModeId")]
        [EntityPropertyMapping(MappingDirectionType.Both, "PaymentModeId")]
        public short PaymentModeId { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedOn")] 
        public DateTime CreatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "CreatedBy")] 
        public long CreatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedOn")] 
        public DateTime UpdatedOn { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "UpdatedBy")] 
        public long UpdatedBy { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsActive")]
        public bool IsActive { get; set; }

        [ViewModelPropertyMapping(MappingDirectionType.Both, "IsDeleted")]
        public bool IsDeleted { get; set; }

    }
}
