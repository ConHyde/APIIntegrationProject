using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;

namespace APIIntegrationProject
{
    public class PurchaseOrderService
    {
        public static PurchaseOrderObject GetPurchaseOrder(string token, string server, string id)
        {
            var purchaseOrders = new List<PurchaseOrderResponse>();

            PurchaseOrdersRequest poRequest = new PurchaseOrdersRequest();
            poRequest.Warehouses.Add(new string("Test Warehouse"));
            var serialized = JsonConvert.SerializeObject(poRequest);
            var client = new RestClient($"{server}/api/PurchaseOrder");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", token);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded; charset=UTF-8");
            request.AddHeader("Accept-Encoding", "gzip, deflate");
            request.AddParameter("purchaseOrderID", id);
            IRestResponse response = client.Execute(request);

            PurchaseOrderObject po = JsonConvert.DeserializeObject<PurchaseOrderObject>(response.Content);
            return po;
        }
    }

    public class PurchaseOrdersRequest
    {
        public List<string> Warehouses = new List<string>();
    }
}
