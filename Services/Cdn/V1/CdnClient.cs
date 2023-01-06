using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Cdn.V1.Model;

namespace G42Cloud.SDK.Cdn.V1
{
    public partial class CdnClient : Client
    {
        public static ClientBuilder<CdnClient> NewBuilder()
        {
            return new ClientBuilder<CdnClient>("GlobalCredentials");
        }

        
        public CreateDomainResponse CreateDomain(CreateDomainRequest createDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDomainResponse>(response);
        }
        
        public CreatePreheatingTasksResponse CreatePreheatingTasks(CreatePreheatingTasksRequest createPreheatingTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/preheating-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createPreheatingTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePreheatingTasksResponse>(response);
        }
        
        public CreateRefreshTasksResponse CreateRefreshTasks(CreateRefreshTasksRequest createRefreshTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/content/refresh-tasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createRefreshTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRefreshTasksResponse>(response);
        }
        
        public DeleteDomainResponse DeleteDomain(DeleteDomainRequest deleteDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , deleteDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteDomainResponse>(response);
        }
        
        public DisableDomainResponse DisableDomain(DisableDomainRequest disableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , disableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/disable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", disableDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<DisableDomainResponse>(response);
        }
        
        public EnableDomainResponse EnableDomain(EnableDomainRequest enableDomainRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , enableDomainRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/enable",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", enableDomainRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<EnableDomainResponse>(response);
        }
        
        public ListDomainsResponse ListDomains(ListDomainsRequest listDomainsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listDomainsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListDomainsResponse>(response);
        }
        
        public ShowBlackWhiteListResponse ShowBlackWhiteList(ShowBlackWhiteListRequest showBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBlackWhiteListResponse>(response);
        }
        
        public ShowCacheRulesResponse ShowCacheRules(ShowCacheRulesRequest showCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCacheRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCacheRulesResponse>(response);
        }
        
        public ShowCertificatesHttpsInfoResponse ShowCertificatesHttpsInfo(ShowCertificatesHttpsInfoRequest showCertificatesHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/https-certificate-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCertificatesHttpsInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCertificatesHttpsInfoResponse>(response);
        }
        
        public ShowDomainDetailResponse ShowDomainDetail(ShowDomainDetailRequest showDomainDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showDomainDetailRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainDetailResponse>(response);
        }
        
        public ShowDomainFullConfigResponse ShowDomainFullConfig(ShowDomainFullConfigRequest showDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , showDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainFullConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainFullConfigResponse>(response);
        }
        
        public ShowDomainItemDetailsResponse ShowDomainItemDetails(ShowDomainItemDetailsRequest showDomainItemDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemDetailsResponse>(response);
        }
        
        public ShowDomainItemLocationDetailsResponse ShowDomainItemLocationDetails(ShowDomainItemLocationDetailsRequest showDomainItemLocationDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-item-location-details",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainItemLocationDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainItemLocationDetailsResponse>(response);
        }
        
        public ShowDomainLocationStatsResponse ShowDomainLocationStats(ShowDomainLocationStatsRequest showDomainLocationStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-location-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainLocationStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainLocationStatsResponse>(response);
        }
        
        public ShowDomainStatsResponse ShowDomainStats(ShowDomainStatsRequest showDomainStatsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/domain-stats",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showDomainStatsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowDomainStatsResponse>(response);
        }
        
