using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Elb.V3.Model;

namespace G42Cloud.SDK.Elb.V3
{
    public partial class ElbAsyncClient : Client
    {
        public static ClientBuilder<ElbAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ElbAsyncClient>();
        }

        
        public async Task<BatchCreateMembersResponse> BatchCreateMembersAsync(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchCreateMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }
        
        public async Task<BatchDeleteMembersResponse> BatchDeleteMembersAsync(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchDeleteMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        public async Task<BatchUpdatePoliciesPriorityResponse> BatchUpdatePoliciesPriorityAsync(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>(response);
        }
        
        public async Task<ChangeLoadbalancerChargeModeResponse> ChangeLoadbalancerChargeModeAsync(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>(response);
        }
        
        public async Task<CreateCertificateResponse> CreateCertificateAsync(CreateCertificateRequest createCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }
        
        public async Task<CreateHealthMonitorResponse> CreateHealthMonitorAsync(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateHealthMonitorResponse>(response);
        }
        
        public async Task<CreateL7PolicyResponse> CreateL7PolicyAsync(CreateL7PolicyRequest createL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7PolicyResponse>(response);
        }
        
        public async Task<CreateL7RuleResponse> CreateL7RuleAsync(CreateL7RuleRequest createL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , createL7RuleRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }
        
        public async Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest createListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }
        
