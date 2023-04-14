using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Smn.V2.Model;

namespace G42Cloud.SDK.Smn.V2
{
    public partial class SmnAsyncClient : Client
    {
        public static ClientBuilder<SmnAsyncClient> NewBuilder()
        {
            return new ClientBuilder<SmnAsyncClient>();
        }

        
        public async Task<AddSubscriptionResponse> AddSubscriptionAsync(AddSubscriptionRequest addSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , addSubscriptionRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
        }
        
        public async Task<BatchCreateOrDeleteResourceTagsResponse> BatchCreateOrDeleteResourceTagsAsync(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
        }
        
        public async Task<CancelSubscriptionResponse> CancelSubscriptionAsync(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn" , cancelSubscriptionRequest.SubscriptionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
        }
        
        public async Task<CreateMessageTemplateResponse> CreateMessageTemplateAsync(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
        }
        
        public async Task<CreateResourceTagResponse> CreateResourceTagAsync(CreateResourceTagRequest createResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
        }
        
        public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest createTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
        }
        
        public async Task<DeleteMessageTemplateResponse> DeleteMessageTemplateAsync(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , deleteMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
        }
        
        public async Task<DeleteResourceTagResponse> DeleteResourceTagAsync(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteResourceTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
        }
        
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest deleteTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
        }
        
        public async Task<DeleteTopicAttributeByNameResponse> DeleteTopicAttributeByNameAsync(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name" , deleteTopicAttributeByNameRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
        }
        
        public async Task<DeleteTopicAttributesResponse> DeleteTopicAttributesAsync(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
        }
        
        public async Task<ListMessageTemplateDetailsResponse> ListMessageTemplateDetailsAsync(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
        }
        
        public async Task<ListMessageTemplatesResponse> ListMessageTemplatesAsync(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
        }
        
        public async Task<ListProjectTagsResponse> ListProjectTagsAsync(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        public async Task<ListResourceInstancesResponse> ListResourceInstancesAsync(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        public async Task<ListResourceTagsResponse> ListResourceTagsAsync(ListResourceTagsRequest listResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }
        
        public async Task<ListSubscriptionsResponse> ListSubscriptionsAsync(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }
        
        public async Task<ListSubscriptionsByTopicResponse> ListSubscriptionsByTopicAsync(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listSubscriptionsByTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
        }
        
        public async Task<ListTopicAttributesResponse> ListTopicAttributesAsync(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
        }
        
        public async Task<ListTopicDetailsResponse> ListTopicDetailsAsync(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicDetailsRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
        }
        
        public async Task<ListTopicsResponse> ListTopicsAsync(ListTopicsRequest listTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
        }
        
        public async Task<ListVersionResponse> ListVersionAsync(ListVersionRequest listVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , listVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
        }
        
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        public async Task<PublishMessageResponse> PublishMessageAsync(PublishMessageRequest publishMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , publishMessageRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
        }
        
        public async Task<UpdateMessageTemplateResponse> UpdateMessageTemplateAsync(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , updateMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
        }
        
        public async Task<UpdateTopicResponse> UpdateTopicAsync(UpdateTopicRequest updateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
        }
        
        public async Task<UpdateTopicAttributeResponse> UpdateTopicAttributeAsync(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name" , updateTopicAttributeRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }
        
        public async Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest createApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }
        
        public async Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , deleteApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }
        
        public async Task<ListApplicationAttributesResponse> ListApplicationAttributesAsync(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationAttributesRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }
        
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest listApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }
        
        public async Task<PublishAppMessageResponse> PublishAppMessageAsync(PublishAppMessageRequest publishAppMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , publishAppMessageRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }
        
        public async Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest updateApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , updateApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }
        
        public async Task<CreateApplicationEndpointResponse> CreateApplicationEndpointAsync(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , createApplicationEndpointRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }
        
        public async Task<DeleteApplicationEndpointResponse> DeleteApplicationEndpointAsync(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , deleteApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }
        
        public async Task<ListApplicationEndpointAttributesResponse> ListApplicationEndpointAttributesAsync(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }
        
        public async Task<ListApplicationEndpointsResponse> ListApplicationEndpointsAsync(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationEndpointsRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }
        
        public async Task<UpdateApplicationEndpointResponse> UpdateApplicationEndpointAsync(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , updateApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }
        
    }
}