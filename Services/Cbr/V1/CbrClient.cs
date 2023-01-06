using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Cbr.V1.Model;

namespace G42Cloud.SDK.Cbr.V1
{
    public partial class CbrClient : Client
    {
        public static ClientBuilder<CbrClient> NewBuilder()
        {
            return new ClientBuilder<CbrClient>();
        }

        
        public AddMemberResponse AddMember(AddMemberRequest addMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , addMemberRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddMemberResponse>(response);
        }
        
        public AddVaultResourceResponse AddVaultResource(AddVaultResourceRequest addVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , addVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/addresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", addVaultResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AddVaultResourceResponse>(response);
        }
        
        public AssociateVaultPolicyResponse AssociateVaultPolicy(AssociateVaultPolicyRequest associateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , associateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/associatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateVaultPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AssociateVaultPolicyResponse>(response);
        }
        
        public BatchCreateAndDeleteVaultTagsResponse BatchCreateAndDeleteVaultTags(BatchCreateAndDeleteVaultTagsRequest batchCreateAndDeleteVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , batchCreateAndDeleteVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateAndDeleteVaultTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateAndDeleteVaultTagsResponse>(response);
        }
        
        public CopyBackupResponse CopyBackup(CopyBackupRequest copyBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , copyBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyBackupResponse>(response);
        }
        
        public CopyCheckpointResponse CopyCheckpoint(CopyCheckpointRequest copyCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/replicate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", copyCheckpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CopyCheckpointResponse>(response);
        }
        
        public CreateCheckpointResponse CreateCheckpoint(CreateCheckpointRequest createCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createCheckpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateCheckpointResponse>(response);
        }
        
        public CreatePolicyResponse CreatePolicy(CreatePolicyRequest createPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePolicyResponse>(response);
        }
        
        public CreateVaultResponse CreateVault(CreateVaultRequest createVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVaultResponse>(response);
        }
        
        public CreateVaultTagsResponse CreateVaultTags(CreateVaultTagsRequest createVaultTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , createVaultTagsRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVaultTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVaultTagsResponse>(response);
        }
        
        public DeleteBackupResponse DeleteBackup(DeleteBackupRequest deleteBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteBackupResponse>(response);
        }
        
        public DeleteMemberResponse DeleteMember(DeleteMemberRequest deleteMemberRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , deleteMemberRequest.BackupId.ToString());
            urlParam.Add("member_id" , deleteMemberRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteMemberRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteMemberResponse>(response);
        }
        
        public DeletePolicyResponse DeletePolicy(DeletePolicyRequest deletePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , deletePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePolicyResponse>(response);
        }
        
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest deleteVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , deleteVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultResponse>(response);
        }
        
