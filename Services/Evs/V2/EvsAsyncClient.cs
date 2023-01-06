using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Evs.V2.Model;

namespace G42Cloud.SDK.Evs.V2
{
    public partial class EvsAsyncClient : Client
    {
        public static ClientBuilder<EvsAsyncClient> NewBuilder()
        {
            return new ClientBuilder<EvsAsyncClient>();
        }

        
        public async Task<BatchCreateVolumeTagsResponse> BatchCreateVolumeTagsAsync(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchCreateVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }
        
        public async Task<BatchDeleteVolumeTagsResponse> BatchDeleteVolumeTagsAsync(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchDeleteVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }
        
        public async Task<CinderAcceptVolumeTransferResponse> CinderAcceptVolumeTransferAsync(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderAcceptVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>(response);
        }
        
        public async Task<CinderCreateVolumeTransferResponse> CinderCreateVolumeTransferAsync(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>(response);
        }
        
        public async Task<CinderDeleteVolumeTransferResponse> CinderDeleteVolumeTransferAsync(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderDeleteVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>(response);
        }
        
        public async Task<CinderListAvailabilityZonesResponse> CinderListAvailabilityZonesAsync(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }
        
        public async Task<CinderListQuotasResponse> CinderListQuotasAsync(CinderListQuotasRequest cinderListQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id" , cinderListQuotasRequest.TargetProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }
        
        public async Task<CinderListVolumeTransfersResponse> CinderListVolumeTransfersAsync(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>(response);
        }
        
        public async Task<CinderListVolumeTypesResponse> CinderListVolumeTypesAsync(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }
        
        public async Task<CinderShowVolumeTransferResponse> CinderShowVolumeTransferAsync(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderShowVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>(response);
        }
        
        public async Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }
        
        public async Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest createVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }
        
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , deleteSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }
        
        public async Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest deleteVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , deleteVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }
        
        public async Task<ListSnapshotsResponse> ListSnapshotsAsync(ListSnapshotsRequest listSnapshotsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsResponse>(response);
        }
        
        public async Task<ListVolumeTagsResponse> ListVolumeTagsAsync(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }
        
        public async Task<ListVolumesResponse> ListVolumesAsync(ListVolumesRequest listVolumesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesResponse>(response);
        }
        
        public async Task<ListVolumesByTagsResponse> ListVolumesByTagsAsync(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }
        
        public async Task<ResizeVolumeResponse> ResizeVolumeAsync(ResizeVolumeRequest resizeVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , resizeVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }
        
        public async Task<RollbackSnapshotResponse> RollbackSnapshotAsync(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , rollbackSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
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
        
        public async Task<ShowSnapshotResponse> ShowSnapshotAsync(ShowSnapshotRequest showSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , showSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }
        
        public async Task<ShowVolumeResponse> ShowVolumeAsync(ShowVolumeRequest showVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }
        
        public async Task<ShowVolumeTagsResponse> ShowVolumeTagsAsync(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }
        
        public async Task<UpdateSnapshotResponse> UpdateSnapshotAsync(UpdateSnapshotRequest updateSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , updateSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }
        
        public async Task<UpdateVolumeResponse> UpdateVolumeAsync(UpdateVolumeRequest updateVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , updateVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }
        
        public async Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerializeNull<ListVersionsResponse>(response);
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
        
    }
}