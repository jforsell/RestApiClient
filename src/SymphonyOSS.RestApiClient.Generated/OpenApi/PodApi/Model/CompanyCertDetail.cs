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
    /// CompanyCertDetail
    /// </summary>
    [DataContract]
    public partial class CompanyCertDetail :  IEquatable<CompanyCertDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyCertDetail" /> class.
        /// </summary>
        /// <param name="CompanyCertAttributes">CompanyCertAttributes.</param>
        /// <param name="CompanyCertInfo">CompanyCertInfo.</param>
        /// <param name="CertInfo">CertInfo.</param>
        public CompanyCertDetail(CompanyCertAttributes CompanyCertAttributes = null, CompanyCertInfo CompanyCertInfo = null, CertInfo CertInfo = null)
        {
            
            
                        this.CompanyCertAttributes = CompanyCertAttributes;
            
                        this.CompanyCertInfo = CompanyCertInfo;
            
                        this.CertInfo = CertInfo;
            
        }
        
        /// <summary>
        /// Gets or Sets CompanyCertAttributes
        /// </summary>
        [DataMember(Name="companyCertAttributes", EmitDefaultValue=false)]
        public CompanyCertAttributes CompanyCertAttributes { get; set; }
        /// <summary>
        /// Gets or Sets CompanyCertInfo
        /// </summary>
        [DataMember(Name="companyCertInfo", EmitDefaultValue=false)]
        public CompanyCertInfo CompanyCertInfo { get; set; }
        /// <summary>
        /// Gets or Sets CertInfo
        /// </summary>
        [DataMember(Name="certInfo", EmitDefaultValue=false)]
        public CertInfo CertInfo { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyCertDetail {\n");
            sb.Append("  CompanyCertAttributes: ").Append(CompanyCertAttributes).Append("\n");
sb.Append("  CompanyCertInfo: ").Append(CompanyCertInfo).Append("\n");
sb.Append("  CertInfo: ").Append(CertInfo).Append("\n");
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
            return this.Equals(obj as CompanyCertDetail);
        }

        /// <summary>
        /// Returns true if CompanyCertDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of CompanyCertDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyCertDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyCertAttributes == other.CompanyCertAttributes ||
                    this.CompanyCertAttributes != null &&
                    this.CompanyCertAttributes.Equals(other.CompanyCertAttributes)
                ) && 
                (
                    this.CompanyCertInfo == other.CompanyCertInfo ||
                    this.CompanyCertInfo != null &&
                    this.CompanyCertInfo.Equals(other.CompanyCertInfo)
                ) && 
                (
                    this.CertInfo == other.CertInfo ||
                    this.CertInfo != null &&
                    this.CertInfo.Equals(other.CertInfo)
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
                if (this.CompanyCertAttributes != null)
                    hash = hash * 59 + this.CompanyCertAttributes.GetHashCode();
                if (this.CompanyCertInfo != null)
                    hash = hash * 59 + this.CompanyCertInfo.GetHashCode();
                if (this.CertInfo != null)
                    hash = hash * 59 + this.CertInfo.GetHashCode();
                return hash;
            }
        }
    }

}
