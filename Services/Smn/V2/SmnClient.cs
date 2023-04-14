using System;
using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Smn.V2.Model;

namespace G42Cloud.SDK.Smn.V2
{
    public partial class SmnClient : Client
    {
        public static ClientBuilder<SmnClient> NewBuilder()
        {
            return new ClientBuilder<SmnClient>();
        }

        
        public AddSubscriptionResponse AddSubscription(AddSubscriptionRequest addSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , addSubscriptionRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addSubscriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddSubscriptionResponse>(response);
        }
        
        public BatchCreateOrDeleteResourceTagsResponse BatchCreateOrDeleteResourceTags(BatchCreateOrDeleteResourceTagsRequest batchCreateOrDeleteResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , batchCreateOrDeleteResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , batchCreateOrDeleteResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateOrDeleteResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateOrDeleteResourceTagsResponse>(response);
        }
        
        public CancelSubscriptionResponse CancelSubscription(CancelSubscriptionRequest cancelSubscriptionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subscription_urn" , cancelSubscriptionRequest.SubscriptionUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions/{subscription_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cancelSubscriptionRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<CancelSubscriptionResponse>(response);
        }
        
        public CreateMessageTemplateResponse CreateMessageTemplate(CreateMessageTemplateRequest createMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateMessageTemplateResponse>(response);
        }
        
        public CreateResourceTagResponse CreateResourceTag(CreateResourceTagRequest createResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , createResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , createResourceTagRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateResourceTagResponse>(response);
        }
        
        public CreateTopicResponse CreateTopic(CreateTopicRequest createTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateTopicResponse>(response);
        }
        
        public DeleteMessageTemplateResponse DeleteMessageTemplate(DeleteMessageTemplateRequest deleteMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , deleteMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteMessageTemplateResponse>(response);
        }
        
        public DeleteResourceTagResponse DeleteResourceTag(DeleteResourceTagRequest deleteResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , deleteResourceTagRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , deleteResourceTagRequest.ResourceId.ToString());
            urlParam.Add("key" , deleteResourceTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteResourceTagResponse>(response);
        }
        
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest deleteTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicResponse>(response);
        }
        
        public DeleteTopicAttributeByNameResponse DeleteTopicAttributeByName(DeleteTopicAttributeByNameRequest deleteTopicAttributeByNameRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributeByNameRequest.TopicUrn.ToString());
            urlParam.Add("name" , deleteTopicAttributeByNameRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributeByNameRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributeByNameResponse>(response);
        }
        
        public DeleteTopicAttributesResponse DeleteTopicAttributes(DeleteTopicAttributesRequest deleteTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , deleteTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteTopicAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteTopicAttributesResponse>(response);
        }
        
        public ListMessageTemplateDetailsResponse ListMessageTemplateDetails(ListMessageTemplateDetailsRequest listMessageTemplateDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , listMessageTemplateDetailsRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplateDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplateDetailsResponse>(response);
        }
        
        public ListMessageTemplatesResponse ListMessageTemplates(ListMessageTemplatesRequest listMessageTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listMessageTemplatesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListMessageTemplatesResponse>(response);
        }
        
        public ListProjectTagsResponse ListProjectTags(ListProjectTagsRequest listProjectTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listProjectTagsRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProjectTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProjectTagsResponse>(response);
        }
        
        public ListResourceInstancesResponse ListResourceInstances(ListResourceInstancesRequest listResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceInstancesRequest.ResourceType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listResourceInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListResourceInstancesResponse>(response);
        }
        
        public ListResourceTagsResponse ListResourceTags(ListResourceTagsRequest listResourceTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("resource_type" , listResourceTagsRequest.ResourceType.ToString());
            urlParam.Add("resource_id" , listResourceTagsRequest.ResourceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/{resource_type}/{resource_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listResourceTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListResourceTagsResponse>(response);
        }
        
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest listSubscriptionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsResponse>(response);
        }
        
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest listSubscriptionsByTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listSubscriptionsByTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/subscriptions",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubscriptionsByTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubscriptionsByTopicResponse>(response);
        }
        