        public async Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLoadBalancerResponse>(response);
        }
        
        public async Task<CreateLogtankResponse> CreateLogtankAsync(CreateLogtankRequest createLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }
        
        public async Task<CreateMemberResponse> CreateMemberAsync(CreateMemberRequest createMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , createMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }
        
        public async Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest createPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }
        
        public async Task<CreateSecurityPolicyResponse> CreateSecurityPolicyAsync(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityPolicyResponse>(response);
        }
        
        public async Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }
        
        public async Task<DeleteHealthMonitorResponse> DeleteHealthMonitorAsync(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , deleteHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }
        
        public async Task<DeleteL7PolicyResponse> DeleteL7PolicyAsync(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }
        
        public async Task<DeleteL7RuleResponse> DeleteL7RuleAsync(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , deleteL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }
        
        public async Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest deleteListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , deleteListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }
        
        public async Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , deleteLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }
        
        public async Task<DeleteLogtankResponse> DeleteLogtankAsync(DeleteLogtankRequest deleteLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , deleteLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }
        
        public async Task<DeleteMemberResponse> DeleteMemberAsync(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        public async Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest deletePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deletePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }
        
        public async Task<DeleteSecurityPolicyResponse> DeleteSecurityPolicyAsync(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , deleteSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }
        
        public async Task<ListAllMembersResponse> ListAllMembersAsync(ListAllMembersRequest listAllMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAllMembersResponse>(response);
        }
        
        public async Task<ListAvailabilityZonesResponse> ListAvailabilityZonesAsync(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }
        
        public async Task<ListCertificatesResponse> ListCertificatesAsync(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        public async Task<ListFlavorsResponse> ListFlavorsAsync(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        public async Task<ListHealthMonitorsResponse> ListHealthMonitorsAsync(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListHealthMonitorsResponse>(response);
        }
        
        public async Task<ListL7PoliciesResponse> ListL7PoliciesAsync(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7PoliciesResponse>(response);
        }
        
        public async Task<ListL7RulesResponse> ListL7RulesAsync(ListL7RulesRequest listL7RulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , listL7RulesRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }
        
        public async Task<ListListenersResponse> ListListenersAsync(ListListenersRequest listListenersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }
        
        public async Task<ListLoadBalancersResponse> ListLoadBalancersAsync(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLoadBalancersResponse>(response);
        }
        
        public async Task<ListLogtanksResponse> ListLogtanksAsync(ListLogtanksRequest listLogtanksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }
        
        public async Task<ListMembersResponse> ListMembersAsync(ListMembersRequest listMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , listMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }
        
        public async Task<ListPoolsResponse> ListPoolsAsync(ListPoolsRequest listPoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }
        
        public async Task<ListQuotaDetailsResponse> ListQuotaDetailsAsync(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }
        
        public async Task<ListSecurityPoliciesResponse> ListSecurityPoliciesAsync(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityPoliciesResponse>(response);
        }
        
        public async Task<ListSystemSecurityPoliciesResponse> ListSystemSecurityPoliciesAsync(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>(response);
        }
        
        public async Task<ShowCertificateResponse> ShowCertificateAsync(ShowCertificateRequest showCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , showCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }
        
        public async Task<ShowFlavorResponse> ShowFlavorAsync(ShowFlavorRequest showFlavorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id" , showFlavorRequest.FlavorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }
        
        public async Task<ShowHealthMonitorResponse> ShowHealthMonitorAsync(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , showHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }
        
        public async Task<ShowL7PolicyResponse> ShowL7PolicyAsync(ShowL7PolicyRequest showL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }
        
        public async Task<ShowL7RuleResponse> ShowL7RuleAsync(ShowL7RuleRequest showL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , showL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }
        
        public async Task<ShowListenerResponse> ShowListenerAsync(ShowListenerRequest showListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , showListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }
        
        public async Task<ShowLoadBalancerResponse> ShowLoadBalancerAsync(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }
        
        public async Task<ShowLoadBalancerStatusResponse> ShowLoadBalancerStatusAsync(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerStatusRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }
        
        public async Task<ShowLogtankResponse> ShowLogtankAsync(ShowLogtankRequest showLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , showLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }
        
        public async Task<ShowMemberResponse> ShowMemberAsync(ShowMemberRequest showMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , showMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }
        
        public async Task<ShowPoolResponse> ShowPoolAsync(ShowPoolRequest showPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showPoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }
        
        public async Task<ShowQuotaResponse> ShowQuotaAsync(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public async Task<ShowSecurityPolicyResponse> ShowSecurityPolicyAsync(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , showSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }
        
        public async Task<UpdateCertificateResponse> UpdateCertificateAsync(UpdateCertificateRequest updateCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , updateCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }
        
        public async Task<UpdateHealthMonitorResponse> UpdateHealthMonitorAsync(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , updateHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }
        
        public async Task<UpdateL7PolicyResponse> UpdateL7PolicyAsync(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }
        
        public async Task<UpdateL7RuleResponse> UpdateL7RuleAsync(UpdateL7RuleRequest updateL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , updateL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
        }
        
        public async Task<UpdateListenerResponse> UpdateListenerAsync(UpdateListenerRequest updateListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , updateListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }
        
        public async Task<UpdateLoadBalancerResponse> UpdateLoadBalancerAsync(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , updateLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }
        
        public async Task<UpdateLogtankResponse> UpdateLogtankAsync(UpdateLogtankRequest updateLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , updateLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }
        
        public async Task<UpdateMemberResponse> UpdateMemberAsync(UpdateMemberRequest updateMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id" , updateMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }
        
        public async Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest updatePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , updatePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }
        
        public async Task<UpdateSecurityPolicyResponse> UpdateSecurityPolicyAsync(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , updateSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }
        
        public async Task<ListApiVersionsResponse> ListApiVersionsAsync(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        public async Task<BatchDeleteIpListResponse> BatchDeleteIpListAsync(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , batchDeleteIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }
        
        public async Task<CountPreoccupyIpNumResponse> CountPreoccupyIpNumAsync(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>(response);
        }
        
        public async Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest createIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }
        
        public async Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , deleteIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }
        
        public async Task<ListIpGroupsResponse> ListIpGroupsAsync(ListIpGroupsRequest listIpGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }
        
        public async Task<ShowIpGroupResponse> ShowIpGroupAsync(ShowIpGroupRequest showIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , showIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }
        
        public async Task<UpdateIpGroupResponse> UpdateIpGroupAsync(UpdateIpGroupRequest updateIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }
        
        public async Task<UpdateIpListResponse> UpdateIpListAsync(UpdateIpListRequest updateIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }
        
    }
}