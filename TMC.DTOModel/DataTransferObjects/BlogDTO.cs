using System;
using TMC.Shared;
 using System.Collections.Generic;
namespace TMC.Shared
{
   

    /// <summary>
    /// Contract for Action DTO.
    /// </summary>
    public class BlogDTO // : DTOBase, IBlogDTO //todo
    {
        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        public string BlogId { get; set; }  
        
        /// <summary>
        /// Get or set Action Id.
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Get or set Action Name.
        /// </summary>
        public string WebURL { get; set; }

        /// <summary>
        /// Get or set Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// gets or sets the state of the object.
        /// </summary>
        /// <value>The state of the object.</value>        
        public ObjectStateType ObjectState { get; set; }

        /// <summary>
        /// gets the unique ID.
        /// </summary>
        /// <value>The unique ID.</value>        
       public  Guid? UniqueID { get; set; }

        /// <summary>
        /// gets the type of the DTO.
        /// </summary>
        /// <value>The type of the DTO.</value>        
      public DTOType DTOType { get; set;}

       
    }
}