        public ListTopicAttributesResponse ListTopicAttributes(ListTopicAttributesRequest listTopicAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicAttributesRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicAttributesResponse>(response);
        }
        
        public ListTopicDetailsResponse ListTopicDetails(ListTopicDetailsRequest listTopicDetailsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , listTopicDetailsRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicDetailsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicDetailsResponse>(response);
        }
        
        public ListTopicsResponse ListTopics(ListTopicsRequest listTopicsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTopicsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTopicsResponse>(response);
        }
        
        public ListVersionResponse ListVersion(ListVersionRequest listVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("api_version" , listVersionRequest.ApiVersion.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{api_version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionResponse>(response);
        }
        
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        public PublishMessageResponse PublishMessage(PublishMessageRequest publishMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , publishMessageRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishMessageResponse>(response);
        }
        
        public UpdateMessageTemplateResponse UpdateMessageTemplate(UpdateMessageTemplateRequest updateMessageTemplateRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("message_template_id" , updateMessageTemplateRequest.MessageTemplateId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/message_template/{message_template_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMessageTemplateRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMessageTemplateResponse>(response);
        }
        
        public UpdateTopicResponse UpdateTopic(UpdateTopicRequest updateTopicRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicRequest.TopicUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicResponse>(response);
        }
        
        public UpdateTopicAttributeResponse UpdateTopicAttribute(UpdateTopicAttributeRequest updateTopicAttributeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("topic_urn" , updateTopicAttributeRequest.TopicUrn.ToString());
            urlParam.Add("name" , updateTopicAttributeRequest.Name.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/topics/{topic_urn}/attributes/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateTopicAttributeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateTopicAttributeResponse>(response);
        }
        
        public CreateApplicationResponse CreateApplication(CreateApplicationRequest createApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationResponse>(response);
        }
        
        public DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest deleteApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , deleteApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationResponse>(response);
        }
        
        public ListApplicationAttributesResponse ListApplicationAttributes(ListApplicationAttributesRequest listApplicationAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationAttributesRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationAttributesResponse>(response);
        }
        
        public ListApplicationsResponse ListApplications(ListApplicationsRequest listApplicationsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationsResponse>(response);
        }
        
        public PublishAppMessageResponse PublishAppMessage(PublishAppMessageRequest publishAppMessageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , publishAppMessageRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}/publish",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", publishAppMessageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<PublishAppMessageResponse>(response);
        }
        
        public UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest updateApplicationRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , updateApplicationRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationResponse>(response);
        }
        
        public CreateApplicationEndpointResponse CreateApplicationEndpoint(CreateApplicationEndpointRequest createApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , createApplicationEndpointRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateApplicationEndpointResponse>(response);
        }
        
        public DeleteApplicationEndpointResponse DeleteApplicationEndpoint(DeleteApplicationEndpointRequest deleteApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , deleteApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteApplicationEndpointResponse>(response);
        }
        
        public ListApplicationEndpointAttributesResponse ListApplicationEndpointAttributes(ListApplicationEndpointAttributesRequest listApplicationEndpointAttributesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , listApplicationEndpointAttributesRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointAttributesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointAttributesResponse>(response);
        }
        
        public ListApplicationEndpointsResponse ListApplicationEndpoints(ListApplicationEndpointsRequest listApplicationEndpointsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("application_urn" , listApplicationEndpointsRequest.ApplicationUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/applications/{application_urn}/endpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listApplicationEndpointsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListApplicationEndpointsResponse>(response);
        }
        
        public UpdateApplicationEndpointResponse UpdateApplicationEndpoint(UpdateApplicationEndpointRequest updateApplicationEndpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("endpoint_urn" , updateApplicationEndpointRequest.EndpointUrn.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/notifications/endpoints/{endpoint_urn}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateApplicationEndpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateApplicationEndpointResponse>(response);
        }
        
    }
}