using Newtonsoft.Json;

namespace APIIntegrationProject
{
    public class PurchaseOrderLine
    {
        [JsonProperty("LineNumber")]
        public int LineNumber { get; set; }
        [JsonProperty("ProductID")]
        public string ProductID { get; set; }
        [JsonProperty("LinePrice")]
        public decimal Price { get; set; }
    }
}
