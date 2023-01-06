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
    /// Response Object
    /// </summary>
    public class ListSubscriptionsResponse : SdkResponse
    {

        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }

        [JsonProperty("subscription_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SubscriptionCount { get; set; }

        [JsonProperty("subscriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListSubscriptionsItem> Subscriptions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubscriptionsResponse {\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("  subscriptionCount: ").Append(SubscriptionCount).Append("\n");
            sb.Append("  subscriptions: ").Append(Subscriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubscriptionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubscriptionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.SubscriptionCount == input.SubscriptionCount ||
                    (this.SubscriptionCount != null &&
                    this.SubscriptionCount.Equals(input.SubscriptionCount))
                ) && 
                (
                    this.Subscriptions == input.Subscriptions ||
                    this.Subscriptions != null &&
                    input.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(input.Subscriptions)
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.SubscriptionCount != null)
                    hashCode = hashCode * 59 + this.SubscriptionCount.GetHashCode();
                if (this.Subscriptions != null)
                    hashCode = hashCode * 59 + this.Subscriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
