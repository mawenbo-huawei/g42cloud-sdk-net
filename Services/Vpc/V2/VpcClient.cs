using System;
using System.Net.Http;
using System.Collections.Generic;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Vpc.V2.Model;

namespace G42Cloud.SDK.Vpc.V2
{
    public partial class VpcClient : Client
    {
        public static ClientBuilder<VpcClient> NewBuilder()
        {
            return new ClientBuilder<VpcClient>();
        }

        
        public AcceptVpcPeeringResponse AcceptVpcPeering(AcceptVpcPeeringRequest acceptVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , acceptVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/accept",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", acceptVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<AcceptVpcPeeringResponse>(response);
        }
        
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , associateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", associateRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<AssociateRouteTableResponse>(response);
        }
        
        public BatchCreateSubnetTagsResponse BatchCreateSubnetTags(BatchCreateSubnetTagsRequest batchCreateSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , batchCreateSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateSubnetTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateSubnetTagsResponse>(response);
        }
        
        public BatchDeleteSubnetTagsResponse BatchDeleteSubnetTags(BatchDeleteSubnetTagsRequest batchDeleteSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , batchDeleteSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteSubnetTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteSubnetTagsResponse>(response);
        }
        
        public CreatePortResponse CreatePort(CreatePortRequest createPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPortRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePortResponse>(response);
        }
        
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest createRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateRouteTableResponse>(response);
        }
        
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupResponse>(response);
        }
        
        public CreateSecurityGroupRuleResponse CreateSecurityGroupRule(CreateSecurityGroupRuleRequest createSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSecurityGroupRuleResponse>(response);
        }
        
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest createSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateSubnetResponse>(response);
        }
        
        public CreateSubnetTagResponse CreateSubnetTag(CreateSubnetTagRequest createSubnetTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , createSubnetTagRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createSubnetTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateSubnetTagResponse>(response);
        }
        
        public CreateVpcPeeringResponse CreateVpcPeering(CreateVpcPeeringRequest createVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcPeeringResponse>(response);
        }
        
        public DeletePortResponse DeletePort(DeletePortRequest deletePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , deletePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePortResponse>(response);
        }
        
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , deleteRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteRouteTableResponse>(response);
        }
        
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , deleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupResponse>(response);
        }
        
        public DeleteSecurityGroupRuleResponse DeleteSecurityGroupRule(DeleteSecurityGroupRuleRequest deleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , deleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSecurityGroupRuleResponse>(response);
        }
        
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest deleteSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , deleteSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubnetResponse>(response);
        }
        
        public DeleteSubnetTagResponse DeleteSubnetTag(DeleteSubnetTagRequest deleteSubnetTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , deleteSubnetTagRequest.SubnetId.ToString());
            urlParam.Add("key" , deleteSubnetTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteSubnetTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteSubnetTagResponse>(response);
        }
        
        public DeleteVpcPeeringResponse DeleteVpcPeering(DeleteVpcPeeringRequest deleteVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , deleteVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcPeeringResponse>(response);
        }
        
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , disassociateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", disassociateRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<DisassociateRouteTableResponse>(response);
        }
        
        public ListPortsResponse ListPorts(ListPortsRequest listPortsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPortsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPortsResponse>(response);
        }
        
        public ListRouteTablesResponse ListRouteTables(ListRouteTablesRequest listRouteTablesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listRouteTablesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListRouteTablesResponse>(response);
        }
        
        public ListSecurityGroupRulesResponse ListSecurityGroupRules(ListSecurityGroupRulesRequest listSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupRulesResponse>(response);
        }
        
        public ListSecurityGroupsResponse ListSecurityGroups(ListSecurityGroupsRequest listSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSecurityGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSecurityGroupsResponse>(response);
        }
        
        public ListSubnetTagsResponse ListSubnetTags(ListSubnetTagsRequest listSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubnetTagsResponse>(response);
        }
        
        public ListSubnetsResponse ListSubnets(ListSubnetsRequest listSubnetsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listSubnetsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListSubnetsResponse>(response);
        }
        
        public ListSubnetsByTagsResponse ListSubnetsByTags(ListSubnetsByTagsRequest listSubnetsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listSubnetsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListSubnetsByTagsResponse>(response);
        }
        
        public ListVpcPeeringsResponse ListVpcPeerings(ListVpcPeeringsRequest listVpcPeeringsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcPeeringsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcPeeringsResponse>(response);
        }
        
        public RejectVpcPeeringResponse RejectVpcPeering(RejectVpcPeeringRequest rejectVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , rejectVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}/reject",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", rejectVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<RejectVpcPeeringResponse>(response);
        }
        
        public ShowPortResponse ShowPort(ShowPortRequest showPortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , showPortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPortRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPortResponse>(response);
        }
        
        public ShowQuotaResponse ShowQuota(ShowQuotaRequest showQuotaRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/quotas",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showQuotaRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowQuotaResponse>(response);
        }
        
        public ShowRouteTableResponse ShowRouteTable(ShowRouteTableRequest showRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , showRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowRouteTableResponse>(response);
        }
        
        public ShowSecurityGroupResponse ShowSecurityGroup(ShowSecurityGroupRequest showSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , showSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupResponse>(response);
        }
        
        public ShowSecurityGroupRuleResponse ShowSecurityGroupRule(ShowSecurityGroupRuleRequest showSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , showSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSecurityGroupRuleResponse>(response);
        }
        
        public ShowSubnetResponse ShowSubnet(ShowSubnetRequest showSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , showSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubnetResponse>(response);
        }
        
        public ShowSubnetTagsResponse ShowSubnetTags(ShowSubnetTagsRequest showSubnetTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , showSubnetTagsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/subnets/{subnet_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showSubnetTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowSubnetTagsResponse>(response);
        }
        
        public ShowVpcPeeringResponse ShowVpcPeering(ShowVpcPeeringRequest showVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , showVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcPeeringResponse>(response);
        }
        
        public UpdatePortResponse UpdatePort(UpdatePortRequest updatePortRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("port_id" , updatePortRequest.PortId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/ports/{port_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updatePortRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdatePortResponse>(response);
        }
        
        public UpdateRouteTableResponse UpdateRouteTable(UpdateRouteTableRequest updateRouteTableRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("routetable_id" , updateRouteTableRequest.RoutetableId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/routetables/{routetable_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateRouteTableRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateRouteTableResponse>(response);
        }
        
        public UpdateSubnetResponse UpdateSubnet(UpdateSubnetRequest updateSubnetRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateSubnetRequest.VpcId.ToString());
            urlParam.Add("subnet_id" , updateSubnetRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}/subnets/{subnet_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateSubnetRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateSubnetResponse>(response);
        }
        
        public UpdateVpcPeeringResponse UpdateVpcPeering(UpdateVpcPeeringRequest updateVpcPeeringRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("peering_id" , updateVpcPeeringRequest.PeeringId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/peerings/{peering_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcPeeringRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcPeeringResponse>(response);
        }
        
        public CreatePrivateipResponse CreatePrivateip(CreatePrivateipRequest createPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createPrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreatePrivateipResponse>(response);
        }
        
        public DeletePrivateipResponse DeletePrivateip(DeletePrivateipRequest deletePrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , deletePrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deletePrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeletePrivateipResponse>(response);
        }
        
        public ListPrivateipsResponse ListPrivateips(ListPrivateipsRequest listPrivateipsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("subnet_id" , listPrivateipsRequest.SubnetId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/subnets/{subnet_id}/privateips",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listPrivateipsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListPrivateipsResponse>(response);
        }
        
        public ShowNetworkIpAvailabilitiesResponse ShowNetworkIpAvailabilities(ShowNetworkIpAvailabilitiesRequest showNetworkIpAvailabilitiesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("network_id" , showNetworkIpAvailabilitiesRequest.NetworkId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/network-ip-availabilities/{network_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNetworkIpAvailabilitiesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowNetworkIpAvailabilitiesResponse>(response);
        }
        
        public ShowPrivateipResponse ShowPrivateip(ShowPrivateipRequest showPrivateipRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("privateip_id" , showPrivateipRequest.PrivateipId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/privateips/{privateip_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showPrivateipRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowPrivateipResponse>(response);
        }
        
        public NeutronCreateSecurityGroupResponse NeutronCreateSecurityGroup(NeutronCreateSecurityGroupRequest neutronCreateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupResponse>(response);
        }
        
        public NeutronCreateSecurityGroupRuleResponse NeutronCreateSecurityGroupRule(NeutronCreateSecurityGroupRuleRequest neutronCreateSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateSecurityGroupRuleResponse>(response);
        }
        
        public NeutronDeleteSecurityGroupResponse NeutronDeleteSecurityGroup(NeutronDeleteSecurityGroupRequest neutronDeleteSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronDeleteSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupResponse>(response);
        }
        
        public NeutronDeleteSecurityGroupRuleResponse NeutronDeleteSecurityGroupRule(NeutronDeleteSecurityGroupRuleRequest neutronDeleteSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , neutronDeleteSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteSecurityGroupRuleResponse>(response);
        }
        
        public NeutronListSecurityGroupRulesResponse NeutronListSecurityGroupRules(NeutronListSecurityGroupRulesRequest neutronListSecurityGroupRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupRulesResponse>(response);
        }
        
        public NeutronListSecurityGroupsResponse NeutronListSecurityGroups(NeutronListSecurityGroupsRequest neutronListSecurityGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListSecurityGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListSecurityGroupsResponse>(response);
        }
        
        public NeutronShowSecurityGroupResponse NeutronShowSecurityGroup(NeutronShowSecurityGroupRequest neutronShowSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronShowSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupResponse>(response);
        }
        
        public NeutronShowSecurityGroupRuleResponse NeutronShowSecurityGroupRule(NeutronShowSecurityGroupRuleRequest neutronShowSecurityGroupRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_rule_id" , neutronShowSecurityGroupRuleRequest.SecurityGroupRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-group-rules/{security_group_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowSecurityGroupRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowSecurityGroupRuleResponse>(response);
        }
        
        public NeutronUpdateSecurityGroupResponse NeutronUpdateSecurityGroup(NeutronUpdateSecurityGroupRequest neutronUpdateSecurityGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("security_group_id" , neutronUpdateSecurityGroupRequest.SecurityGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/security-groups/{security_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateSecurityGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateSecurityGroupResponse>(response);
        }
        
        public NeutronAddFirewallRuleResponse NeutronAddFirewallRule(NeutronAddFirewallRuleRequest neutronAddFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronAddFirewallRuleRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/insert_rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronAddFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronAddFirewallRuleResponse>(response);
        }
        
        public NeutronCreateFirewallGroupResponse NeutronCreateFirewallGroup(NeutronCreateFirewallGroupRequest neutronCreateFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallGroupResponse>(response);
        }
        
        public NeutronCreateFirewallPolicyResponse NeutronCreateFirewallPolicy(NeutronCreateFirewallPolicyRequest neutronCreateFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallPolicyResponse>(response);
        }
        
        public NeutronCreateFirewallRuleResponse NeutronCreateFirewallRule(NeutronCreateFirewallRuleRequest neutronCreateFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronCreateFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<NeutronCreateFirewallRuleResponse>(response);
        }
        
        public NeutronDeleteFirewallGroupResponse NeutronDeleteFirewallGroup(NeutronDeleteFirewallGroupRequest neutronDeleteFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronDeleteFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallGroupResponse>(response);
        }
        
        public NeutronDeleteFirewallPolicyResponse NeutronDeleteFirewallPolicy(NeutronDeleteFirewallPolicyRequest neutronDeleteFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronDeleteFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallPolicyResponse>(response);
        }
        
        public NeutronDeleteFirewallRuleResponse NeutronDeleteFirewallRule(NeutronDeleteFirewallRuleRequest neutronDeleteFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronDeleteFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronDeleteFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<NeutronDeleteFirewallRuleResponse>(response);
        }
        
        public NeutronListFirewallGroupsResponse NeutronListFirewallGroups(NeutronListFirewallGroupsRequest neutronListFirewallGroupsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallGroupsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallGroupsResponse>(response);
        }
        
        public NeutronListFirewallPoliciesResponse NeutronListFirewallPolicies(NeutronListFirewallPoliciesRequest neutronListFirewallPoliciesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallPoliciesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallPoliciesResponse>(response);
        }
        
        public NeutronListFirewallRulesResponse NeutronListFirewallRules(NeutronListFirewallRulesRequest neutronListFirewallRulesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronListFirewallRulesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronListFirewallRulesResponse>(response);
        }
        
        public NeutronRemoveFirewallRuleResponse NeutronRemoveFirewallRule(NeutronRemoveFirewallRuleRequest neutronRemoveFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronRemoveFirewallRuleRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}/remove_rule",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronRemoveFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronRemoveFirewallRuleResponse>(response);
        }
        
        public NeutronShowFirewallGroupResponse NeutronShowFirewallGroup(NeutronShowFirewallGroupRequest neutronShowFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronShowFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallGroupResponse>(response);
        }
        
        public NeutronShowFirewallPolicyResponse NeutronShowFirewallPolicy(NeutronShowFirewallPolicyRequest neutronShowFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronShowFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallPolicyResponse>(response);
        }
        
        public NeutronShowFirewallRuleResponse NeutronShowFirewallRule(NeutronShowFirewallRuleRequest neutronShowFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronShowFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", neutronShowFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<NeutronShowFirewallRuleResponse>(response);
        }
        
        public NeutronUpdateFirewallGroupResponse NeutronUpdateFirewallGroup(NeutronUpdateFirewallGroupRequest neutronUpdateFirewallGroupRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_group_id" , neutronUpdateFirewallGroupRequest.FirewallGroupId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_groups/{firewall_group_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallGroupRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallGroupResponse>(response);
        }
        
        public NeutronUpdateFirewallPolicyResponse NeutronUpdateFirewallPolicy(NeutronUpdateFirewallPolicyRequest neutronUpdateFirewallPolicyRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_policy_id" , neutronUpdateFirewallPolicyRequest.FirewallPolicyId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_policies/{firewall_policy_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallPolicyRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallPolicyResponse>(response);
        }
        
        public NeutronUpdateFirewallRuleResponse NeutronUpdateFirewallRule(NeutronUpdateFirewallRuleRequest neutronUpdateFirewallRuleRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("firewall_rule_id" , neutronUpdateFirewallRuleRequest.FirewallRuleId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/fwaas/firewall_rules/{firewall_rule_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", neutronUpdateFirewallRuleRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<NeutronUpdateFirewallRuleResponse>(response);
        }
        
        public BatchCreateVpcTagsResponse BatchCreateVpcTags(BatchCreateVpcTagsRequest batchCreateVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , batchCreateVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchCreateVpcTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchCreateVpcTagsResponse>(response);
        }
        
        public BatchDeleteVpcTagsResponse BatchDeleteVpcTags(BatchDeleteVpcTagsRequest batchDeleteVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , batchDeleteVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", batchDeleteVpcTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<BatchDeleteVpcTagsResponse>(response);
        }
        
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcResponse>(response);
        }
        
        public CreateVpcResourceTagResponse CreateVpcResourceTag(CreateVpcResourceTagRequest createVpcResourceTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , createVpcResourceTagRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcResourceTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerializeNull<CreateVpcResourceTagResponse>(response);
        }
        
        public CreateVpcRouteResponse CreateVpcRoute(CreateVpcRouteRequest createVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", createVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<CreateVpcRouteResponse>(response);
        }
        
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcResponse>(response);
        }
        
        public DeleteVpcRouteResponse DeleteVpcRoute(DeleteVpcRouteRequest deleteVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , deleteVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcRouteResponse>(response);
        }
        
        public DeleteVpcTagResponse DeleteVpcTag(DeleteVpcTagRequest deleteVpcTagRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , deleteVpcTagRequest.VpcId.ToString());
            urlParam.Add("key" , deleteVpcTagRequest.Key.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags/{key}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteVpcTagRequest);
            HttpResponseMessage response = DoHttpRequestSync("DELETE",request);
            return JsonUtils.DeSerializeNull<DeleteVpcTagResponse>(response);
        }
        
        public ListVpcRoutesResponse ListVpcRoutes(ListVpcRoutesRequest listVpcRoutesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcRoutesRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcRoutesResponse>(response);
        }
        
        public ListVpcTagsResponse ListVpcTags(ListVpcTagsRequest listVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcTagsResponse>(response);
        }
        
        public ListVpcsResponse ListVpcs(ListVpcsRequest listVpcsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listVpcsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ListVpcsResponse>(response);
        }
        
        public ListVpcsByTagsResponse ListVpcsByTags(ListVpcsByTagsRequest listVpcsByTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/resource_instances/action",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", listVpcsByTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("POST",request);
            return JsonUtils.DeSerialize<ListVpcsByTagsResponse>(response);
        }
        
        public ShowVpcResponse ShowVpc(ShowVpcRequest showVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcResponse>(response);
        }
        
        public ShowVpcRouteResponse ShowVpcRoute(ShowVpcRouteRequest showVpcRouteRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("route_id" , showVpcRouteRequest.RouteId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/vpc/routes/{route_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcRouteRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcRouteResponse>(response);
        }
        
        public ShowVpcTagsResponse ShowVpcTags(ShowVpcTagsRequest showVpcTagsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , showVpcTagsRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v2.0/{project_id}/vpcs/{vpc_id}/tags",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showVpcTagsRequest);
            HttpResponseMessage response = DoHttpRequestSync("GET",request);
            return JsonUtils.DeSerialize<ShowVpcTagsResponse>(response);
        }
        
        public UpdateVpcResponse UpdateVpc(UpdateVpcRequest updateVpcRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("vpc_id" , updateVpcRequest.VpcId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/v1/{project_id}/vpcs/{vpc_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json;charset=UTF-8", updateVpcRequest);
            HttpResponseMessage response = DoHttpRequestSync("PUT",request);
            return JsonUtils.DeSerialize<UpdateVpcResponse>(response);
        }
        
    }
}