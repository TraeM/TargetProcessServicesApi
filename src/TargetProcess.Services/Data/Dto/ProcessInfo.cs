using System.Runtime.Serialization;

namespace TargetProcess.Data.Dto
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ProcessInfo

    {
        /// <summary>
        ///     Entity ID
        /// </summary>
        [DataMember]
        public int? Id { get; set; }

        /// <summary>
        ///     Name of the process
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        ///     Determines whether process is default
        /// </summary>
        [DataMember]
        public bool? IsDefault { get; set; }

        /// <summary>
        ///     Collection of terms of the process
        /// </summary>
        [DataMember]
        public Term[] Terms { get; set; }

        /// <summary>
        ///     Collection of custom fields information of the process
        /// </summary>
        [DataMember]
        public ICustomField[] CustomFields { get; set; }

        /// <summary>
        ///     Collection of practices of the process
        /// </summary>
        [DataMember]
        public Practice[] Practices { get; set; }
    }
}