using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class OrderDetail
    {
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public int Ordlin { get; set; }
        public string CustLinenum { get; set; }
        public double? Qty { get; set; }
        public string Carcod { get; set; }
        public string Uom { get; set; }
        public string UpcCasecode { get; set; }
        public string Sku { get; set; }
        public string RetailItemCode { get; set; }
        public double? CaseCount { get; set; }
        public double? Weight { get; set; }
        public string FreightClassCode { get; set; }
        public double? SalesPrice { get; set; }
        public double? OrderPrice { get; set; }
        public double? ShippingCost { get; set; }
        public double? TotalPrice { get; set; }
        public double? Tax { get; set; }
        public string ItemDesc { get; set; }
        public string DpciNum { get; set; }
        public string TcNum { get; set; }
        public string BinLoc { get; set; }
        public string BulkLoc { get; set; }
        public string ServOpt { get; set; }
        public DateTime CreateDte { get; set; }
    }
}
