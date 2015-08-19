namespace TMC.Web.Shared
{
    using System;
    using System.Configuration;
    using System.IO;
    using System.Web;

    using TMC.Shared;

    /// <summary>
    /// File upload utility.
    /// </summary>
    public static class FileUploadUtility
    {
        /// <summary>upload single file to file server</summary>
        /// <param name="fileVersionDTO">file version dto which contains information for file which is to be save</param>
        /// <param name="postedFile">Posted file which is to be save on file server</param>
        /// <returns>Success or failure of operation to save file on server wrapped in operation result</returns>
        public static OperationResult<bool> UploadSingleFileToServer(IFileVersionDTO fileVersionDTO, HttpPostedFileBase postedFile)
        {
            OperationResult<bool> result;
            try
            {
                if (fileVersionDTO != null && postedFile != null && postedFile.ContentLength > 0)
                {
                    if (Directory.Exists(fileVersionDTO.ServerPath))
                    {
                        var path = Path.Combine(
                            fileVersionDTO.ServerPath,
                            fileVersionDTO.ServerFileName);

                        postedFile.SaveAs(path);
                        result = OperationResult<bool>.CreateSuccessResult(true, "File Successfully Saved on file server.");
                    }
                    else
                    {
                        result = OperationResult<bool>.CreateFailureResult("Path doesn't exist.");
                    }
                }
                else
                {
                    result = OperationResult<bool>.CreateFailureResult("There is no file to save.");
                }
            }
            catch (Exception ex)
            {
                result = OperationResult<bool>.CreateErrorResult(ex.Message, ex.StackTrace);
            }

            return result;
        }
    }
}
