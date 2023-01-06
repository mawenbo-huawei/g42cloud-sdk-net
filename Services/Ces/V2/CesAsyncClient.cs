using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Ces.V2.Model;

namespace G42Cloud.SDK.Ces.V2
{
    public partial class CesAsyncClient : Client
    {
        public static ClientBuilder<CesAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CesAsyncClient>();
        }

        
        public async Task<AddAlarmRuleResourcesResponse> AddAlarmRuleResourcesAsync(AddAlarmRuleResourcesRequest addAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , addAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddAlarmRuleResourcesResponse>(response);
        }
        
        public async Task<BatchDeleteAlarmRulesResponse> BatchDeleteAlarmRulesAsync(BatchDeleteAlarmRulesRequest batchDeleteAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchDeleteAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteAlarmRulesResponse>(response);
        }
        
        public async Task<BatchEnableAlarmRulesResponse> BatchEnableAlarmRulesAsync(BatchEnableAlarmRulesRequest batchEnableAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchEnableAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchEnableAlarmRulesResponse>(response);
        }
        
        public async Task<CreateAlarmRulesResponse> CreateAlarmRulesAsync(CreateAlarmRulesRequest createAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAlarmRulesResponse>(response);
        }
        
        public async Task<DeleteAlarmRuleResourcesResponse> DeleteAlarmRuleResourcesAsync(DeleteAlarmRuleResourcesRequest deleteAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , deleteAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<DeleteAlarmRuleResourcesResponse>(response);
        }
        
        public async Task<ListAgentDimensionInfoResponse> ListAgentDimensionInfoAsync(ListAgentDimensionInfoRequest listAgentDimensionInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , listAgentDimensionInfoRequest.InstanceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/instances/{instance_id}/agent-dimensions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAgentDimensionInfoRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAgentDimensionInfoResponse>(response);
        }
        
        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest listAlarmHistoriesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarm-histories",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmHistoriesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmHistoriesResponse>(response);
        }
        
        public async Task<ListAlarmRulePoliciesResponse> ListAlarmRulePoliciesAsync(ListAlarmRulePoliciesRequest listAlarmRulePoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulePoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulePoliciesResponse>(response);
        }
        
        public async Task<ListAlarmRuleResourcesResponse> ListAlarmRuleResourcesAsync(ListAlarmRuleResourcesRequest listAlarmRuleResourcesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , listAlarmRuleResourcesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/resources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRuleResourcesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRuleResourcesResponse>(response);
        }
        
        public async Task<ListAlarmRulesResponse> ListAlarmRulesAsync(ListAlarmRulesRequest listAlarmRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAlarmRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAlarmRulesResponse>(response);
        }
        
        public async Task<UpdateAlarmRulePoliciesResponse> UpdateAlarmRulePoliciesAsync(UpdateAlarmRulePoliciesRequest updateAlarmRulePoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("alarm_id" , updateAlarmRulePoliciesRequest.AlarmId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/alarms/{alarm_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAlarmRulePoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAlarmRulePoliciesResponse>(response);
        }
        
    }
}