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
    /// These attributes cannot be changed once the room has been created
    /// </summary>
    [DataContract]
    public partial class ImmutableRoomAttributes :  IEquatable<ImmutableRoomAttributes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImmutableRoomAttributes" /> class.
        /// </summary>
        /// <param name="_Public">If true, this is a public chatroom. IF false, a private chatroom..</param>
        /// <param name="_ReadOnly">If true, only stream owners can send messages..</param>
        /// <param name="CopyProtected">If true, clients disable the clipboard copy for content in this stream..</param>
        public ImmutableRoomAttributes(bool? _Public = null, bool? _ReadOnly = null, bool? CopyProtected = null)
        {
            
            
                        this._Public = _Public;
            
                        this._ReadOnly = _ReadOnly;
            
                        this.CopyProtected = CopyProtected;
            
        }
        
        /// <summary>
        /// If true, this is a public chatroom. IF false, a private chatroom.
        /// </summary>
        /// <value>If true, this is a public chatroom. IF false, a private chatroom.</value>
        [DataMember(Name="public", EmitDefaultValue=false)]
        public bool? _Public { get; set; }
        /// <summary>
        /// If true, only stream owners can send messages.
        /// </summary>
        /// <value>If true, only stream owners can send messages.</value>
        [DataMember(Name="readOnly", EmitDefaultValue=false)]
        public bool? _ReadOnly { get; set; }
        /// <summary>
        /// If true, clients disable the clipboard copy for content in this stream.
        /// </summary>
        /// <value>If true, clients disable the clipboard copy for content in this stream.</value>
        [DataMember(Name="copyProtected", EmitDefaultValue=false)]
        public bool? CopyProtected { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImmutableRoomAttributes {\n");
            sb.Append("  _Public: ").Append(_Public).Append("\n");
sb.Append("  _ReadOnly: ").Append(_ReadOnly).Append("\n");
sb.Append("  CopyProtected: ").Append(CopyProtected).Append("\n");
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
            return this.Equals(obj as ImmutableRoomAttributes);
        }

        /// <summary>
        /// Returns true if ImmutableRoomAttributes instances are equal
        /// </summary>
        /// <param name="other">Instance of ImmutableRoomAttributes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImmutableRoomAttributes other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._Public == other._Public ||
                    this._Public != null &&
                    this._Public.Equals(other._Public)
                ) && 
                (
                    this._ReadOnly == other._ReadOnly ||
                    this._ReadOnly != null &&
                    this._ReadOnly.Equals(other._ReadOnly)
                ) && 
                (
                    this.CopyProtected == other.CopyProtected ||
                    this.CopyProtected != null &&
                    this.CopyProtected.Equals(other.CopyProtected)
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
                if (this._Public != null)
                    hash = hash * 59 + this._Public.GetHashCode();
                if (this._ReadOnly != null)
                    hash = hash * 59 + this._ReadOnly.GetHashCode();
                if (this.CopyProtected != null)
                    hash = hash * 59 + this.CopyProtected.GetHashCode();
                return hash;
            }
        }
    }

}