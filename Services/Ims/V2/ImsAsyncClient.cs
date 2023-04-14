using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Ims.V2.Model;

namespace G42Cloud.SDK.Ims.V2
{
    public partial class ImsAsyncClient : Client
    {
        public static ClientBuilder<ImsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<ImsAsyncClient>();
        }

        
        public async Task<AddImageTagResponse> AddImageTagAsync(AddImageTagRequest addImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , addImageTagRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addImageTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AddImageTagResponse>(response);
        }
        
        public async Task<BatchAddMembersResponse> BatchAddMembersAsync(BatchAddMembersRequest batchAddMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchAddMembersResponse>(response);
        }
        
        public async Task<BatchAddOrDeleteTagsResponse> BatchAddOrDeleteTagsAsync(BatchAddOrDeleteTagsRequest batchAddOrDeleteTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , batchAddOrDeleteTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrDeleteTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddOrDeleteTagsResponse>(response);
        }
        
        public async Task<BatchDeleteMembersResponse> BatchDeleteMembersAsync(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        public async Task<BatchUpdateMembersResponse> BatchUpdateMembersAsync(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }
        
        public async Task<CopyImageCrossRegionResponse> CopyImageCrossRegionAsync(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageCrossRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyImageCrossRegionResponse>(response);
        }
        
        public async Task<CopyImageInRegionResponse> CopyImageInRegionAsync(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageInRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CopyImageInRegionResponse>(response);
        }
        
        public async Task<CreateDataImageResponse> CreateDataImageAsync(CreateDataImageRequest createDataImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateDataImageResponse>(response);
        }
        
        public async Task<CreateImageResponse> CreateImageAsync(CreateImageRequest createImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }
        
        public async Task<CreateOrUpdateTagsResponse> CreateOrUpdateTagsAsync(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>(response);
        }
        
        public async Task<CreateWholeImageResponse> CreateWholeImageAsync(CreateWholeImageRequest createWholeImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateWholeImageResponse>(response);
        }
        
        public async Task<DeleteImageTagResponse> DeleteImageTagAsync(DeleteImageTagRequest deleteImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , deleteImageTagRequest.ImageId.ToString());
            urlParam.Add("key" , deleteImageTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteImageTagResponse>(response);
        }
        
        public async Task<ExportImageResponse> ExportImageAsync(ExportImageRequest exportImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , exportImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ExportImageResponse>(response);
        }
        
        public async Task<ImportImageQuickResponse> ImportImageQuickAsync(ImportImageQuickRequest importImageQuickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ImportImageQuickResponse>(response);
        }
        
        public async Task<ListImageByTagsResponse> ListImageByTagsAsync(ListImageByTagsRequest listImageByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listImageByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListImageByTagsResponse>(response);
        }
        
        public async Task<ListImageTagsResponse> ListImageTagsAsync(ListImageTagsRequest listImageTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , listImageTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListImageTagsResponse>(response);
        }
        
        public async Task<ListImagesResponse> ListImagesAsync(ListImagesRequest listImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }
        
        public async Task<ListImagesTagsResponse> ListImagesTagsAsync(ListImagesTagsRequest listImagesTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListImagesTagsResponse>(response);
        }
        
        public async Task<ListOsVersionsResponse> ListOsVersionsAsync(ListOsVersionsRequest listOsVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOsVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            ListOsVersionsResponse listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
            listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
            return listOsVersionsResponse;
        }
        
        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        public async Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest registerImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , registerImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }
        
        public async Task<ShowImageQuotaResponse> ShowImageQuotaAsync(ShowImageQuotaRequest showImageQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageQuotaRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowImageQuotaResponse>(response);
        }
        
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        public async Task<ShowJobProgressResponse> ShowJobProgressAsync(ShowJobProgressRequest showJobProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/job/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobProgressRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobProgressResponse>(response);
        }
        
        public async Task<UpdateImageResponse> UpdateImageAsync(UpdateImageRequest updateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , updateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateImageResponse>(response);
        }
        
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        public async Task<ShowVersionResponse> ShowVersionAsync(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        public async Task<GlanceAddImageMemberResponse> GlanceAddImageMemberAsync(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceAddImageMemberRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<GlanceAddImageMemberResponse>(response);
        }
        
        public async Task<GlanceCreateImageMetadataResponse> GlanceCreateImageMetadataAsync(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>(response);
        }
        
        public async Task<GlanceCreateTagResponse> GlanceCreateTagAsync(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceCreateTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceCreateTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerializeNull<GlanceCreateTagResponse>(response);
        }
        
        public async Task<GlanceDeleteImageResponse> GlanceDeleteImageAsync(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>(response);
        }
        
        public async Task<GlanceDeleteImageMemberResponse> GlanceDeleteImageMemberAsync(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceDeleteImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteImageMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>(response);
        }
        
        public async Task<GlanceDeleteTagResponse> GlanceDeleteTagAsync(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceDeleteTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteTagRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>(response);
        }
        
        public async Task<GlanceListImageMemberSchemasResponse> GlanceListImageMemberSchemasAsync(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMemberSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>(response);
        }
        
        public async Task<GlanceListImageMembersResponse> GlanceListImageMembersAsync(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceListImageMembersRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMembersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMembersResponse>(response);
        }
        
        public async Task<GlanceListImageSchemasResponse> GlanceListImageSchemasAsync(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageSchemasResponse>(response);
        }
        
        public async Task<GlanceListImagesResponse> GlanceListImagesAsync(GlanceListImagesRequest glanceListImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImagesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImagesResponse>(response);
        }
        
        public async Task<GlanceShowImageResponse> GlanceShowImageAsync(GlanceShowImageRequest glanceShowImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageResponse>(response);
        }
        
        public async Task<GlanceShowImageMemberResponse> GlanceShowImageMemberAsync(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceShowImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberResponse>(response);
        }
        
        public async Task<GlanceShowImageMemberSchemasResponse> GlanceShowImageMemberSchemasAsync(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/member",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>(response);
        }
        
        public async Task<GlanceShowImageSchemasResponse> GlanceShowImageSchemasAsync(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageSchemasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>(response);
        }
        
        public async Task<GlanceUpdateImageResponse> GlanceUpdateImageAsync(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/openstack-images-v2.1-json-patch", glanceUpdateImageRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PATCH",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageResponse>(response);
        }
        
        public async Task<GlanceUpdateImageMemberResponse> GlanceUpdateImageMemberAsync(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceUpdateImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>(response);
        }
        
    }
}