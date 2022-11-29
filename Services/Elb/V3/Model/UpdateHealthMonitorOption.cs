using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace G42Cloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 更新健康检查请求参数。
    /// </summary>
    public class UpdateHealthMonitorOption 
    {
        [JsonConverter(typeof(EnumClassConverter<HttpMethodEnum>))]
        public class HttpMethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            public static readonly HttpMethodEnum GET = new HttpMethodEnum("GET");

            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            public static readonly HttpMethodEnum HEAD = new HttpMethodEnum("HEAD");

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            public static readonly HttpMethodEnum POST = new HttpMethodEnum("POST");

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            public static readonly HttpMethodEnum PUT = new HttpMethodEnum("PUT");

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            public static readonly HttpMethodEnum DELETE = new HttpMethodEnum("DELETE");

            /// <summary>
            /// Enum TRACE for value: TRACE
            /// </summary>
            public static readonly HttpMethodEnum TRACE = new HttpMethodEnum("TRACE");

            /// <summary>
            /// Enum OPTIONS for value: OPTIONS
            /// </summary>
            public static readonly HttpMethodEnum OPTIONS = new HttpMethodEnum("OPTIONS");

            /// <summary>
            /// Enum CONNECT for value: CONNECT
            /// </summary>
            public static readonly HttpMethodEnum CONNECT = new HttpMethodEnum("CONNECT");

            /// <summary>
            /// Enum PATCH for value: PATCH
            /// </summary>
            public static readonly HttpMethodEnum PATCH = new HttpMethodEnum("PATCH");

            private static readonly Dictionary<string, HttpMethodEnum> StaticFields =
            new Dictionary<string, HttpMethodEnum>()
            {
                { "GET", GET },
                { "HEAD", HEAD },
                { "POST", POST },
                { "PUT", PUT },
                { "DELETE", DELETE },
                { "TRACE", TRACE },
                { "OPTIONS", OPTIONS },
                { "CONNECT", CONNECT },
                { "PATCH", PATCH },
            };

            private string Value;

            public HttpMethodEnum(string value)
            {
                Value = value;
            }

            public static HttpMethodEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as HttpMethodEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HttpMethodEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(HttpMethodEnum a, HttpMethodEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HttpMethodEnum a, HttpMethodEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public int? Delay { get; set; }

        [JsonProperty("domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainName { get; set; }

        [JsonProperty("expected_codes", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpectedCodes { get; set; }

        [JsonProperty("http_method", NullValueHandling = NullValueHandling.Ignore)]
        public HttpMethodEnum HttpMethod { get; set; }
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetries { get; set; }

        [JsonProperty("max_retries_down", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetriesDown { get; set; }

        [JsonProperty("monitor_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? MonitorPort { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        [JsonProperty("url_path", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlPath { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateHealthMonitorOption {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  domainName: ").Append(DomainName).Append("\n");
            sb.Append("  expectedCodes: ").Append(ExpectedCodes).Append("\n");
            sb.Append("  httpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  maxRetriesDown: ").Append(MaxRetriesDown).Append("\n");
            sb.Append("  monitorPort: ").Append(MonitorPort).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  urlPath: ").Append(UrlPath).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateHealthMonitorOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateHealthMonitorOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.DomainName == input.DomainName ||
                    (this.DomainName != null &&
                    this.DomainName.Equals(input.DomainName))
                ) && 
                (
                    this.ExpectedCodes == input.ExpectedCodes ||
                    (this.ExpectedCodes != null &&
                    this.ExpectedCodes.Equals(input.ExpectedCodes))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    (this.HttpMethod != null &&
                    this.HttpMethod.Equals(input.HttpMethod))
                ) && 
                (
                    this.MaxRetries == input.MaxRetries ||
                    (this.MaxRetries != null &&
                    this.MaxRetries.Equals(input.MaxRetries))
                ) && 
                (
                    this.MaxRetriesDown == input.MaxRetriesDown ||
                    (this.MaxRetriesDown != null &&
                    this.MaxRetriesDown.Equals(input.MaxRetriesDown))
                ) && 
                (
                    this.MonitorPort == input.MonitorPort ||
                    (this.MonitorPort != null &&
                    this.MonitorPort.Equals(input.MonitorPort))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    (this.Timeout != null &&
                    this.Timeout.Equals(input.Timeout))
                ) && 
                (
                    this.UrlPath == input.UrlPath ||
                    (this.UrlPath != null &&
                    this.UrlPath.Equals(input.UrlPath))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.DomainName != null)
                    hashCode = hashCode * 59 + this.DomainName.GetHashCode();
                if (this.ExpectedCodes != null)
                    hashCode = hashCode * 59 + this.ExpectedCodes.GetHashCode();
                if (this.HttpMethod != null)
                    hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                if (this.MaxRetries != null)
                    hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.MaxRetriesDown != null)
                    hashCode = hashCode * 59 + this.MaxRetriesDown.GetHashCode();
                if (this.MonitorPort != null)
                    hashCode = hashCode * 59 + this.MonitorPort.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Timeout != null)
                    hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.UrlPath != null)
                    hashCode = hashCode * 59 + this.UrlPath.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
