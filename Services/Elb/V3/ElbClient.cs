using System;
using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Elb.V3.Model;

namespace G42Cloud.SDK.Elb.V3
{
    public partial class ElbClient : Client
    {
        public static ClientBuilder<ElbClient> NewBuilder()
        {
            return new ClientBuilder<ElbClient>();
        }

        
        public BatchCreateMembersResponse BatchCreateMembers(BatchCreateMembersRequest batchCreateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchCreateMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-add",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateMembersResponse>(response);
        }
        
        public BatchDeleteMembersResponse BatchDeleteMembers(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , batchDeleteMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        public BatchUpdatePoliciesPriorityResponse BatchUpdatePoliciesPriority(BatchUpdatePoliciesPriorityRequest batchUpdatePoliciesPriorityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/batch-update-priority",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdatePoliciesPriorityRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchUpdatePoliciesPriorityResponse>(response);
        }
        
        public ChangeLoadbalancerChargeModeResponse ChangeLoadbalancerChargeMode(ChangeLoadbalancerChargeModeRequest changeLoadbalancerChargeModeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/change-charge-mode",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", changeLoadbalancerChargeModeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ChangeLoadbalancerChargeModeResponse>(response);
        }
        
        public CreateCertificateResponse CreateCertificate(CreateCertificateRequest createCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCertificateResponse>(response);
        }
        
        public CreateHealthMonitorResponse CreateHealthMonitor(CreateHealthMonitorRequest createHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createHealthMonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateHealthMonitorResponse>(response);
        }
        
        public CreateL7PolicyResponse CreateL7Policy(CreateL7PolicyRequest createL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateL7PolicyResponse>(response);
        }
        
        public CreateL7RuleResponse CreateL7Rule(CreateL7RuleRequest createL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , createL7RuleRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createL7RuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateL7RuleResponse>(response);
        }
        
        public CreateListenerResponse CreateListener(CreateListenerRequest createListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateListenerResponse>(response);
        }
        
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLoadBalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLoadBalancerResponse>(response);
        }
        
        public CreateLogtankResponse CreateLogtank(CreateLogtankRequest createLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createLogtankRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateLogtankResponse>(response);
        }
        
        public CreateMemberResponse CreateMember(CreateMemberRequest createMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , createMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMemberResponse>(response);
        }
        
        public CreatePoolResponse CreatePool(CreatePoolRequest createPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePoolResponse>(response);
        }
        
        public CreateSecurityPolicyResponse CreateSecurityPolicy(CreateSecurityPolicyRequest createSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityPolicyResponse>(response);
        }
        
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest deleteCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , deleteCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteCertificateResponse>(response);
        }
        
        public DeleteHealthMonitorResponse DeleteHealthMonitor(DeleteHealthMonitorRequest deleteHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , deleteHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteHealthMonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteHealthMonitorResponse>(response);
        }
        
        public DeleteL7PolicyResponse DeleteL7Policy(DeleteL7PolicyRequest deleteL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7PolicyResponse>(response);
        }
        
