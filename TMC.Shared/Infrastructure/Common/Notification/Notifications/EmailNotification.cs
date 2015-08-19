using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace TMC.Shared
{
    /// <summary>
    /// Represents Email notice,
    /// Author: Nagarro
    /// </summary>
    public class EmailNotification : NotificationBase, IEmailNotification
    {
        /// <summary>
        /// Gets or sets the mail.
        /// </summary>
        /// <value>The mail.</value>
        private MailMessage Mail { get; set; }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>From.</value>
        public string FromAddress { get; set; }

        /// <summary>
        /// Gets or sets To.
        /// </summary>
        /// <value>To.</value>
        public string ToAddresses { get; set; }

        /// <summary>
        /// Gets or sets the Cc.
        /// </summary>
        /// <value>Cc.</value>
        public string CcAddresses { get; set; }

        /// <summary>
        /// Gets or sets Bcc.
        /// </summary>
        /// <value>Cc.</value>
        public string BccAddresses { get; set; }

        /// <summary>
        /// Gets or sets the Subject.
        /// </summary>
        /// <value>Subject.</value>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets the Body.
        /// </summary>
        /// <value>Body.</value>
        public string Body { get; set; }

        public EmailDispatchStatus DispatchStatus { get; private set; }

        #region Constructor

        public EmailNotification()
            : base(NotificationType.Email)
        {
        }

        #endregion

        /// <summary>
        /// Called when [pre dispatch].
        /// </summary>
        protected override void OnPreDispatch()
        {
            try
            {
                //Initializes mail message
                this.Mail = new MailMessage();

                //Add 'To' email address
                if (!ValidatorUtility.IsNullOrEmpty(this.ToAddresses))
                {
                    this.CreateAddressesFromString(Mail.To, this.ToAddresses);
                }
                else
                {
                    this.UpdateDisptachStatus(EmailDispatchStatus.NoEmailId);
                }

                //Set 'From' email address
                if (!ValidatorUtility.IsNullOrEmpty(this.FromAddress))
                {
                    if (ValidatorUtility.IsValidEmail(this.FromAddress))
                    {
                        Mail.From = new MailAddress(this.FromAddress);
                    }
                    else
                    {
                        this.UpdateDisptachStatus(EmailDispatchStatus.InvalidEmailId);
                    }
                }
                else
                {
                    this.UpdateDisptachStatus(EmailDispatchStatus.NoEmailId);
                }

                //Add 'Cc' email address
                if (!ValidatorUtility.IsNullOrEmpty(this.CcAddresses))
                {
                    this.CreateAddressesFromString(Mail.CC, this.CcAddresses);
                }

                //Add 'Bcc' email address
                if (!ValidatorUtility.IsNullOrEmpty(this.BccAddresses))
                {
                    this.CreateAddressesFromString(Mail.Bcc, this.BccAddresses);
                }

                //Set email Subject
                Mail.Subject = this.Subject;
                //Set email body
                Mail.Body = this.Body;
                Mail.IsBodyHtml = true;
            }
            catch (Exception)
            {
                this.UpdateDisptachStatus(EmailDispatchStatus.Failure);
                throw;
            }
        }

        /// <summary>
        /// Called when [dispatch].
        /// </summary>
        protected override void OnDispatch()
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                //Send Mail
                smtpClient.Send(this.Mail);
                this.UpdateDisptachStatus(EmailDispatchStatus.Success);
            }
            catch (Exception)
            {
                this.UpdateDisptachStatus(EmailDispatchStatus.Failure);
                throw;
            }
        }

        /// <summary>
        /// Called when [post dispatch].
        /// </summary>
        protected override void OnPostDispatch()
        {
            if (this.Mail != null)
            {
                this.Mail.Dispose();
            }
        }

        /// <summary>
        /// Called when [is valid].
        /// </summary>
        /// <returns></returns>
        protected override bool OnIsValid()
        {
            bool result = false;
            if (this.DispatchStatus != EmailDispatchStatus.NoEmailId &&
                this.DispatchStatus != EmailDispatchStatus.InvalidEmailId)
            {
                result = true;
            }
            return result;
        }

        /// <summary>
        /// This function finds if email addresses in a comma separated string are valid 
        /// If all email addresses are valid only then the function returns true
        /// </summary>
        /// <param name="emailAddresses">comma separated string of email addresses</param>
        /// <returns></returns>
        private bool IsValidEmailAddresses(string emailAddresses)
        {
            string[] arrayAddresses = emailAddresses.Split(',');
            return !(arrayAddresses.Any(emailAddress => !(ValidatorUtility.IsValidEmail(emailAddress.Trim()))));
        }

        /// <summary>
        /// This function extracts email addresses from comma separated string of addresses and adds a MailAddress for each to 
        /// MailAddressCollection 
        /// </summary>
        /// <param name="mailAddressCollection">MailAddressCollection to update</param>
        /// <param name="stringAddresses">comma separated string of addresses</param>
        private void CreateAddressesFromString(MailAddressCollection mailAddressCollection, string stringAddresses)
        {
            string[] arrayAddresses = stringAddresses.Split(',');
            if (this.IsValidEmailAddresses(stringAddresses))
            {
                foreach (string address in arrayAddresses)
                {
                    MailAddress mailAddress = new MailAddress(address.Trim());
                    mailAddressCollection.Add(mailAddress);
                }
            }
            else
            {
                this.UpdateDisptachStatus(EmailDispatchStatus.InvalidEmailId);
            }
        }

        /// <summary>
        /// This methods updates Disptach Status of current email and logs it 
        /// </summary>
        /// <param name="emailDispatchStatus"></param>
        private void UpdateDisptachStatus(EmailDispatchStatus emailDispatchStatus)
        {
            this.DispatchStatus = emailDispatchStatus;
            Logger.Instance.LogDebug("Dispatch Status of Email has been set to " + emailDispatchStatus.ToString());
        }
    }
}