using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using G42Cloud.SDK.Core;
using G42Cloud.SDK.Cce.V3.Model;

namespace G42Cloud.SDK.Cce.V3
{
    public partial class CceAsyncClient : Client
    {
        public static ClientBuilder<CceAsyncClient> NewBuilder()
        {
            return new ClientBuilder<CceAsyncClient>();
        }

        
        public async Task<AwakeClusterResponse> AwakeClusterAsync(AwakeClusterRequest awakeClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , awakeClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/awake",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", awakeClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<AwakeClusterResponse>(response);
        }
        
        public async Task<CreateAddonInstanceResponse> CreateAddonInstanceAsync(CreateAddonInstanceRequest createAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateAddonInstanceResponse>(response);
        }
        
        public async Task<CreateCloudPersistentVolumeClaimsResponse> CreateCloudPersistentVolumeClaimsAsync(CreateCloudPersistentVolumeClaimsRequest createCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("namespace" , createCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateCloudPersistentVolumeClaimsResponse>(response);
        }
        
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest createClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateClusterResponse>(response);
        }
        
        public async Task<CreateKubernetesClusterCertResponse> CreateKubernetesClusterCertAsync(CreateKubernetesClusterCertRequest createKubernetesClusterCertRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createKubernetesClusterCertRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/clustercert",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createKubernetesClusterCertRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateKubernetesClusterCertResponse>(response);
        }
        
        public async Task<CreateNodeResponse> CreateNodeAsync(CreateNodeRequest createNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateNodeResponse>(response);
        }
        
        public async Task<CreateNodePoolResponse> CreateNodePoolAsync(CreateNodePoolRequest createNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , createNodePoolRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", createNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerialize<CreateNodePoolResponse>(response);
        }
        
        public async Task<DeleteAddonInstanceResponse> DeleteAddonInstanceAsync(DeleteAddonInstanceRequest deleteAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , deleteAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            DeleteAddonInstanceResponse deleteAddonInstanceResponse = JsonUtils.DeSerializeNull<DeleteAddonInstanceResponse>(response);
            return deleteAddonInstanceResponse;
        }
        
        public async Task<DeleteCloudPersistentVolumeClaimsResponse> DeleteCloudPersistentVolumeClaimsAsync(DeleteCloudPersistentVolumeClaimsRequest deleteCloudPersistentVolumeClaimsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("name" , deleteCloudPersistentVolumeClaimsRequest.Name.ToString());
            urlParam.Add("namespace" , deleteCloudPersistentVolumeClaimsRequest.Namespace.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v1/namespaces/{namespace}/cloudpersistentvolumeclaims/{name}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteCloudPersistentVolumeClaimsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteCloudPersistentVolumeClaimsResponse>(response);
        }
        
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest deleteClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteClusterResponse>(response);
        }
        
        public async Task<DeleteNodeResponse> DeleteNodeAsync(DeleteNodeRequest deleteNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , deleteNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodeResponse>(response);
        }
        
        public async Task<DeleteNodePoolResponse> DeleteNodePoolAsync(DeleteNodePoolRequest deleteNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , deleteNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , deleteNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", deleteNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("DELETE",request);
            return JsonUtils.DeSerialize<DeleteNodePoolResponse>(response);
        }
        
        public async Task<HibernateClusterResponse> HibernateClusterAsync(HibernateClusterRequest hibernateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , hibernateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/operation/hibernate",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", hibernateClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("POST",request);
            return JsonUtils.DeSerializeNull<HibernateClusterResponse>(response);
        }
        
        public async Task<ListAddonInstancesResponse> ListAddonInstancesAsync(ListAddonInstancesRequest listAddonInstancesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonInstancesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddonInstancesResponse>(response);
        }
        
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest listAddonTemplatesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addontemplates",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listAddonTemplatesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListAddonTemplatesResponse>(response);
        }
        
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest listClustersRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listClustersRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListClustersResponse>(response);
        }
        
        public async Task<ListNodePoolsResponse> ListNodePoolsAsync(ListNodePoolsRequest listNodePoolsRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodePoolsRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodePoolsRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNodePoolsResponse>(response);
        }
        
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest listNodesRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , listNodesRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", listNodesRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ListNodesResponse>(response);
        }
        
        public async Task<MigrateNodeResponse> MigrateNodeAsync(MigrateNodeRequest migrateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , migrateNodeRequest.ClusterId.ToString());
            urlParam.Add("target_cluster_id" , migrateNodeRequest.TargetClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/migrateto/{target_cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", migrateNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<MigrateNodeResponse>(response);
        }
        
        public async Task<RemoveNodeResponse> RemoveNodeAsync(RemoveNodeRequest removeNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , removeNodeRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/operation/remove",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", removeNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<RemoveNodeResponse>(response);
        }
        
        public async Task<ShowAddonInstanceResponse> ShowAddonInstanceAsync(ShowAddonInstanceRequest showAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , showAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowAddonInstanceResponse>(response);
        }
        
        public async Task<ShowClusterResponse> ShowClusterAsync(ShowClusterRequest showClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowClusterResponse>(response);
        }
        
        public async Task<ShowJobResponse> ShowJobAsync(ShowJobRequest showJobRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("job_id" , showJobRequest.JobId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/jobs/{job_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showJobRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowJobResponse>(response);
        }
        
        public async Task<ShowNodeResponse> ShowNodeAsync(ShowNodeRequest showNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , showNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNodeResponse>(response);
        }
        
        public async Task<ShowNodePoolResponse> ShowNodePoolAsync(ShowNodePoolRequest showNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , showNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , showNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", showNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("GET",request);
            return JsonUtils.DeSerialize<ShowNodePoolResponse>(response);
        }
        
        public async Task<UpdateAddonInstanceResponse> UpdateAddonInstanceAsync(UpdateAddonInstanceRequest updateAddonInstanceRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("id" , updateAddonInstanceRequest.Id.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/addons/{id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateAddonInstanceRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateAddonInstanceResponse>(response);
        }
        
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest updateClusterRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateClusterRequest.ClusterId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateClusterRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateClusterResponse>(response);
        }
        
        public async Task<UpdateNodeResponse> UpdateNodeAsync(UpdateNodeRequest updateNodeRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodeRequest.ClusterId.ToString());
            urlParam.Add("node_id" , updateNodeRequest.NodeId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodes/{node_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodeRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodeResponse>(response);
        }
        
        public async Task<UpdateNodePoolResponse> UpdateNodePoolAsync(UpdateNodePoolRequest updateNodePoolRequest)
        {
            Dictionary<string, string> urlParam = new Dictionary<string, string>();
            urlParam.Add("cluster_id" , updateNodePoolRequest.ClusterId.ToString());
            urlParam.Add("nodepool_id" , updateNodePoolRequest.NodepoolId.ToString());
            string urlPath = HttpUtils.AddUrlPath("/api/v3/projects/{project_id}/clusters/{cluster_id}/nodepools/{nodepool_id}",urlParam);
            SdkRequest request = HttpUtils.InitSdkRequest(urlPath, "application/json", updateNodePoolRequest);
            HttpResponseMessage response = await DoHttpRequestAsync("PUT",request);
            return JsonUtils.DeSerialize<UpdateNodePoolResponse>(response);
        }
        
    }
}