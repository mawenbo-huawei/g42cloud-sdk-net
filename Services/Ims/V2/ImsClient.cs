using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Ims.V2.Model;

namespace G42Cloud.SDK.Ims.V2
{
    public partial class ImsClient : Client
    {
        public static ClientBuilder<ImsClient> NewBuilder()
        {
            return new ClientBuilder<ImsClient>();
        }

        
        public AddImageTagResponse AddImageTag(AddImageTagRequest addImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , addImageTagRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addImageTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<AddImageTagResponse>(response);
        }
        
        public BatchAddMembersResponse BatchAddMembers(BatchAddMembersRequest batchAddMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<BatchAddMembersResponse>(response);
        }
        
        public BatchAddOrDeleteTagsResponse BatchAddOrDeleteTags(BatchAddOrDeleteTagsRequest batchAddOrDeleteTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , batchAddOrDeleteTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchAddOrDeleteTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchAddOrDeleteTagsResponse>(response);
        }
        
        public BatchDeleteMembersResponse BatchDeleteMembers(BatchDeleteMembersRequest batchDeleteMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<BatchDeleteMembersResponse>(response);
        }
        
        public BatchUpdateMembersResponse BatchUpdateMembers(BatchUpdateMembersRequest batchUpdateMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchUpdateMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<BatchUpdateMembersResponse>(response);
        }
        
        public CopyImageCrossRegionResponse CopyImageCrossRegion(CopyImageCrossRegionRequest copyImageCrossRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageCrossRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/cross_region_copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageCrossRegionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyImageCrossRegionResponse>(response);
        }
        
        public CopyImageInRegionResponse CopyImageInRegion(CopyImageInRegionRequest copyImageInRegionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , copyImageInRegionRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/copy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyImageInRegionRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyImageInRegionResponse>(response);
        }
        
        public CreateDataImageResponse CreateDataImage(CreateDataImageRequest createDataImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/dataimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createDataImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateDataImageResponse>(response);
        }
        
        public CreateImageResponse CreateImage(CreateImageRequest createImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateImageResponse>(response);
        }
        
        public CreateOrUpdateTagsResponse CreateOrUpdateTags(CreateOrUpdateTagsRequest createOrUpdateTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createOrUpdateTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<CreateOrUpdateTagsResponse>(response);
        }
        
        public CreateWholeImageResponse CreateWholeImage(CreateWholeImageRequest createWholeImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/wholeimages/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createWholeImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateWholeImageResponse>(response);
        }
        
        public DeleteImageTagResponse DeleteImageTag(DeleteImageTagRequest deleteImageTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , deleteImageTagRequest.ImageId.ToString());
            urlParam.Add("key" , deleteImageTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteImageTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteImageTagResponse>(response);
        }
        
        public ExportImageResponse ExportImage(ExportImageRequest exportImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , exportImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/file",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", exportImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ExportImageResponse>(response);
        }
        
        public ImportImageQuickResponse ImportImageQuick(ImportImageQuickRequest importImageQuickRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/quickimport/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importImageQuickRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportImageQuickResponse>(response);
        }
        
        public ListImageByTagsResponse ListImageByTags(ListImageByTagsRequest listImageByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listImageByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListImageByTagsResponse>(response);
        }
        
