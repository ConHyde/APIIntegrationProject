using System;
using System.Collections.Generic;
using APIIntegrationProject.DBHelpers;

namespace APIIntegrationProject
{
    public class LinnworksIntegrationClient
    {
        public class IntegrationActionResult
        {
            public bool Success { get; set; }
            public string Error { get; set; }
            
        }

        public static readonly string _token = "";
        public static readonly string _server = "";

        public IntegrationActionResult ImportPurchaseOrders()
        {
            try
            {
                List<PurchaseOrderObject> purchaseOrders = new List<PurchaseOrderObject>();
                for (int i = 1; i > 10; i++)
                {
                    purchaseOrders.Add(PurchaseOrderService.GetPurchaseOrder(_token, _server, i.ToString()));
                }

                foreach(PurchaseOrderObject purchaseOrder in purchaseOrders)
                {
                    PurchaseOrderDBHelper.ImportPurchaseOrder(purchaseOrder.Header);

                }
            }

            catch(Exception ex)
            {
                throw ex;
            }

            return new IntegrationActionResult()
            {
                Success = true,
                Error = "Success"
            };
        }
    }
}
