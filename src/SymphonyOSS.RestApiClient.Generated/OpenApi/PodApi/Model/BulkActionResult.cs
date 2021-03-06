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
    /// The results of list based bulk action. The list contains the result messages\nin the same order as submitted. The message will be an empty string if the action\nwas successful for item in that index.\n
    /// </summary>
    [DataContract]
    public partial class BulkActionResult :  IEquatable<BulkActionResult>
    {
        /// <summary>
        /// Gets or Sets OverallResult
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OverallResultEnum
        {
            
            /// <summary>
            /// Enum Success for "SUCCESS"
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            Success,
            
            /// <summary>
            /// Enum Fail for "FAIL"
            /// </summary>
            [EnumMember(Value = "FAIL")]
            Fail
        }

        /// <summary>
        /// Gets or Sets OverallResult
        /// </summary>
        [DataMember(Name="overallResult", EmitDefaultValue=false)]
        public OverallResultEnum? OverallResult { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkActionResult" /> class.
        /// </summary>
        /// <param name="OverallResult">OverallResult.</param>
        /// <param name="Results">Results.</param>
        public BulkActionResult(OverallResultEnum? OverallResult = null, List<string> Results = null)
        {
            
            
                        this.OverallResult = OverallResult;
            
                        this.Results = Results;
            
        }
        
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<string> Results { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkActionResult {\n");
            sb.Append("  OverallResult: ").Append(OverallResult).Append("\n");
sb.Append("  Results: ").Append(Results).Append("\n");
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
            return this.Equals(obj as BulkActionResult);
        }

        /// <summary>
        /// Returns true if BulkActionResult instances are equal
        /// </summary>
        /// <param name="other">Instance of BulkActionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkActionResult other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OverallResult == other.OverallResult ||
                    this.OverallResult != null &&
                    this.OverallResult.Equals(other.OverallResult)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
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
                if (this.OverallResult != null)
                    hash = hash * 59 + this.OverallResult.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                return hash;
            }
        }
    }

}