        public ListImageTagsResponse ListImageTags(ListImageTagsRequest listImageTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , listImageTagsRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/{image_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImageTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImageTagsResponse>(response);
        }
        
        public ListImagesResponse ListImages(ListImagesRequest listImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImagesResponse>(response);
        }
        
        public ListImagesTagsResponse ListImagesTags(ListImagesTagsRequest listImagesTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/images/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listImagesTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListImagesTagsResponse>(response);
        }
        
        public ListOsVersionsResponse ListOsVersions(ListOsVersionsRequest listOsVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/os_version",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOsVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            ListOsVersionsResponse listOsVersionsResponse = JsonUtils.DeSerializeNull<ListOsVersionsResponse>(response);
            listOsVersionsResponse.Body = JsonUtils.DeSerializeList<ListOsVersionsResponseBody>(response);
            return listOsVersionsResponse;
        }
        
        public ListTagsResponse ListTags(ListTagsRequest listTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListTagsResponse>(response);
        }
        
        public RegisterImageResponse RegisterImage(RegisterImageRequest registerImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , registerImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/{image_id}/upload",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", registerImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RegisterImageResponse>(response);
        }
        
        public ShowImageQuotaResponse ShowImageQuota(ShowImageQuotaRequest showImageQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/quota",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showImageQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowImageQuotaResponse>(response);
        }
        
        public ShowJobResponse ShowJob(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        public ShowJobProgressResponse ShowJobProgress(ShowJobProgressRequest showJobProgressRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobProgressRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/cloudimages/job/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobProgressRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowJobProgressResponse>(response);
        }
        
        public UpdateImageResponse UpdateImage(UpdateImageRequest updateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , updateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/cloudimages/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<UpdateImageResponse>(response);
        }
        
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVersionsResponse>(response);
        }
        
        public ShowVersionResponse ShowVersion(ShowVersionRequest showVersionRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("version" , showVersionRequest.Version.ToString());
            string urlPath = HttpUtils.AddUrlPath("/{version}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVersionRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVersionResponse>(response);
        }
        
        public GlanceAddImageMemberResponse GlanceAddImageMember(GlanceAddImageMemberRequest glanceAddImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceAddImageMemberRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceAddImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<GlanceAddImageMemberResponse>(response);
        }
        
        public GlanceCreateImageMetadataResponse GlanceCreateImageMetadata(GlanceCreateImageMetadataRequest glanceCreateImageMetadataRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceCreateImageMetadataRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<GlanceCreateImageMetadataResponse>(response);
        }
        
        public GlanceCreateTagResponse GlanceCreateTag(GlanceCreateTagRequest glanceCreateTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceCreateTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceCreateTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceCreateTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerializeNull<GlanceCreateTagResponse>(response);
        }
        
        public GlanceDeleteImageResponse GlanceDeleteImage(GlanceDeleteImageRequest glanceDeleteImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceDeleteImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageResponse>(response);
        }
        
        public GlanceDeleteImageMemberResponse GlanceDeleteImageMember(GlanceDeleteImageMemberRequest glanceDeleteImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceDeleteImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteImageMemberResponse>(response);
        }
        
        public GlanceDeleteTagResponse GlanceDeleteTag(GlanceDeleteTagRequest glanceDeleteTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceDeleteTagRequest.ImageId.ToString());
            urlParam.Add("tag" , glanceDeleteTagRequest.Tag.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/tags/{tag}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceDeleteTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<GlanceDeleteTagResponse>(response);
        }
        
        public GlanceListImageMemberSchemasResponse GlanceListImageMemberSchemas(GlanceListImageMemberSchemasRequest glanceListImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMemberSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMemberSchemasResponse>(response);
        }
        
        public GlanceListImageMembersResponse GlanceListImageMembers(GlanceListImageMembersRequest glanceListImageMembersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceListImageMembersRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageMembersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageMembersResponse>(response);
        }
        
        public GlanceListImageSchemasResponse GlanceListImageSchemas(GlanceListImageSchemasRequest glanceListImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImageSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImageSchemasResponse>(response);
        }
        
        public GlanceListImagesResponse GlanceListImages(GlanceListImagesRequest glanceListImagesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/images",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceListImagesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceListImagesResponse>(response);
        }
        
        public GlanceShowImageResponse GlanceShowImage(GlanceShowImageRequest glanceShowImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageResponse>(response);
        }
        
        public GlanceShowImageMemberResponse GlanceShowImageMember(GlanceShowImageMemberRequest glanceShowImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceShowImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceShowImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberResponse>(response);
        }
        
        public GlanceShowImageMemberSchemasResponse GlanceShowImageMemberSchemas(GlanceShowImageMemberSchemasRequest glanceShowImageMemberSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/member",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageMemberSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageMemberSchemasResponse>(response);
        }
        
        public GlanceShowImageSchemasResponse GlanceShowImageSchemas(GlanceShowImageSchemasRequest glanceShowImageSchemasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/schemas/image",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", glanceShowImageSchemasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<GlanceShowImageSchemasResponse>(response);
        }
        
        public GlanceUpdateImageResponse GlanceUpdateImage(GlanceUpdateImageRequest glanceUpdateImageRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageRequest.ImageId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/openstack-images-v2.1-json-patch", glanceUpdateImageRequest);
            HttpResponseMessage response = DoHttpRequestSync("PATCH",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageResponse>(response);
        }
        
        public GlanceUpdateImageMemberResponse GlanceUpdateImageMember(GlanceUpdateImageMemberRequest glanceUpdateImageMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("image_id" , glanceUpdateImageMemberRequest.ImageId.ToString());
            urlParam.Add("member_id" , glanceUpdateImageMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/images/{image_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", glanceUpdateImageMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<GlanceUpdateImageMemberResponse>(response);
        }
        
    }
}