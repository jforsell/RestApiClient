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
    /// CompanyCert
    /// </summary>
    [DataContract]
    public partial class CompanyCert :  IEquatable<CompanyCert>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCert" /> class.
        /// </summary>
        /// <param name="Pem">An X509 certificate in PEM format.</param>
        /// <param name="Attributes">Attributes.</param>
        public CompanyCert(string Pem = null, CompanyCertAttributes Attributes = null)
        {
            
            
                        this.Pem = Pem;
            
                        this.Attributes = Attributes;
            
        }
        
        /// <summary>
        /// An X509 certificate in PEM format
        /// </summary>
        /// <value>An X509 certificate in PEM format</value>
        [DataMember(Name="pem", EmitDefaultValue=false)]
        public string Pem { get; set; }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public CompanyCertAttributes Attributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCert {\n");
            sb.Append("  Pem: ").Append(Pem).Append("\n");
sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(obj as CompanyCert);
        }

        /// <summary>
        /// Returns true if CompanyCert instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCert to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCert other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Pem == other.Pem ||
                    this.Pem != null &&
                    this.Pem.Equals(other.Pem)
                ) && 
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.Equals(other.Attributes)
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
                if (this.Pem != null)
                    hash = hash * 59 + this.Pem.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                return hash;
            }
        }
    }

}
