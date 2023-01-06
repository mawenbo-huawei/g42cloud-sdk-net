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
    public class ListInstanceRequestBody 
    {

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTags> Tags { get; set; }

        [JsonProperty("tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTags> TagsAny { get; set; }

        [JsonProperty("not_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTags> NotTags { get; set; }

        [JsonProperty("not_tags_any", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceTags> NotTagsAny { get; set; }

        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public string Action { get; set; }

        [JsonProperty("matches", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagMatch> Matches { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInstanceRequestBody {\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  tagsAny: ").Append(TagsAny).Append("\n");
            sb.Append("  notTags: ").Append(NotTags).Append("\n");
            sb.Append("  notTagsAny: ").Append(NotTagsAny).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  action: ").Append(Action).Append("\n");
            sb.Append("  matches: ").Append(Matches).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInstanceRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInstanceRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TagsAny == input.TagsAny ||
                    this.TagsAny != null &&
                    input.TagsAny != null &&
                    this.TagsAny.SequenceEqual(input.TagsAny)
                ) && 
                (
                    this.NotTags == input.NotTags ||
                    this.NotTags != null &&
                    input.NotTags != null &&
                    this.NotTags.SequenceEqual(input.NotTags)
                ) && 
                (
                    this.NotTagsAny == input.NotTagsAny ||
                    this.NotTagsAny != null &&
                    input.NotTagsAny != null &&
                    this.NotTagsAny.SequenceEqual(input.NotTagsAny)
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
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
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.TagsAny != null)
                    hashCode = hashCode * 59 + this.TagsAny.GetHashCode();
                if (this.NotTags != null)
                    hashCode = hashCode * 59 + this.NotTags.GetHashCode();
                if (this.NotTagsAny != null)
                    hashCode = hashCode * 59 + this.NotTagsAny.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                return hashCode;
            }
        }
    }
}
