using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TMC.Shared;

namespace TMC.DTOModel
{
    /// <summary>
    /// Contract for ListingContacts DTO.//todo
    /// </summary>
    public class ListingPaymentModesDTO : DTOBase, IListingPaymentModesDTO
    {
        public IList<IPaymentModeDTO> PaymentModes { get; set; }

    }
}
