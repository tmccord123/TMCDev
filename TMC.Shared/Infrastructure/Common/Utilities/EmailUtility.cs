using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMC.Shared.Factories;

namespace TMC.Shared
{
    public static class EmailUtility
    {
        /// <summary>
        /// Sends email using a pre-defined email template
        /// If any of emailFromAddress/emailToAddress/emailCcAddress is String.Empty then EmailInfo will use corresponding address 
        /// from Email template
        /// If emailToAddress OR emailCcAddress is not String.Empty the string will be appended to corresponding address of Email 
        /// Template and saved in Email Info
        /// </summary>
        /// <param name="emailTemplateId">Email Template Id</param>
        /// <param name="emailFromAddress">From</param>
        /// <param name="emailToAddress">To: Comma separated string of email addresses</param>
        /// <param name="emailCcAddress">Cc: Comma separated string of email addresses</param>
        /// <param name="subjectPlaceholderValues">Place holder values for Subject template</param>
        /// <param name="bodyPlaceholderValues">Place holder values for Body template</param>
        /// <returns></returns>
        public static bool SendEmail(EmailTemplate emailTemplateId, string emailFromAddress, string emailToAddress,
                                     string emailCcAddress, Dictionary<string, string> subjectPlaceholderValues,
                                     Dictionary<string, string> bodyPlaceholderValues)
        {
          /*  IEmailBDC emailBDC = (IEmailBDC) BDCFactory.Instance.Create(BDCType.Email);
            return emailBDC.SendEmail(emailTemplateId, emailFromAddress, emailToAddress, emailCcAddress,
                                      subjectPlaceholderValues, bodyPlaceholderValues);*/
            return true;
        }

        /// <summary>
        /// Sends email without using Email template
        /// </summary>
        /// <param name="emailFromAddress">From</param>
        /// <param name="emailToAddress">To: Comma separated string of email addresses</param>
        /// <param name="emailCcAddress">Cc: Comma separated string of email addresses</param>
        /// <param name="emailSubject">Subject</param>
        /// <param name="emailBody">Body</param>
        /// <returns></returns>
        public static bool SendEmail(string emailFromAddress, string emailToAddress, string emailCcAddress,
                                     string emailSubject, string emailBody)
        {
            //IEmailBDC emailBDC = (IEmailBDC) BDCFactory.Instance.Create(BDCType.Email);
            //return emailBDC.SendEmail(emailFromAddress, emailToAddress, emailCcAddress, emailSubject, emailBody);
            return true;
        }
    }
}