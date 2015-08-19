using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Web.Shared
{
    using System.Runtime.Serialization;
    using System.Web;

    public class FileUploaderModel
    {
        /// <summary>
        /// Gets or sets the posted file.
        /// </summary>
        [DataMember]
        public HttpPostedFileBase PostedFile { get; set; }

        /// <summary>
        /// Gets or sets the original file name.
        /// </summary>
        [DataMember]
        public string OriginalFileName { get; set; }

        /// <summary>
        /// Gets or sets the server file name.
        /// </summary>
        [DataMember]
        public string ServerFileName { get; set; }

        /// <summary>
        /// Gets or sets the server path.
        /// </summary>
        [DataMember]
        public string ServerPath { get; set; }
    }
}
