using System;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace TMC.Shared.Factories
{
    /// <summary>
    /// Represents the factory for Notice types,
    /// Author : Nagarro 
    /// </summary>
    public class NotificationFactory : FactoryBase, INotificationFactory
    {
        //The variable is declared to be volatile to ensure that assignment to the 
        //_instance variable completes before the instance variable can be accessed.
        private static volatile NotificationFactory _instance;
        private static object _syncObject = new object();

        #region Ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="DTOFactory"/> class.
        /// </summary>
        private NotificationFactory()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Instance is private static property to return the same Instance of the class everytime.
        /// Note: Double - checked serialized initialization of Class pattern is used.
        /// </summary>
        public static NotificationFactory Instance
        {
            get
            {
                #region Single Instance Logic

                //Check for null before acquiring the lock.
                if (_instance == null)
                {
                    //Use a _syncObject to lock on, to avoid deadlocks among multiple threads.
                    lock (_syncObject)
                    {
                        //Again check if _instance has been initialized, 
                        //since some other thread may have acquired the lock first and constructed the object.
                        if (_instance == null)
                        {
                            _instance = new NotificationFactory();
                        }
                    }
                }

                #endregion

                return _instance;
            }
        }

        #endregion

        #region NotificationFactory Members

        /// <summary>
        /// Creates the specified Notice type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        public INotification Create(NotificationType type, params object[] args)
        {
            // get type info
            QualifiedTypeNameAttribute QualifiedNameAttr =
                EnumAttributeUtility<NotificationType, QualifiedTypeNameAttribute>.GetEnumAttribute(type.ToString());

            // Initialize instance
            INotification instance = null;

            // create instance
            instance =
                (INotification)
                this.CreateObjectInstance(QualifiedNameAttr.AssemblyFileName, QualifiedNameAttr.QualifiedTypeName, args);

            // return
            return instance;
        }

        #endregion
    }
}