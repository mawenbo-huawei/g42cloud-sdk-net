using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using G42Cloud.SDK.Ces.V2.Model;

namespace G42Cloud.SDK.Ces.V2
{
    public partial class CesClient : Client
    {
        public static ClientBuilder<CesClient> NewBuilder()
        {
            return new ClientBuilder<CesClient>();
        }

        
        public AddAlarmRuleResourcesResponse AddAlarmRuleResources(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , addAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>(response);
        }
        
        public BatchDeleteAlarmRulesResponse BatchDeleteAlarmRules(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>(response);
        }
        
        public BatchEnableAlarmRulesResponse BatchEnableAlarmRules(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>(response);
        }
        
        public CreateAlarmRulesResponse CreateAlarmRules(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmRulesResponse>(response);
        }
        
        public DeleteAlarmRuleResourcesResponse DeleteAlarmRuleResources(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>(response);
        }
        
        public ListAgentDimensionInfoResponse ListAgentDimensionInfo(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAgentDimensionInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>(response);
        }
        
        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }
        
        public ListAlarmRulePoliciesResponse ListAlarmRulePolicies(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>(response);
        }
        
        public ListAlarmRuleResourcesResponse ListAlarmRuleResources(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>(response);
        }
        
        public ListAlarmRulesResponse ListAlarmRules(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulesResponse>(response);
        }
        
        public UpdateAlarmRulePoliciesResponse UpdateAlarmRulePolicies(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>(response);
        }
        
    }
}