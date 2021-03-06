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
    /// Room Creation Object. Once the chatroom is created, modify attributes and deactive/reactivate via the specific API calls.
    /// </summary>
    [DataContract]
    public partial class RoomCreate :  IEquatable<RoomCreate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomCreate" /> class.
        /// </summary>
        /// <param name="RoomAttributes">RoomAttributes.</param>
        /// <param name="ImmutableRoomAttributes">ImmutableRoomAttributes.</param>
        public RoomCreate(RoomAttributes RoomAttributes = null, ImmutableRoomAttributes ImmutableRoomAttributes = null)
        {
            
            
                        this.RoomAttributes = RoomAttributes;
            
                        this.ImmutableRoomAttributes = ImmutableRoomAttributes;
            
        }
        
        /// <summary>
        /// Gets or Sets RoomAttributes
        /// </summary>
        [DataMember(Name="roomAttributes", EmitDefaultValue=false)]
        public RoomAttributes RoomAttributes { get; set; }
        /// <summary>
        /// Gets or Sets ImmutableRoomAttributes
        /// </summary>
        [DataMember(Name="immutableRoomAttributes", EmitDefaultValue=false)]
        public ImmutableRoomAttributes ImmutableRoomAttributes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomCreate {\n");
            sb.Append("  RoomAttributes: ").Append(RoomAttributes).Append("\n");
sb.Append("  ImmutableRoomAttributes: ").Append(ImmutableRoomAttributes).Append("\n");
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
            return this.Equals(obj as RoomCreate);
        }

        /// <summary>
        /// Returns true if RoomCreate instances are equal
        /// </summary>
        /// <param name="other">Instance of RoomCreate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoomCreate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RoomAttributes == other.RoomAttributes ||
                    this.RoomAttributes != null &&
                    this.RoomAttributes.Equals(other.RoomAttributes)
                ) && 
                (
                    this.ImmutableRoomAttributes == other.ImmutableRoomAttributes ||
                    this.ImmutableRoomAttributes != null &&
                    this.ImmutableRoomAttributes.Equals(other.ImmutableRoomAttributes)
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
                if (this.RoomAttributes != null)
                    hash = hash * 59 + this.RoomAttributes.GetHashCode();
                if (this.ImmutableRoomAttributes != null)
                    hash = hash * 59 + this.ImmutableRoomAttributes.GetHashCode();
                return hash;
            }
        }
    }

}
