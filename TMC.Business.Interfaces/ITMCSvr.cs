using System;
using System.Collections.Generic;
using TMC.Shared;
using  System.ServiceModel;

namespace TMC.Business.Interfaces
{
    [ServiceContract]
    public interface ITMCSvr
    {
        [OperationContract]
         OperationResult<IList<IProductDTO>> GetAllProducts();
    }
}
