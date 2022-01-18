using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace APIIntegrationProject
{
    public class PurchaseOrderResponse
    {
        [JsonProperty("Result")]
        public List<PurchaseOrderHeader> PurchaseOrders { get; set; }
    }

    public class PurchaseOrderObject
    {
        [JsonProperty("PurchaseOrderHeader")]
        public PurchaseOrderHeader Header { get; set; }
        [JsonProperty("PurchaseOrderItem")]
        public List<PurchaseOrderLine> Lines { get; set; }
    }

    public class PurchaseOrderHeader
    {
        [JsonProperty("OrderID")]
        public string PurchaseOrderId { get; set;}
        [JsonProperty("SupplierID")]
        public string SupplierID { get; set; }
        [JsonProperty("Created")]
        public DateTime Created { get; set; }
    }
}
