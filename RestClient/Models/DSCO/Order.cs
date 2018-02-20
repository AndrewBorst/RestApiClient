using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiClient.Models.DSCO
{
    public class DscoOrder
    {

        public string ClientID { get; set; }
        public string OrderID { get; set; }
        public string DcNum { get; set; }
        public string BusAddr1 { get; set; }
        public string BusAddr2 { get; set; }
        public string BusCity { get; set; }
        public string BusCountry { get; set; }
        public string BusName { get; set; }
        public string BusState { get; set; }
        public string BusZip { get; set; }
        public string ContTel { get; set; }
        public string DeptNum { get; set; }
        public string OrderType { get; set; }
        public string PymentType { get; set; }
        public string PoNum { get; set; }
        public string ReqShipDate { get; set; }
        public string ReqDeliveryDate { get; set; }
        public string RsaFlag { get; set; }
        public string RushFlag { get; set; }
        public string ShipAddr1 { get; set; }
        public string ShipAddr2 { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public string ShipName { get; set; }
        public string ShipState { get; set; }
        public string ShipZip { get; set; }
        public string SalesOrdNum { get; set; }
        public string ServiceLevel { get; set; }
        public string ShipToCustNum { get; set; }
        public string SoldToCustNum { get; set; }
        public string StoreName { get; set; }
        public string StoreNum { get; set; }
        public string TotalPrice { get; set; }
        public bool ReadyForWMS { get; }
        public bool SentToWMS { get; }
        public ICollection<DscoOrderDetail> OrderDetail { get; set; }
    }

    public class DscoOrderDetail
    {
        public string ClientID { get; set; }
        public string OrderID { get; set; }
        public string OrderLine { get; set; }

    }

    
}
