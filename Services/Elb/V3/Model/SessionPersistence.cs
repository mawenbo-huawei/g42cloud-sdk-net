using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 会话持久性对象。
    /// </summary>
    public class SessionPersistence 
    {

        [JsonProperty("cookie_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CookieName { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("persistence_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? PersistenceTimeout { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SessionPersistence {\n");
            sb.Append("  cookieName: ").Append(CookieName).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  persistenceTimeout: ").Append(PersistenceTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SessionPersistence);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SessionPersistence input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CookieName == input.CookieName ||
                    (this.CookieName != null &&
                    this.CookieName.Equals(input.CookieName))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PersistenceTimeout == input.PersistenceTimeout ||
                    (this.PersistenceTimeout != null &&
                    this.PersistenceTimeout.Equals(input.PersistenceTimeout))
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
                if (this.CookieName != null)
                    hashCode = hashCode * 59 + this.CookieName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PersistenceTimeout != null)
                    hashCode = hashCode * 59 + this.PersistenceTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
