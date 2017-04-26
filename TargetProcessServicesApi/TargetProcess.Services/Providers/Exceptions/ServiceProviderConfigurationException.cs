using System;

namespace TargetProcess.Providers.Exceptions
{
    /// <summary>
    ///     Class ServiceProviderConfigurationException.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class ServiceProviderConfigurationException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ServiceProviderConfigurationException" /> class.
        /// </summary>
        public ServiceProviderConfigurationException() : base("The service provider has not been configured.") {}

        /// <summary>
        ///     Initializes a new instance of the <see cref="ServiceProviderConfigurationException" /> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public ServiceProviderConfigurationException(string message) : base(message) {}
    }
}