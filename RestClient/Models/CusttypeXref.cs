using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class CusttypeXref
    {
        public string Btcust { get; set; }
        public string Carrier { get; set; }
        public string CarrierWb { get; set; }
        public string ClientId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDte { get; set; }
        public string Custtype { get; set; }
        public decimal? DaysToAdd { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDte { get; set; }
        public string OrdType { get; set; }
        public string Payterm { get; set; }
        public string PaytermWb { get; set; }
        public string RpCustype { get; set; }
        public string SoldtoCustno { get; set; }
        public string Srvlvl { get; set; }
        public string SrvlvlWb { get; set; }
        public string WaveFlg { get; set; }
        public decimal? WeightBreak { get; set; }
    }
}