        public DeleteL7RuleResponse DeleteL7Rule(DeleteL7RuleRequest deleteL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , deleteL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , deleteL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteL7RuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteL7RuleResponse>(response);
        }
        
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest deleteListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , deleteListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteListenerResponse>(response);
        }
        
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , deleteLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLoadBalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLoadBalancerResponse>(response);
        }
        
        public DeleteLogtankResponse DeleteLogtank(DeleteLogtankRequest deleteLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , deleteLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteLogtankRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteLogtankResponse>(response);
        }
        
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deleteMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        public DeletePoolResponse DeletePool(DeletePoolRequest deletePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , deletePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePoolResponse>(response);
        }
        
        public DeleteSecurityPolicyResponse DeleteSecurityPolicy(DeleteSecurityPolicyRequest deleteSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , deleteSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityPolicyResponse>(response);
        }
        
        public ListAllMembersResponse ListAllMembers(ListAllMembersRequest listAllMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAllMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAllMembersResponse>(response);
        }
        
        public ListAvailabilityZonesResponse ListAvailabilityZones(ListAvailabilityZonesRequest listAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/availability-zones",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAvailabilityZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListAvailabilityZonesResponse>(response);
        }
        
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest listCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listCertificatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListCertificatesResponse>(response);
        }
        
        public ListFlavorsResponse ListFlavors(ListFlavorsRequest listFlavorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listFlavorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListFlavorsResponse>(response);
        }
        
        public ListHealthMonitorsResponse ListHealthMonitors(ListHealthMonitorsRequest listHealthMonitorsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listHealthMonitorsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListHealthMonitorsResponse>(response);
        }
        
        public ListL7PoliciesResponse ListL7Policies(ListL7PoliciesRequest listL7PoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7PoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListL7PoliciesResponse>(response);
        }
        
        public ListL7RulesResponse ListL7Rules(ListL7RulesRequest listL7RulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , listL7RulesRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listL7RulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListL7RulesResponse>(response);
        }
        
        public ListListenersResponse ListListeners(ListListenersRequest listListenersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listListenersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListListenersResponse>(response);
        }
        
        public ListLoadBalancersResponse ListLoadBalancers(ListLoadBalancersRequest listLoadBalancersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLoadBalancersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLoadBalancersResponse>(response);
        }
        
        public ListLogtanksResponse ListLogtanks(ListLogtanksRequest listLogtanksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listLogtanksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListLogtanksResponse>(response);
        }
        
        public ListMembersResponse ListMembers(ListMembersRequest listMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , listMembersRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMembersResponse>(response);
        }
        
        public ListPoolsResponse ListPools(ListPoolsRequest listPoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoolsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPoolsResponse>(response);
        }
        
        public ListQuotaDetailsResponse ListQuotaDetails(ListQuotaDetailsRequest listQuotaDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas/details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listQuotaDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListQuotaDetailsResponse>(response);
        }
        
        public ListSecurityPoliciesResponse ListSecurityPolicies(ListSecurityPoliciesRequest listSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityPoliciesResponse>(response);
        }
        
        public ListSystemSecurityPoliciesResponse ListSystemSecurityPolicies(ListSystemSecurityPoliciesRequest listSystemSecurityPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/system-security-policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSystemSecurityPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSystemSecurityPoliciesResponse>(response);
        }
        
        public ShowCertificateResponse ShowCertificate(ShowCertificateRequest showCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , showCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificateResponse>(response);
        }
        
        public ShowFlavorResponse ShowFlavor(ShowFlavorRequest showFlavorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("flavor_id" , showFlavorRequest.FlavorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/flavors/{flavor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showFlavorRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowFlavorResponse>(response);
        }
        
        public ShowHealthMonitorResponse ShowHealthMonitor(ShowHealthMonitorRequest showHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , showHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHealthMonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHealthMonitorResponse>(response);
        }
        
        public ShowL7PolicyResponse ShowL7Policy(ShowL7PolicyRequest showL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowL7PolicyResponse>(response);
        }
        
        public ShowL7RuleResponse ShowL7Rule(ShowL7RuleRequest showL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , showL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , showL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showL7RuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowL7RuleResponse>(response);
        }
        
        public ShowListenerResponse ShowListener(ShowListenerRequest showListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , showListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowListenerResponse>(response);
        }
        
        public ShowLoadBalancerResponse ShowLoadBalancer(ShowLoadBalancerRequest showLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerResponse>(response);
        }
        
        public ShowLoadBalancerStatusResponse ShowLoadBalancerStatus(ShowLoadBalancerStatusRequest showLoadBalancerStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , showLoadBalancerStatusRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}/statuses",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLoadBalancerStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLoadBalancerStatusResponse>(response);
        }
        
        public ShowLogtankResponse ShowLogtank(ShowLogtankRequest showLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , showLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogtankRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLogtankResponse>(response);
        }
        
        public ShowMemberResponse ShowMember(ShowMemberRequest showMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showMemberRequest.PoolId.ToString());
            urlParam.Add("member_id" , showMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberResponse>(response);
        }
        
        public ShowPoolResponse ShowPool(ShowPoolRequest showPoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , showPoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPoolResponse>(response);
        }
        
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public ShowSecurityPolicyResponse ShowSecurityPolicy(ShowSecurityPolicyRequest showSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , showSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityPolicyResponse>(response);
        }
        
        public UpdateCertificateResponse UpdateCertificate(UpdateCertificateRequest updateCertificateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("certificate_id" , updateCertificateRequest.CertificateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/certificates/{certificate_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateCertificateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCertificateResponse>(response);
        }
        
        public UpdateHealthMonitorResponse UpdateHealthMonitor(UpdateHealthMonitorRequest updateHealthMonitorRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("healthmonitor_id" , updateHealthMonitorRequest.HealthmonitorId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/healthmonitors/{healthmonitor_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateHealthMonitorRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHealthMonitorResponse>(response);
        }
        
        public UpdateL7PolicyResponse UpdateL7Policy(UpdateL7PolicyRequest updateL7PolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7PolicyRequest.L7policyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7PolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7PolicyResponse>(response);
        }
        
        public UpdateL7RuleResponse UpdateL7Rule(UpdateL7RuleRequest updateL7RuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("l7policy_id" , updateL7RuleRequest.L7policyId.ToString());
            urlParam.Add("l7rule_id" , updateL7RuleRequest.L7ruleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/l7policies/{l7policy_id}/rules/{l7rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateL7RuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateL7RuleResponse>(response);
        }
        
        public UpdateListenerResponse UpdateListener(UpdateListenerRequest updateListenerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("listener_id" , updateListenerRequest.ListenerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/listeners/{listener_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateListenerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateListenerResponse>(response);
        }
        
        public UpdateLoadBalancerResponse UpdateLoadBalancer(UpdateLoadBalancerRequest updateLoadBalancerRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("loadbalancer_id" , updateLoadBalancerRequest.LoadbalancerId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/loadbalancers/{loadbalancer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLoadBalancerRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLoadBalancerResponse>(response);
        }
        
        public UpdateLogtankResponse UpdateLogtank(UpdateLogtankRequest updateLogtankRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("logtank_id" , updateLogtankRequest.LogtankId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/logtanks/{logtank_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateLogtankRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateLogtankResponse>(response);
        }
        
        public UpdateMemberResponse UpdateMember(UpdateMemberRequest updateMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberRequest.MemberId.ToString());
            urlParam.Add("pool_id" , updateMemberRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberResponse>(response);
        }
        
        public UpdatePoolResponse UpdatePool(UpdatePoolRequest updatePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("pool_id" , updatePoolRequest.PoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/pools/{pool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePoolRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePoolResponse>(response);
        }
        
        public UpdateSecurityPolicyResponse UpdateSecurityPolicy(UpdateSecurityPolicyRequest updateSecurityPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_policy_id" , updateSecurityPolicyRequest.SecurityPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/security-policies/{security_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSecurityPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityPolicyResponse>(response);
        }
        
        public ListApiVersionsResponse ListApiVersions(ListApiVersionsRequest listApiVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/versions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApiVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApiVersionsResponse>(response);
        }
        
        public BatchDeleteIpListResponse BatchDeleteIpList(BatchDeleteIpListRequest batchDeleteIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , batchDeleteIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/batch-delete",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteIpListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchDeleteIpListResponse>(response);
        }
        
        public CountPreoccupyIpNumResponse CountPreoccupyIpNum(CountPreoccupyIpNumRequest countPreoccupyIpNumRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/preoccupy-ip-num",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", countPreoccupyIpNumRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CountPreoccupyIpNumResponse>(response);
        }
        
        public CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest createIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createIpGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateIpGroupResponse>(response);
        }
        
        public DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest deleteIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , deleteIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpGroupResponse>(response);
        }
        
        public ListIpGroupsResponse ListIpGroups(ListIpGroupsRequest listIpGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listIpGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListIpGroupsResponse>(response);
        }
        
        public ShowIpGroupResponse ShowIpGroup(ShowIpGroupRequest showIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , showIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowIpGroupResponse>(response);
        }
        
        public UpdateIpGroupResponse UpdateIpGroup(UpdateIpGroupRequest updateIpGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpGroupRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateIpGroupResponse>(response);
        }
        
        public UpdateIpListResponse UpdateIpList(UpdateIpListRequest updateIpListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("ipgroup_id" , updateIpListRequest.IpgroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/elb/ipgroups/{ipgroup_id}/iplist/create-or-update",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateIpListRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<UpdateIpListResponse>(response);
        }
        
    }
}