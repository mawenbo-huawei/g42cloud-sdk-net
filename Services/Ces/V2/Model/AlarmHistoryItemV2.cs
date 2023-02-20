using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 告警记录详细信息
    /// </summary>
    public class AlarmHistoryItemV2 
    {
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OK for value: ok
            /// </summary>
            public static readonly StatusEnum OK = new StatusEnum("ok");

            /// <summary>
            /// Enum ALARM for value: alarm
            /// </summary>
            public static readonly StatusEnum ALARM = new StatusEnum("alarm");

            /// <summary>
            /// Enum INVALID for value: invalid
            /// </summary>
            public static readonly StatusEnum INVALID = new StatusEnum("invalid");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ok", OK },
                { "alarm", ALARM },
                { "invalid", INVALID },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<LevelEnum>))]
        public class LevelEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly LevelEnum NUMBER_1 = new LevelEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly LevelEnum NUMBER_2 = new LevelEnum(2);

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            public static readonly LevelEnum NUMBER_3 = new LevelEnum(3);

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly LevelEnum NUMBER_4 = new LevelEnum(4);

            private static readonly Dictionary<int?, LevelEnum> StaticFields =
            new Dictionary<int?, LevelEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
                { 3, NUMBER_3 },
                { 4, NUMBER_4 },
            };

            private int? _value;

            public LevelEnum()
            {

            }

            public LevelEnum(int? value)
            {
                _value = value;
            }

            public static LevelEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as LevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LevelEnum a, LevelEnum b)
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

            public static bool operator !=(LevelEnum a, LevelEnum b)
            {
                return !(a == b);
            }
        }

        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EVENT_SYS for value: EVENT.SYS
            /// </summary>
            public static readonly TypeEnum EVENT_SYS = new TypeEnum("EVENT.SYS");

            /// <summary>
            /// Enum EVENT_CUSTOM for value: EVENT.CUSTOM
            /// </summary>
            public static readonly TypeEnum EVENT_CUSTOM = new TypeEnum("EVENT.CUSTOM");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EVENT.SYS", EVENT_SYS },
                { "EVENT.CUSTOM", EVENT_CUSTOM },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public LevelEnum Level { get; set; }
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        [JsonProperty("action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionEnabled { get; set; }

        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? BeginTime { get; set; }

        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? EndTime { get; set; }

        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public Metric Metric { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmCondition Condition { get; set; }

        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfo AdditionalInfo { get; set; }

        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> AlarmActions { get; set; }

        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Notification> OkActions { get; set; }

        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointInfo> Datapoints { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmHistoryItemV2 {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  actionEnabled: ").Append(ActionEnabled).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  additionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmHistoryItemV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmHistoryItemV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.ActionEnabled == input.ActionEnabled ||
                    (this.ActionEnabled != null &&
                    this.ActionEnabled.Equals(input.ActionEnabled))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Metric == input.Metric ||
                    (this.Metric != null &&
                    this.Metric.Equals(input.Metric))
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
                ) && 
                (
                    this.AlarmActions == input.AlarmActions ||
                    this.AlarmActions != null &&
                    input.AlarmActions != null &&
                    this.AlarmActions.SequenceEqual(input.AlarmActions)
                ) && 
                (
                    this.OkActions == input.OkActions ||
                    this.OkActions != null &&
                    input.OkActions != null &&
                    this.OkActions.SequenceEqual(input.OkActions)
                ) && 
                (
                    this.Datapoints == input.Datapoints ||
                    this.Datapoints != null &&
                    input.Datapoints != null &&
                    this.Datapoints.SequenceEqual(input.Datapoints)
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
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ActionEnabled != null)
                    hashCode = hashCode * 59 + this.ActionEnabled.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.Datapoints != null)
                    hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                return hashCode;
            }
        }
    }
}
