using System.Runtime.Serialization;

namespace TargetProcess.Services.Data.Dto
{
    /// <summary>
    ///     Class Culture.
    /// </summary>
    [DataContract]
    public class Culture : ITargetProcessDto

    {
        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the decimal? separator.
        /// </summary>
        /// <value>The decimal? separator.</value>
        [DataMember]
        public string DecimalSeparator { get; set; }

        /// <summary>
        ///     Gets or sets the currency decimal? separator.
        /// </summary>
        /// <value>The currency decimal? separator.</value>
        [DataMember]
        public string CurrencyDecimalSeparator { get; set; }

        /// <summary>
        ///     Gets or sets the currency decimal? digits.
        /// </summary>
        /// <value>The currency decimal? digits.</value>
        [DataMember]
        public int? CurrencyDecimalDigits { get; set; }

        /// <summary>
        ///     Gets or sets the currency group separator.
        /// </summary>
        /// <value>The currency group separator.</value>
        [DataMember]
        public string CurrencyGroupSeparator { get; set; }

        /// <summary>
        ///     Gets or sets the short date format.
        /// </summary>
        /// <value>The short date format.</value>
        [DataMember]
        public string ShortDateFormat { get; set; }

        /// <summary>
        ///     Gets or sets the long date format.
        /// </summary>
        /// <value>The long date format.</value>
        [DataMember]
        public string LongDateFormat { get; set; }

        /// <summary>
        ///     Gets or sets the time pattern.
        /// </summary>
        /// <value>The time pattern.</value>
        [DataMember]
        public string TimePattern { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        [DataMember]
        public int? Id { get; set; }
    }
}