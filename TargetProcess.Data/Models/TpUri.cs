using System;
using System.Runtime.Serialization;

namespace TargetProcess.Data.Models
{
    [DataContract]
    public class TpUri : Uri
    {
        /// <inheritdoc />
        public TpUri(string uriString) : base(uriString) {}

        /// <inheritdoc />
        [Obsolete(message: "This constructor as been depriciated", error: true)]
        public TpUri(string uriString, bool dontEscape) : base(uriString, dontEscape) {}

        /// <inheritdoc />
        [Obsolete(message: "This constructor as been depriciated", error: true)]
        public TpUri(Uri baseUri, string relativeUri, bool dontEscape) : base(baseUri, relativeUri, dontEscape) {}

        /// <inheritdoc />
        public TpUri(string uriString, UriKind uriKind) : base(uriString, uriKind) {}

        /// <inheritdoc />
        public TpUri(Uri baseUri, string relativeUri) : base(baseUri, relativeUri) {}

        /// <inheritdoc />
        public TpUri(Uri baseUri, Uri relativeUri) : base(baseUri, relativeUri) {}

        /// <inheritdoc />
        public TpUri(SerializationInfo serializationInfo, StreamingContext streamingContext)
            : base(serializationInfo, streamingContext) {}
    }
}