        public ShowHistoryTaskDetailsResponse ShowHistoryTaskDetails(ShowHistoryTaskDetailsRequest showHistoryTaskDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("history_tasks_id" , showHistoryTaskDetailsRequest.HistoryTasksId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks/{history_tasks_id}/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTaskDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTaskDetailsResponse>(response);
        }
        
        public ShowHistoryTasksResponse ShowHistoryTasks(ShowHistoryTasksRequest showHistoryTasksRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/historytasks",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHistoryTasksRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHistoryTasksResponse>(response);
        }
        
        public ShowHttpInfoResponse ShowHttpInfo(ShowHttpInfoRequest showHttpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showHttpInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showHttpInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowHttpInfoResponse>(response);
        }
        
        public ShowIpInfoResponse ShowIpInfo(ShowIpInfoRequest showIpInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/ip-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showIpInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowIpInfoResponse>(response);
        }
        
        public ShowLogsResponse ShowLogs(ShowLogsRequest showLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowLogsResponse>(response);
        }
        
        public ShowOriginHostResponse ShowOriginHost(ShowOriginHostRequest showOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOriginHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowOriginHostResponse>(response);
        }
        
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public ShowReferResponse ShowRefer(ShowReferRequest showReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReferRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowReferResponse>(response);
        }
        
        public ShowResponseHeaderResponse ShowResponseHeader(ShowResponseHeaderRequest showResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , showResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showResponseHeaderRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowResponseHeaderResponse>(response);
        }
        
        public ShowTopUrlResponse ShowTopUrl(ShowTopUrlRequest showTopUrlRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/statistics/top-url",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showTopUrlRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowTopUrlResponse>(response);
        }
        
        public UpdateBlackWhiteListResponse UpdateBlackWhiteList(UpdateBlackWhiteListRequest updateBlackWhiteListRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateBlackWhiteListRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/ip-acl",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateBlackWhiteListRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateBlackWhiteListResponse>(response);
        }
        
        public UpdateCacheRulesResponse UpdateCacheRules(UpdateCacheRulesRequest updateCacheRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateCacheRulesRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/cache",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateCacheRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateCacheRulesResponse>(response);
        }
        
        public UpdateDomainFullConfigResponse UpdateDomainFullConfig(UpdateDomainFullConfigRequest updateDomainFullConfigRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_name" , updateDomainFullConfigRequest.DomainName.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.1/cdn/configuration/domains/{domain_name}/configs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainFullConfigRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<UpdateDomainFullConfigResponse>(response);
        }
        
        public UpdateDomainMultiCertificatesResponse UpdateDomainMultiCertificates(UpdateDomainMultiCertificatesRequest updateDomainMultiCertificatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/config-https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainMultiCertificatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainMultiCertificatesResponse>(response);
        }
        
        public UpdateDomainOriginResponse UpdateDomainOrigin(UpdateDomainOriginRequest updateDomainOriginRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateDomainOriginRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/origin",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateDomainOriginRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateDomainOriginResponse>(response);
        }
        
        public UpdateFollow302SwitchResponse UpdateFollow302Switch(UpdateFollow302SwitchRequest updateFollow302SwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateFollow302SwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/follow302-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateFollow302SwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateFollow302SwitchResponse>(response);
        }
        
        public UpdateHttpsInfoResponse UpdateHttpsInfo(UpdateHttpsInfoRequest updateHttpsInfoRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateHttpsInfoRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/https-info",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateHttpsInfoRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateHttpsInfoResponse>(response);
        }
        
        public UpdateOriginHostResponse UpdateOriginHost(UpdateOriginHostRequest updateOriginHostRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateOriginHostRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/originhost",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateOriginHostRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateOriginHostResponse>(response);
        }
        
        public UpdatePrivateBucketAccessResponse UpdatePrivateBucketAccess(UpdatePrivateBucketAccessRequest updatePrivateBucketAccessRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updatePrivateBucketAccessRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/private-bucket-access",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updatePrivateBucketAccessRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePrivateBucketAccessResponse>(response);
        }
        
        public UpdateRangeSwitchResponse UpdateRangeSwitch(UpdateRangeSwitchRequest updateRangeSwitchRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateRangeSwitchRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/range-switch",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateRangeSwitchRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRangeSwitchResponse>(response);
        }
        
        public UpdateReferResponse UpdateRefer(UpdateReferRequest updateReferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateReferRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/referer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateReferRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateReferResponse>(response);
        }
        
        public UpdateResponseHeaderResponse UpdateResponseHeader(UpdateResponseHeaderRequest updateResponseHeaderRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("domain_id" , updateResponseHeaderRequest.DomainId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1.0/cdn/domains/{domain_id}/response-header",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateResponseHeaderRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateResponseHeaderResponse>(response);
        }
        
    }
}