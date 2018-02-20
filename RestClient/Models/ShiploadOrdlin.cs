using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class ShiploadOrdlin
    {
        public string ShipId { get; set; }
        public string ShipLineId { get; set; }
        public string OrdClientId { get; set; }
        public string Ordnum { get; set; }
        public string Ordlin { get; set; }
        public string Ordsln { get; set; }
        public string SalesOrdNum { get; set; }
        public string SalesOrdlin { get; set; }
        public string PartNum { get; set; }
        public int? OrderedLineQty { get; set; }
        public int? ShipmentLineQty { get; set; }
        public int? ShpQty { get; set; }
        public string InvstsPrg { get; set; }
        public string Invsts { get; set; }
        public string Stkuom { get; set; }
        public string Hstacc { get; set; }
        public string NonAlcFlg { get; set; }
        public string DistroId { get; set; }
        public string SourceDistroId { get; set; }
        public string RequestedSupnum { get; set; }
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
        public string Reffld1 { get; set; }
        public string Reffld2 { get; set; }
        public string Reffld3 { get; set; }
        public string Reffld4 { get; set; }
        public string Reffld5 { get; set; }
        public string Paytrm { get; set; }
        public string Deptno { get; set; }
        public string UcUpcEa { get; set; }
        public string UcUpcCs { get; set; }
        public string VcFld11 { get; set; }
        public string VcFld12 { get; set; }
        public string VcFld13 { get; set; }
        public string VcFld14 { get; set; }
        public string VcFld15 { get; set; }
        public int? HostOrdqty { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
