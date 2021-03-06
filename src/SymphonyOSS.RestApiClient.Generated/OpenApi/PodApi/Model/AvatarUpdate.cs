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
    /// AvatarUpdate
    /// </summary>
    [DataContract]
    public partial class AvatarUpdate :  IEquatable<AvatarUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarUpdate" /> class.
        /// </summary>
        /// <param name="Image">Base64 encoded image. Original image must be less than 2MB..</param>
        public AvatarUpdate(string Image = null)
        {
            
            
                        this.Image = Image;
            
        }
        
        /// <summary>
        /// Base64 encoded image. Original image must be less than 2MB.
        /// </summary>
        /// <value>Base64 encoded image. Original image must be less than 2MB.</value>
        [DataMember(Name="image", EmitDefaultValue=false)]
        public string Image { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AvatarUpdate {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
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
            return this.Equals(obj as AvatarUpdate);
        }

        /// <summary>
        /// Returns true if AvatarUpdate instances are equal
        /// </summary>
        /// <param name="other">Instance of AvatarUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AvatarUpdate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Image == other.Image ||
                    this.Image != null &&
                    this.Image.Equals(other.Image)
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
                if (this.Image != null)
                    hash = hash * 59 + this.Image.GetHashCode();
                return hash;
            }
        }
    }

}
