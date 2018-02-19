using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class ShiploadOrd
    {
        public string ShipId { get; set; }
        public string HostShipId { get; set; }
        public string ClientId { get; set; }
        public string Stcust { get; set; }
        public string Btcust { get; set; }
        public string Rtcust { get; set; }
        public string Ordnum { get; set; }
        public string Cponum { get; set; }
        public string Ordtyp { get; set; }
        public string VcFld1 { get; set; }
        public string VcFld2 { get; set; }
        public string VcFld3 { get; set; }
        public string VcFld4 { get; set; }
        public string VcFld5 { get; set; }
        public string VcFld6 { get; set; }
        public string VcFld7 { get; set; }
        public string VcFld8 { get; set; }
        public string VcFld9 { get; set; }
        public string VcFld10 { get; set; }
        public int? VcOrdPackCnt { get; set; }
        public string VcShipToName { get; set; }
        public int? VcChepQty { get; set; }
        public int? VcNonChepQty { get; set; }
        public string VcShipToAddr1 { get; set; }
        public string VcShipToAddr2 { get; set; }
        public string VcAdrcty { get; set; }
        public string VcAdrstc { get; set; }
        public string VcAdrpsz { get; set; }
        public string VcCtryName { get; set; }
        public string Reffld1 { get; set; }
        public string Reffld2 { get; set; }
        public string Reffld3 { get; set; }
        public string Reffld4 { get; set; }
        public string Reffld5 { get; set; }
        public DateTime? Entdte { get; set; }
        public string AclxStore { get; set; }
        public int? AclxFrtrte { get; set; }
        public string VcFld11 { get; set; }
        public string VcFld12 { get; set; }
        public string VcFld13 { get; set; }
        public string VcFld14 { get; set; }
        public string VcFld15 { get; set; }
        public string AclxOrdConsId { get; set; }
        public string HostApptNum { get; set; }
        public string AclxDcnum { get; set; }
        public string AclxBolNum { get; set; }
        public string AclxMstBolNum { get; set; }
        public string UcOrdNetWgt { get; set; }
        public string UcCarMoveId { get; set; }
        public bool? SendShipConfirm { get; set; }
        public bool? ShipConfirmSent { get; set; }
        public bool? Asnsent { get; set; }
        public bool? SendAsn { get; set; }
        public bool? SentColdChain { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
