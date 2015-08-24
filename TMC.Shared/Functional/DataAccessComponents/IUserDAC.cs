namespace TMC.Shared
{
    #region NameSpaces

    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// File DAC interface.
    /// </summary>
    public interface IUserDAC : IDataAccessComponent
    {
 
       IUserDTO GetUserById(int userId);
        
    }
}
