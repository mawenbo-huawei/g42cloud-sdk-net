using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 云硬盘的元数据。
    /// </summary>
    public class VolumeMetadata 
    {

        [JsonProperty("__system__cmkid", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemCmkid { get; set; }

        [JsonProperty("__system__encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemEncrypted { get; set; }

        [JsonProperty("full_clone", NullValueHandling = NullValueHandling.Ignore)]
        public string FullClone { get; set; }

        [JsonProperty("hw:passthrough", NullValueHandling = NullValueHandling.Ignore)]
        public string Hwpassthrough { get; set; }

        [JsonProperty("orderID", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderID { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeMetadata {\n");
            sb.Append("  systemCmkid: ").Append(SystemCmkid).Append("\n");
            sb.Append("  systemEncrypted: ").Append(SystemEncrypted).Append("\n");
            sb.Append("  fullClone: ").Append(FullClone).Append("\n");
            sb.Append("  hwpassthrough: ").Append(Hwpassthrough).Append("\n");
            sb.Append("  orderID: ").Append(OrderID).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeMetadata);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeMetadata input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SystemCmkid == input.SystemCmkid ||
                    (this.SystemCmkid != null &&
                    this.SystemCmkid.Equals(input.SystemCmkid))
                ) && 
                (
                    this.SystemEncrypted == input.SystemEncrypted ||
                    (this.SystemEncrypted != null &&
                    this.SystemEncrypted.Equals(input.SystemEncrypted))
                ) && 
                (
                    this.FullClone == input.FullClone ||
                    (this.FullClone != null &&
                    this.FullClone.Equals(input.FullClone))
                ) && 
                (
                    this.Hwpassthrough == input.Hwpassthrough ||
                    (this.Hwpassthrough != null &&
                    this.Hwpassthrough.Equals(input.Hwpassthrough))
                ) && 
                (
                    this.OrderID == input.OrderID ||
                    (this.OrderID != null &&
                    this.OrderID.Equals(input.OrderID))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SystemCmkid != null)
                    hashCode = hashCode * 59 + this.SystemCmkid.GetHashCode();
                if (this.SystemEncrypted != null)
                    hashCode = hashCode * 59 + this.SystemEncrypted.GetHashCode();
                if (this.FullClone != null)
                    hashCode = hashCode * 59 + this.FullClone.GetHashCode();
                if (this.Hwpassthrough != null)
                    hashCode = hashCode * 59 + this.Hwpassthrough.GetHashCode();
                if (this.OrderID != null)
                    hashCode = hashCode * 59 + this.OrderID.GetHashCode();
                return hashCode;
            }
        }
    }
}
