using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Diagnostics.CodeAnalysis;
using System.Collections;
using System.Text.RegularExpressions;
using System.Globalization;

namespace TMC.Shared
{
    /// <summary>
    /// Represents Notification manager,
    /// Author: Nagarro
    /// </summary>
    public static class NotificationManager
    {
        /// <summary>
        /// Processes the specified notice.
        /// </summary>
        /// <param name="notice">The notice.</param>
        public static void Process(INotification notice)
        {
            try
            {
                notice.PreDispatch();
                notice.Dispatch();
                notice.PostDispatch();
            }
            catch (Exception ex)
            {
                ExceptionManager.HandleException(ex);
                throw new NotificationException("Error while processing notice!", ex);
            }
        }

        /// <summary>
        /// Merges the message template text with placeholders
        /// </summary>
        /// <param name="messageTemplateText">The message template text.</param>
        /// <param name="placeholderValuesToMerge">The place holder values to merge.</param>
        /// <returns></returns>
        public static string MergeNotificationMessageText(string messageTemplateText,
                                                          Dictionary<string, string> placeholderValuesToMerge)
        {
            string mergedMessage = string.Empty;
            if (!ValidatorUtility.IsNull(messageTemplateText))
            {
                mergedMessage = messageTemplateText;
                if (placeholderValuesToMerge == null)
                {
                    placeholderValuesToMerge = new Dictionary<string, string>();
                }
                mergedMessage = mergedMessage.Inject(placeholderValuesToMerge, EmailConstants.templatePlaceholderStart,
                                                     EmailConstants.templatePlaceholderEnd);
            }
            return mergedMessage;
        }
    }
}