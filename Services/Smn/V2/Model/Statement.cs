using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Statement 
    {

        [JsonProperty("Sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        [JsonProperty("Effect", NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        [JsonProperty("Principal", NullValueHandling = NullValueHandling.Ignore)]
        public string Principal { get; set; }

        [JsonProperty("NotPrincipal", NullValueHandling = NullValueHandling.Ignore)]
        public string NotPrincipal { get; set; }

        [JsonProperty("Action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("NotAction", NullValueHandling = NullValueHandling.Ignore)]
        public string NotAction { get; set; }

        [JsonProperty("Resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        [JsonProperty("NotResource", NullValueHandling = NullValueHandling.Ignore)]
        public string NotResource { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statement {\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  effect: ").Append(Effect).Append("\n");
            sb.Append("  principal: ").Append(Principal).Append("\n");
            sb.Append("  notPrincipal: ").Append(NotPrincipal).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  notAction: ").Append(NotAction).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  notResource: ").Append(NotResource).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Statement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Statement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.Effect == input.Effect ||
                    (this.Effect != null &&
                    this.Effect.Equals(input.Effect))
                ) && 
                (
                    this.Principal == input.Principal ||
                    (this.Principal != null &&
                    this.Principal.Equals(input.Principal))
                ) && 
                (
                    this.NotPrincipal == input.NotPrincipal ||
                    (this.NotPrincipal != null &&
                    this.NotPrincipal.Equals(input.NotPrincipal))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.NotAction == input.NotAction ||
                    (this.NotAction != null &&
                    this.NotAction.Equals(input.NotAction))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.NotResource == input.NotResource ||
                    (this.NotResource != null &&
                    this.NotResource.Equals(input.NotResource))
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
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.Effect != null)
                    hashCode = hashCode * 59 + this.Effect.GetHashCode();
                if (this.Principal != null)
                    hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.NotPrincipal != null)
                    hashCode = hashCode * 59 + this.NotPrincipal.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.NotAction != null)
                    hashCode = hashCode * 59 + this.NotAction.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.NotResource != null)
                    hashCode = hashCode * 59 + this.NotResource.GetHashCode();
                return hashCode;
            }
        }
    }
}
