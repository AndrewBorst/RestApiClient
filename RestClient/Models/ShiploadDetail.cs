using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class ShiploadDetail
    {
        public string ShipId { get; set; }
        public string Lodnum { get; set; }
        public string Loducc { get; set; }
        public string Subnum { get; set; }
        public string Subucc { get; set; }
        public string Dtlnum { get; set; }
        public string Prtnum { get; set; }
        public string PrtClientId { get; set; }
        public string Orgcod { get; set; }
        public string Revlvl { get; set; }
        public string Lotnum { get; set; }
        public string Invsts { get; set; }
        public int? Untqty { get; set; }
        public int? Untcas { get; set; }
        public int? Untpak { get; set; }
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public string Ordlin { get; set; }
        public string Ordsln { get; set; }
        public string Hstacc { get; set; }
        public string HostShipId { get; set; }
        public string HostClientId { get; set; }
        public string CatchUnttyp { get; set; }
        public decimal? CatchQty { get; set; }
        public string Lodtag { get; set; }
        public string Subtag { get; set; }
        public string Lodurn { get; set; }
        public string Suburn { get; set; }
        public string DistroId { get; set; }
        public string SourceDistroId { get; set; }
        public string Supnum { get; set; }
        public string AssetTyp { get; set; }
        public string SubAssetTyp { get; set; }
        public decimal? VcGrossWgt { get; set; }
        public decimal? VcNetWgt { get; set; }
        public DateTime? VcExpdat { get; set; }
        public DateTime? VcMfgDt { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
