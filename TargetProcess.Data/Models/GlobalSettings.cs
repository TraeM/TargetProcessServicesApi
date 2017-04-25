using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    /// <summary>
    ///     Global Application Settings.
    /// </summary>
    [DataContract]
    public class GlobalSettings
    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Company name that is displayed in the top area in TP2
        /// </summary>
        [DataMember]
        public string CompanyName { get; set; }

        /// <summary>
        ///     Email notifications setup: SMTP server address
        /// </summary>
        [DataMember]
        public string SMTPServer { get; set; }

        /// <summary>
        ///     Email notifications setup: SMTP server port number
        /// </summary>
        [DataMember]
        public int? SMTPPort { get; set; }

        /// <summary>
        ///     Email notifications setup: SMTP server login
        /// </summary>
        [DataMember]
        public string SMTPLogin { get; set; }

        /// <summary>
        ///     Email notifications setup: SMTP server password
        /// </summary>
        [DataMember]
        public string SMTPPassword { get; set; }

        /// <summary>
        ///     Email notifications setup: true if authentication is required to use this server
        /// </summary>
        [DataMember]
        public bool? SMTPAuthentication { get; set; }

        /// <summary>
        ///     Email notifications setup: email address that is used to send notifications
        /// </summary>
        [DataMember]
        public string SMTPSender { get; set; }

        /// <summary>
        ///     Email notifications setup: true if email notifications are enabled
        /// </summary>
        [DataMember]
        public bool? IsEmailNotificationsEnabled { get; set; }

        /// <summary>
        ///     URL used to access Help Desk Portal
        /// </summary>
        [DataMember]
        public string HelpDeskPortalPath { get; set; }

        /// <summary>
        ///     URL used to access Targetprocess application
        /// </summary>
        [DataMember]
        public string AppHostAndPath { get; set; }

        /// <summary>
        ///     True if a newly created requester (or a requester whose password has been changed) will receive an email
        ///     notification with Help Desk Portal access information
        /// </summary>
        [DataMember]
        public bool? NotifyRequester { get; set; }

        /// <summary>
        ///     True if a requester automatically created from inbound email will receive an email notification with Help Desk
        ///     Portal access information
        /// </summary>
        [DataMember]
        public bool? NotifyAutoCreatedRequester { get; set; }

        /// <summary>
        ///     True if only HTTPS can be used to access Targetprocess
        /// </summary>
        [DataMember]
        public bool? DisableHttpAccess { get; set; }

        /// <summary>
        ///     Delimiter that is used in exported CSV files
        /// </summary>
        [DataMember]
        public string CsvExportDelimiter { get; set; }

        /// <summary>
        ///     True if cookie authentication for REST JSONP requests is disabled
        /// </summary>
        [DataMember]
        public bool? SecureJsonp { get; set; }

        /// <summary>
        ///     True if all TP2 users can switch to TP3 using “Targetprocess³” button
        /// </summary>
        [DataMember]
        public bool? Tp3Available { get; set; }

        /// <summary>
        ///     Which rich editor should be used by default (html or markdown)
        /// </summary>
        [DataMember]
        public RichEditorType DefaultRichEditor { get; set; }

        /// <summary>
        ///     Single signon settings
        /// </summary>
        [DataMember]
        public SsoSettings SsoSettings { get; set; }
    }
}