        public DeleteVaultTagResponse DeleteVaultTag(DeleteVaultTagRequest deleteVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("key" , deleteVaultTagRequest.Key.ToString());
            urlParam.Add("vault_id" , deleteVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVaultTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVaultTagResponse>(response);
        }
        
        public DisassociateVaultPolicyResponse DisassociateVaultPolicy(DisassociateVaultPolicyRequest disassociateVaultPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , disassociateVaultPolicyRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/dissociatepolicy",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateVaultPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisassociateVaultPolicyResponse>(response);
        }
        
        public ImportBackupResponse ImportBackup(ImportBackupRequest importBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/sync",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", importBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ImportBackupResponse>(response);
        }
        
        public ListBackupsResponse ListBackups(ListBackupsRequest listBackupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listBackupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListBackupsResponse>(response);
        }
        
        public ListOpLogsResponse ListOpLogs(ListOpLogsRequest listOpLogsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listOpLogsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListOpLogsResponse>(response);
        }
        
        public ListPoliciesResponse ListPolicies(ListPoliciesRequest listPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPoliciesResponse>(response);
        }
        
        public ListProtectableResponse ListProtectable(ListProtectableRequest listProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("protectable_type" , listProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listProtectableRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListProtectableResponse>(response);
        }
        
        public ListVaultResponse ListVault(ListVaultRequest listVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVaultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVaultResponse>(response);
        }
        
        public MigrateVaultResourceResponse MigrateVaultResource(MigrateVaultResourceRequest migrateVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , migrateVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/migrateresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", migrateVaultResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<MigrateVaultResourceResponse>(response);
        }
        
        public RemoveVaultResourceResponse RemoveVaultResource(RemoveVaultResourceRequest removeVaultResourceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , removeVaultResourceRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}/removeresources",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", removeVaultResourceRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<RemoveVaultResourceResponse>(response);
        }
        
        public RestoreBackupResponse RestoreBackup(RestoreBackupRequest restoreBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , restoreBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/restore",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", restoreBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<RestoreBackupResponse>(response);
        }
        
        public ShowBackupResponse ShowBackup(ShowBackupRequest showBackupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showBackupRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showBackupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowBackupResponse>(response);
        }
        
        public ShowCheckpointResponse ShowCheckpoint(ShowCheckpointRequest showCheckpointRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("checkpoint_id" , showCheckpointRequest.CheckpointId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/checkpoints/{checkpoint_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showCheckpointRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowCheckpointResponse>(response);
        }
        
        public ShowMemberDetailResponse ShowMemberDetail(ShowMemberDetailRequest showMemberDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMemberDetailRequest.BackupId.ToString());
            urlParam.Add("member_id" , showMemberDetailRequest.MemberId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMemberDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMemberDetailResponse>(response);
        }
        
        public ShowMembersDetailResponse ShowMembersDetail(ShowMembersDetailRequest showMembersDetailRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("backup_id" , showMembersDetailRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showMembersDetailRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowMembersDetailResponse>(response);
        }
        
        public ShowOpLogResponse ShowOpLog(ShowOpLogRequest showOpLogRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("operation_log_id" , showOpLogRequest.OperationLogId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/operation-logs/{operation_log_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showOpLogRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowOpLogResponse>(response);
        }
        
        public ShowPolicyResponse ShowPolicy(ShowPolicyRequest showPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , showPolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPolicyResponse>(response);
        }
        
        public ShowProtectableResponse ShowProtectable(ShowProtectableRequest showProtectableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("instance_id" , showProtectableRequest.InstanceId.ToString());
            urlParam.Add("protectable_type" , showProtectableRequest.ProtectableType.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/protectables/{protectable_type}/instances/{instance_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showProtectableRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowProtectableResponse>(response);
        }
        
        public ShowReplicationCapabilitiesResponse ShowReplicationCapabilities(ShowReplicationCapabilitiesRequest showReplicationCapabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/replication-capabilities",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showReplicationCapabilitiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowReplicationCapabilitiesResponse>(response);
        }
        
        public ShowVaultResponse ShowVault(ShowVaultRequest showVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultResponse>(response);
        }
        
        public ShowVaultProjectTagResponse ShowVaultProjectTag(ShowVaultProjectTagRequest showVaultProjectTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultProjectTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultProjectTagResponse>(response);
        }
        
        public ShowVaultResourceInstancesResponse ShowVaultResourceInstances(ShowVaultResourceInstancesRequest showVaultResourceInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", showVaultResourceInstancesRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ShowVaultResourceInstancesResponse>(response);
        }
        
        public ShowVaultTagResponse ShowVaultTag(ShowVaultTagRequest showVaultTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , showVaultTagRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vault/{vault_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVaultTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVaultTagResponse>(response);
        }
        
        public UpdateMemberStatusResponse UpdateMemberStatus(UpdateMemberStatusRequest updateMemberStatusRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("member_id" , updateMemberStatusRequest.MemberId.ToString());
            urlParam.Add("backup_id" , updateMemberStatusRequest.BackupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/backups/{backup_id}/members/{member_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateMemberStatusRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateMemberStatusResponse>(response);
        }
        
        public UpdatePolicyResponse UpdatePolicy(UpdatePolicyRequest updatePolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("policy_id" , updatePolicyRequest.PolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/policies/{policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePolicyResponse>(response);
        }
        
        public UpdateVaultResponse UpdateVault(UpdateVaultRequest updateVaultRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vault_id" , updateVaultRequest.VaultId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vaults/{vault_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVaultRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVaultResponse>(response);
        }
        
    }
}