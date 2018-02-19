using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class ShiploadShipment
    {
        public string ShipId { get; set; }
        public string HostShipId { get; set; }
        public string ShipClientId { get; set; }
        public string ShipDocNum { get; set; }
        public string ShipTrackNum { get; set; }
        public string FrghtChrg { get; set; }
        public string Frtcod { get; set; }
        public DateTime? EarlyDevDt { get; set; }
        public DateTime? EarlyShpDt { get; set; }
        public DateTime? LateDevDt { get; set; }
        public DateTime? LateShpDt { get; set; }
        public string FrghtRate { get; set; }
        public string Srvlvl { get; set; }
        public string SrcHost { get; set; }
        public string SrcPort { get; set; }
        public string WhId { get; set; }
        public string Aesitn { get; set; }
        public string AesTyp { get; set; }
        public DateTime? AesAcptDte { get; set; }
        public string Ftsrnum { get; set; }
        public string UcStopId { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
