namespace TMC.Shared
{
    #region NameSpaces

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// File DAC interface.
    /// </summary>
    public interface IProductDAC : IDataAccessComponent
    {
        long CreateProduct(IProductDTO productDto);
        List<IProductDTO> ReadAllProducts();
        IProductDTO ReadProductBySeoTitle(string seoTitle);
        
    }
}
