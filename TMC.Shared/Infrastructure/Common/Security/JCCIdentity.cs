using System.Security.Principal;

namespace TMC.Shared
{
    public sealed class JCCIdentity : IIdentity
    {
        /// <summary>
        /// gets the authentication type
        /// </summary>
        public string AuthenticationType
        {
            get { return "Forms"; }
        }

        /// <summary>
        /// gets whether a user is authenticated or not
        /// </summary>
        public bool IsAuthenticated
        {
            get { return !string.IsNullOrWhiteSpace(this.Name); }
        }

        /// <summary>
        /// gets the username of logged in user
        /// </summary>
        public string Name
        {
            get { return LoggedInUser != null ? LoggedInUser.UserName : null; }
        }

        /// <summary>
        /// gets the username of logged in user
        /// </summary>
        public IUserDTO LoggedInUser { get; private set; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="name"></param>
        public JCCIdentity(IUserDTO loggedInUser)
        {
            LoggedInUser = loggedInUser;
        }
    }
}