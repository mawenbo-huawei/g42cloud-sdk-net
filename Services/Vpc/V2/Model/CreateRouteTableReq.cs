using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateRouteTableReq 
    {

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("routes", NullValueHandling = NullValueHandling.Ignore)]
        public List<RouteTableRoute> Routes { get; set; }

        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateRouteTableReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  routes: ").Append(Routes).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateRouteTableReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateRouteTableReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Routes == input.Routes ||
                    this.Routes != null &&
                    input.Routes != null &&
                    this.Routes.SequenceEqual(input.Routes)
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Routes != null)
                    hashCode = hashCode * 59 + this.Routes.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
