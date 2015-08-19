namespace TMC.Shared
{
    /// <summary>
    /// Defines a contract for Notice factory,
    /// Author : Nagarro     
    /// </summary>
    public interface INotificationFactory
    {
        /// <summary>
        /// Creates the specified type.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="args">The args.</param>
        /// <returns></returns>
        INotification Create(NotificationType type, params object[] args);
    }
}