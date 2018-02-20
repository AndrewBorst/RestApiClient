using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class OrderHeader
    {
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public string PoNum { get; set; }
        public string BName { get; set; }
        public string BAddr1 { get; set; }
        public string BAddr2 { get; set; }
        public string BCity { get; set; }
        public string BState { get; set; }
        public string BZip { get; set; }
        public string BCountry { get; set; }
        public string SName { get; set; }
        public string SAddr1 { get; set; }
        public string SAddr2 { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SZip { get; set; }
        public string SCountry { get; set; }
        public string ContTel { get; set; }
        public string ShiptoCustno { get; set; }
        public string SoldtoCustno { get; set; }
        public int? RushFlg { get; set; }
        public decimal? TotalPrice { get; set; }
        public DateTime? RequestShipDate { get; set; }
        public string ServiceLvl { get; set; }
        public DateTime? RequestedDeliveryDate { get; set; }
        public string StoreNum { get; set; }
        public string DeptNo { get; set; }
        public string PaymentType { get; set; }
        public string OrderType { get; set; }
        public string StoreName { get; set; }
        public string AclxDcnum { get; set; }
        public int? Rsaflag { get; set; }
        public bool ReadyForRp { get; set; }
        public bool SentToRp { get; set; }
        public DateTime CreateDte { get; set; }
        public string TransBillMethod { get; set; }
        public string SalesOrdnum { get; set; }
    }
}
