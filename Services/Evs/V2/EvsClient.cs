using System.Net.Http;
using System.Collections.Generic;
using HuaweiCloud.SDK.Core;
using G42Cloud.SDK.Evs.V2.Model;

namespace G42Cloud.SDK.Evs.V2
{
    public partial class EvsClient : Client
    {
        public static ClientBuilder<EvsClient> NewBuilder()
        {
            return new ClientBuilder<EvsClient>();
        }

        
        public BatchCreateVolumeTagsResponse BatchCreateVolumeTags(BatchCreateVolumeTagsRequest batchCreateVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchCreateVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVolumeTagsResponse>(response);
        }
        
        public BatchDeleteVolumeTagsResponse BatchDeleteVolumeTags(BatchDeleteVolumeTagsRequest batchDeleteVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , batchDeleteVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVolumeTagsResponse>(response);
        }
        
        public CinderAcceptVolumeTransferResponse CinderAcceptVolumeTransfer(CinderAcceptVolumeTransferRequest cinderAcceptVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderAcceptVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderAcceptVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CinderAcceptVolumeTransferResponse>(response);
        }
        
        public CinderCreateVolumeTransferResponse CinderCreateVolumeTransfer(CinderCreateVolumeTransferRequest cinderCreateVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", cinderCreateVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CinderCreateVolumeTransferResponse>(response);
        }
        
        public CinderDeleteVolumeTransferResponse CinderDeleteVolumeTransfer(CinderDeleteVolumeTransferRequest cinderDeleteVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderDeleteVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderDeleteVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<CinderDeleteVolumeTransferResponse>(response);
        }
        
        public CinderListAvailabilityZonesResponse CinderListAvailabilityZones(CinderListAvailabilityZonesRequest cinderListAvailabilityZonesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-availability-zone",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListAvailabilityZonesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListAvailabilityZonesResponse>(response);
        }
        
        public CinderListQuotasResponse CinderListQuotas(CinderListQuotasRequest cinderListQuotasRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("target_project_id" , cinderListQuotasRequest.TargetProjectId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-quota-sets/{target_project_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListQuotasRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListQuotasResponse>(response);
        }
        
        public CinderListVolumeTransfersResponse CinderListVolumeTransfers(CinderListVolumeTransfersRequest cinderListVolumeTransfersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTransfersRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTransfersResponse>(response);
        }
        
        public CinderListVolumeTypesResponse CinderListVolumeTypes(CinderListVolumeTypesRequest cinderListVolumeTypesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/types",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderListVolumeTypesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderListVolumeTypesResponse>(response);
        }
        
        public CinderShowVolumeTransferResponse CinderShowVolumeTransfer(CinderShowVolumeTransferRequest cinderShowVolumeTransferRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("transfer_id" , cinderShowVolumeTransferRequest.TransferId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/os-volume-transfer/{transfer_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", cinderShowVolumeTransferRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<CinderShowVolumeTransferResponse>(response);
        }
        
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSnapshotResponse>(response);
        }
        
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest createVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVolumeResponse>(response);
        }
        
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , deleteSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSnapshotResponse>(response);
        }
        
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , deleteVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteVolumeResponse>(response);
        }
        
        public ListSnapshotsResponse ListSnapshots(ListSnapshotsRequest listSnapshotsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSnapshotsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSnapshotsResponse>(response);
        }
        
        public ListVolumeTagsResponse ListVolumeTags(ListVolumeTagsRequest listVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumeTagsResponse>(response);
        }
        
        public ListVolumesResponse ListVolumes(ListVolumesRequest listVolumesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/detail",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVolumesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVolumesResponse>(response);
        }
        
        public ListVolumesByTagsResponse ListVolumesByTags(ListVolumesByTagsRequest listVolumesByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVolumesByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListVolumesByTagsResponse>(response);
        }
        
        public ResizeVolumeResponse ResizeVolume(ResizeVolumeRequest resizeVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , resizeVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.1/{project_id}/cloudvolumes/{volume_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", resizeVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ResizeVolumeResponse>(response);
        }
        
        public RollbackSnapshotResponse RollbackSnapshot(RollbackSnapshotRequest rollbackSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , rollbackSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}/rollback",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", rollbackSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RollbackSnapshotResponse>(response);
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
        
        public ShowSnapshotResponse ShowSnapshot(ShowSnapshotRequest showSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , showSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSnapshotResponse>(response);
        }
        
        public ShowVolumeResponse ShowVolume(ShowVolumeRequest showVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeResponse>(response);
        }
        
        public ShowVolumeTagsResponse ShowVolumeTags(ShowVolumeTagsRequest showVolumeTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , showVolumeTagsRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVolumeTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVolumeTagsResponse>(response);
        }
        
        public UpdateSnapshotResponse UpdateSnapshot(UpdateSnapshotRequest updateSnapshotRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("snapshot_id" , updateSnapshotRequest.SnapshotId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudsnapshots/{snapshot_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSnapshotRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSnapshotResponse>(response);
        }
        
        public UpdateVolumeResponse UpdateVolume(UpdateVolumeRequest updateVolumeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("volume_id" , updateVolumeRequest.VolumeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2/{project_id}/cloudvolumes/{volume_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVolumeRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVolumeResponse>(response);
        }
        
        public ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVersionsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerializeNull<ListVersionsResponse>(response);
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
        
    }
}