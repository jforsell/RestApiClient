using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SymphonyOSS.RestApiClient.Generated.OpenApi.PodApi.Model
{
    /// <summary>
    /// CompanyCertStatus
    /// </summary>
    [DataContract]
    public partial class CompanyCertStatus :  IEquatable<CompanyCertStatus>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum Trusted for "TRUSTED"
            /// </summary>
            [EnumMember(Value = "TRUSTED")]
            Trusted,
            
            /// <summary>
            /// Enum Known for "KNOWN"
            /// </summary>
            [EnumMember(Value = "KNOWN")]
            Known,
            
            /// <summary>
            /// Enum Revoked for "REVOKED"
            /// </summary>
            [EnumMember(Value = "REVOKED")]
            Revoked,
            
            /// <summary>
            /// Enum Disabled for "DISABLED"
            /// </summary>
            [EnumMember(Value = "DISABLED")]
            Disabled
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCertStatus" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        public CompanyCertStatus(TypeEnum? Type = null)
        {
            
            
                        this.Type = Type;
            
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCertStatus {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CompanyCertStatus);
        }

        /// <summary>
        /// Returns true if CompanyCertStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCertStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCertStatus other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                return hash;
            }
        }
    }

}
