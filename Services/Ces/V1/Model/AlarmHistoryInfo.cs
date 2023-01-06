using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using G42Cloud.SDK.Core;

namespace G42Cloud.SDK.Ces.V1.Model
{
    /// <summary>
    /// 告警历史详细信息
    /// </summary>
    public class AlarmHistoryInfo 
    {

        [JsonProperty("alarm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmId { get; set; }

        [JsonProperty("alarm_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmName { get; set; }

        [JsonProperty("alarm_description", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmDescription { get; set; }

        [JsonProperty("metric", NullValueHandling = NullValueHandling.Ignore)]
        public MetricInfo Metric { get; set; }

        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public Condition Condition { get; set; }

        [JsonProperty("alarm_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? AlarmLevel { get; set; }

        [JsonProperty("alarm_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmType { get; set; }

        [JsonProperty("alarm_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmEnabled { get; set; }

        [JsonProperty("alarm_action_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmActionEnabled { get; set; }

        [JsonProperty("alarm_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> AlarmActions { get; set; }

        [JsonProperty("ok_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> OkActions { get; set; }

        [JsonProperty("insufficientdata_actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AlarmActions> InsufficientdataActions { get; set; }

        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        [JsonProperty("trigger_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? TriggerTime { get; set; }

        [JsonProperty("alarm_status", NullValueHandling = NullValueHandling.Ignore)]
        public string AlarmStatus { get; set; }

        [JsonProperty("datapoints", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataPointForAlarmHistory> Datapoints { get; set; }

        [JsonProperty("additional_info", NullValueHandling = NullValueHandling.Ignore)]
        public AdditionalInfo AdditionalInfo { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlarmHistoryInfo {\n");
            sb.Append("  alarmId: ").Append(AlarmId).Append("\n");
            sb.Append("  alarmName: ").Append(AlarmName).Append("\n");
            sb.Append("  alarmDescription: ").Append(AlarmDescription).Append("\n");
            sb.Append("  metric: ").Append(Metric).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  alarmLevel: ").Append(AlarmLevel).Append("\n");
            sb.Append("  alarmType: ").Append(AlarmType).Append("\n");
            sb.Append("  alarmEnabled: ").Append(AlarmEnabled).Append("\n");
            sb.Append("  alarmActionEnabled: ").Append(AlarmActionEnabled).Append("\n");
            sb.Append("  alarmActions: ").Append(AlarmActions).Append("\n");
            sb.Append("  okActions: ").Append(OkActions).Append("\n");
            sb.Append("  insufficientdataActions: ").Append(InsufficientdataActions).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  triggerTime: ").Append(TriggerTime).Append("\n");
            sb.Append("  alarmStatus: ").Append(AlarmStatus).Append("\n");
            sb.Append("  datapoints: ").Append(Datapoints).Append("\n");
            sb.Append("  additionalInfo: ").Append(AdditionalInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlarmHistoryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlarmHistoryInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AlarmId == input.AlarmId ||
                    (this.AlarmId != null &&
                    this.AlarmId.Equals(input.AlarmId))
                ) && 
                (
                    this.AlarmName == input.AlarmName ||
                    (this.AlarmName != null &&
                    this.AlarmName.Equals(input.AlarmName))
                ) && 
                (
                    this.AlarmDescription == input.AlarmDescription ||
                    (this.AlarmDescription != null &&
                    this.AlarmDescription.Equals(input.AlarmDescription))
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
                    this.AlarmLevel == input.AlarmLevel ||
                    (this.AlarmLevel != null &&
                    this.AlarmLevel.Equals(input.AlarmLevel))
                ) && 
                (
                    this.AlarmType == input.AlarmType ||
                    (this.AlarmType != null &&
                    this.AlarmType.Equals(input.AlarmType))
                ) && 
                (
                    this.AlarmEnabled == input.AlarmEnabled ||
                    (this.AlarmEnabled != null &&
                    this.AlarmEnabled.Equals(input.AlarmEnabled))
                ) && 
                (
                    this.AlarmActionEnabled == input.AlarmActionEnabled ||
                    (this.AlarmActionEnabled != null &&
                    this.AlarmActionEnabled.Equals(input.AlarmActionEnabled))
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
                    this.InsufficientdataActions == input.InsufficientdataActions ||
                    this.InsufficientdataActions != null &&
                    input.InsufficientdataActions != null &&
                    this.InsufficientdataActions.SequenceEqual(input.InsufficientdataActions)
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.TriggerTime == input.TriggerTime ||
                    (this.TriggerTime != null &&
                    this.TriggerTime.Equals(input.TriggerTime))
                ) && 
                (
                    this.AlarmStatus == input.AlarmStatus ||
                    (this.AlarmStatus != null &&
                    this.AlarmStatus.Equals(input.AlarmStatus))
                ) && 
                (
                    this.Datapoints == input.Datapoints ||
                    this.Datapoints != null &&
                    input.Datapoints != null &&
                    this.Datapoints.SequenceEqual(input.Datapoints)
                ) && 
                (
                    this.AdditionalInfo == input.AdditionalInfo ||
                    (this.AdditionalInfo != null &&
                    this.AdditionalInfo.Equals(input.AdditionalInfo))
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
                if (this.AlarmId != null)
                    hashCode = hashCode * 59 + this.AlarmId.GetHashCode();
                if (this.AlarmName != null)
                    hashCode = hashCode * 59 + this.AlarmName.GetHashCode();
                if (this.AlarmDescription != null)
                    hashCode = hashCode * 59 + this.AlarmDescription.GetHashCode();
                if (this.Metric != null)
                    hashCode = hashCode * 59 + this.Metric.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.AlarmLevel != null)
                    hashCode = hashCode * 59 + this.AlarmLevel.GetHashCode();
                if (this.AlarmType != null)
                    hashCode = hashCode * 59 + this.AlarmType.GetHashCode();
                if (this.AlarmEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmEnabled.GetHashCode();
                if (this.AlarmActionEnabled != null)
                    hashCode = hashCode * 59 + this.AlarmActionEnabled.GetHashCode();
                if (this.AlarmActions != null)
                    hashCode = hashCode * 59 + this.AlarmActions.GetHashCode();
                if (this.OkActions != null)
                    hashCode = hashCode * 59 + this.OkActions.GetHashCode();
                if (this.InsufficientdataActions != null)
                    hashCode = hashCode * 59 + this.InsufficientdataActions.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.TriggerTime != null)
                    hashCode = hashCode * 59 + this.TriggerTime.GetHashCode();
                if (this.AlarmStatus != null)
                    hashCode = hashCode * 59 + this.AlarmStatus.GetHashCode();
                if (this.Datapoints != null)
                    hashCode = hashCode * 59 + this.Datapoints.GetHashCode();
                if (this.AdditionalInfo != null)
                    hashCode = hashCode * 59 + this.AdditionalInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
