using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Single sign-on Application Settings.
    /// </summary>
    [DataContract]
    public class SsoSettings

    {
        /// <summary>
        ///     True if Single sign-on is enabled
        /// </summary>
        [DataMember]
        public bool? IsEnabled { get; set; }

        /// <summary>
        ///     Identity provider URL where Targetprocess sends a SAML request to start the login process
        /// </summary>
        [DataMember]
        public string SignonUrl { get; set; }

        /// <summary>
        ///     X.509 certificate used for communication with identity provider
        /// </summary>
        [DataMember]
        public string Certificate { get; set; }

        /// <summary>
        ///     True if JIT user provisioning is enabled
        /// </summary>
        [DataMember]
        public bool? IsUserProvisioningEnabled { get; set; }

        /// <summary>
        ///     True if form authentication is disabled.
        /// </summary>
        [DataMember]
        public bool? IsFormAuthenticationDisabled { get; set; }

        /// <summary>
        ///     Users who are exceptions for SSO (they can login via login/password)
        /// </summary>
        [DataMember]
        public User ExceptionUsers { get; set; }
    }
}