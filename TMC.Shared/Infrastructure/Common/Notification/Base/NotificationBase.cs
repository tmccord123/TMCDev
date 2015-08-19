using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMC.Shared
{
    /// <summary>
    /// Represents abstract base class for Notices,
    /// Author: Nagarro
    /// </summary>
    public abstract class NotificationBase : INotification
    {
        /// <summary>
        /// Gets the type of the notice.
        /// </summary>
        /// <value>The type of the notice.</value>        
        public NotificationType NotificationType { get; private set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>The status.</value>
        public NotificationStatusType Status { get; protected set; }

        /// <summary>
        /// Gets or sets the message template header text.
        /// </summary>
        /// <value>The message template header text.</value>
        public string MessageTemplateHeaderText { get; protected set; }

        /// <summary>
        /// Gets or sets the message template body text.
        /// </summary>
        /// <value>The message template body text.</value>
        public string MessageTemplateBodyText { get; protected set; }

        /// <summary>
        /// Gets or sets the place holders.
        /// </summary>
        /// <value>The place holders.</value>
        public Dictionary<string, string> Placeholders { get; protected set; }

        /// <summary>
        /// Gets or sets the merged message header.
        /// </summary>
        /// <value>The message header.</value>
        public string MessageHeader { get; protected set; }

        /// <summary>
        /// Gets or sets the merged message body.
        /// </summary>
        /// <value>The message body.</value>
        public string MessageBody { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationBase"/> class.
        /// </summary>
        /// <param name="placeholders">The place holders.</param>
        protected NotificationBase(NotificationType type)
        {
            this.NotificationType = type;
        }

        /// <summary>
        /// Called when [pre dispatch].
        /// </summary>
        protected virtual void OnPreDispatch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [dispatch].
        /// </summary>
        protected virtual void OnDispatch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [post dispatch].
        /// </summary>
        protected virtual void OnPostDispatch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when [is valid].
        /// </summary>
        /// <returns></returns>
        protected virtual bool OnIsValid()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes the dispatching process.
        /// </summary>
        public void PreDispatch()
        {
            this.Status = NotificationStatusType.InProgress;
            try
            {
                this.OnPreDispatch();
            }
            catch (Exception)
            {
                this.Status = NotificationStatusType.Failed;
                throw;
            }
        }

        /// <summary>
        /// Validates and dispatches this notice.
        /// </summary>
        public void Dispatch()
        {
            try
            {
                if (this.IsValid())
                {
                    this.OnDispatch();
                }
            }
            catch (Exception)
            {
                this.Status = NotificationStatusType.Failed;
                throw;
            }
        }

        /// <summary>
        /// Posts process the notice after dispatching.
        /// </summary>
        public void PostDispatch()
        {
            try
            {
                this.OnPostDispatch();
                this.Status = NotificationStatusType.Sent;
            }
            catch (Exception)
            {
                this.Status = NotificationStatusType.SentWithErrors;
                throw;
            }
        }

        /// <summary>
        /// Determines whether this notice instance is valid.
        /// </summary>
        /// <returns>
        /// 	<c>true</c> if this instance is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValid()
        {
            try
            {
                return this.OnIsValid();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}