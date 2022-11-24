using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 标记接受云硬盘过户操作。
    /// </summary>
    public class CinderAcceptVolumeTransferOption 
    {

        [JsonProperty("auth_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthKey { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderAcceptVolumeTransferOption {\n");
            sb.Append("  authKey: ").Append(AuthKey).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderAcceptVolumeTransferOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderAcceptVolumeTransferOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthKey == input.AuthKey ||
                    (this.AuthKey != null &&
                    this.AuthKey.Equals(input.AuthKey))
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
                if (this.AuthKey != null)
                    hashCode = hashCode * 59 + this.AuthKey.GetHashCode();
                return hashCode;
            }
        }
    }
}
