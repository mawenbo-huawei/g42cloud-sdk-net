using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuaweiCloud.SDK.Core;
using G42Cloud.SDK.Vpc.V3.Model;

namespace G42Cloud.SDK.Vpc.V3
{
    public partial class VpcAsyncClient : Client
    {
        public static ClientBuilder<VpcAsyncClient> NewBuilder()
        {
            return new ClientBuilder<VpcAsyncClient>();
        }

        
        public async Task<BatchCreateSubNetworkInterfaceResponse> BatchCreateSubNetworkInterfaceAsync(BatchCreateSubNetworkInterfaceRequest batchCreateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/batch-create",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", batchCreateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<BatchCreateSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }
        
        public async Task<CreateSecurityGroupRuleResponse> CreateSecurityGroupRuleAsync(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }
        
        public async Task<CreateSubNetworkInterfaceResponse> CreateSubNetworkInterfaceAsync(CreateSubNetworkInterfaceRequest createSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }
        
        public async Task<DeleteSecurityGroupRuleResponse> DeleteSecurityGroupRuleAsync(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }
        
        public async Task<DeleteSubNetworkInterfaceResponse> DeleteSubNetworkInterfaceAsync(DeleteSubNetworkInterfaceRequest deleteSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , deleteSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<ListSecurityGroupRulesResponse> ListSecurityGroupRulesAsync(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }
        
        public async Task<ListSecurityGroupsResponse> ListSecurityGroupsAsync(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }
        
        public async Task<ListSubNetworkInterfacesResponse> ListSubNetworkInterfacesAsync(ListSubNetworkInterfacesRequest listSubNetworkInterfacesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubNetworkInterfacesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListSubNetworkInterfacesResponse>(response);
        }
        
        public async Task<MigrateSubNetworkInterfaceResponse> MigrateSubNetworkInterfaceAsync(MigrateSubNetworkInterfaceRequest migrateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/migrate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<MigrateSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<ShowSecurityGroupResponse> ShowSecurityGroupAsync(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }
        
        public async Task<ShowSecurityGroupRuleResponse> ShowSecurityGroupRuleAsync(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }
        
        public async Task<ShowSubNetworkInterfaceResponse> ShowSubNetworkInterfaceAsync(ShowSubNetworkInterfaceRequest showSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , showSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<ShowSubNetworkInterfacesQuantityResponse> ShowSubNetworkInterfacesQuantityAsync(ShowSubNetworkInterfacesQuantityRequest showSubNetworkInterfacesQuantityRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/count",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubNetworkInterfacesQuantityRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowSubNetworkInterfacesQuantityResponse>(response);
        }
        
        public async Task<UpdateSecurityGroupResponse> UpdateSecurityGroupAsync(UpdateSecurityGroupRequest updateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , updateSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSecurityGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSecurityGroupResponse>(response);
        }
        
        public async Task<UpdateSubNetworkInterfaceResponse> UpdateSubNetworkInterfaceAsync(UpdateSubNetworkInterfaceRequest updateSubNetworkInterfaceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("sub_network_interface_id" , updateSubNetworkInterfaceRequest.SubNetworkInterfaceId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/sub-network-interfaces/{sub_network_interface_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateSubNetworkInterfaceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubNetworkInterfaceResponse>(response);
        }
        
        public async Task<CreateAddressGroupResponse> CreateAddressGroupAsync(CreateAddressGroupRequest createAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAddressGroupResponse>(response);
        }
        
        public async Task<DeleteAddressGroupResponse> DeleteAddressGroupAsync(DeleteAddressGroupRequest deleteAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteAddressGroupResponse>(response);
        }
        
        public async Task<DeleteIpAddressGroupForceResponse> DeleteIpAddressGroupForceAsync(DeleteIpAddressGroupForceRequest deleteIpAddressGroupForceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , deleteIpAddressGroupForceRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}/force",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteIpAddressGroupForceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteIpAddressGroupForceResponse>(response);
        }
        
        public async Task<ListAddressGroupResponse> ListAddressGroupAsync(ListAddressGroupRequest listAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddressGroupResponse>(response);
        }
        
        public async Task<ShowAddressGroupResponse> ShowAddressGroupAsync(ShowAddressGroupRequest showAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , showAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAddressGroupResponse>(response);
        }
        
        public async Task<UpdateAddressGroupResponse> UpdateAddressGroupAsync(UpdateAddressGroupRequest updateAddressGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("address_group_id" , updateAddressGroupRequest.AddressGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/address-groups/{address_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddressGroupRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddressGroupResponse>(response);
        }
        
        public async Task<AddVpcExtendCidrResponse> AddVpcExtendCidrAsync(AddVpcExtendCidrRequest addVpcExtendCidrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , addVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/add-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", addVpcExtendCidrRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<AddVpcExtendCidrResponse>(response);
        }
        
        public async Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest createVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }
        
        public async Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest deleteVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }
        
        public async Task<ListVpcsResponse> ListVpcsAsync(ListVpcsRequest listVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }
        
        public async Task<RemoveVpcExtendCidrResponse> RemoveVpcExtendCidrAsync(RemoveVpcExtendCidrRequest removeVpcExtendCidrRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , removeVpcExtendCidrRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}/remove-extend-cidr",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeVpcExtendCidrRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RemoveVpcExtendCidrResponse>(response);
        }
        
        public async Task<ShowVpcResponse> ShowVpcAsync(ShowVpcRequest showVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }
        
        public async Task<UpdateVpcResponse> UpdateVpcAsync(UpdateVpcRequest updateVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v3/{project_id}/vpc/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateVpcRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}