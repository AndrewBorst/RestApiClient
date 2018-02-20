using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class ShiploadParcel
    {
        public string ShipId { get; set; }
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public string Crtnid { get; set; }
        public string Mfstid { get; set; }
        public DateTime? Mstdte { get; set; }
        public string Traknm { get; set; }
        public string Frtrte { get; set; }
        public string Subnum { get; set; }
        public string Weight { get; set; }
        public string Carcod { get; set; }
        public string Srvlvl { get; set; }
        public string Prtnum { get; set; }
        public string PrtClientId { get; set; }
        public string Dstnam { get; set; }
        public string Usrfld1 { get; set; }
        public string Usrfld2 { get; set; }
        public string Usrfld3 { get; set; }
        public string Usrfld4 { get; set; }
        public string Lodnum { get; set; }
        public string UcSapmaterial { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
