using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class ShiploadSerial
    {
        public string ShipId { get; set; }
        public string Prtnum { get; set; }
        public string PrtClientId { get; set; }
        public string SerNum { get; set; }
        public string Invtid { get; set; }
        public string SerNumTypId { get; set; }
        public string SerLvl { get; set; }
        public DateTime? CreateDte { get; set; }
        public string Ordnum { get; set; }
        public string ClientId { get; set; }
    }
}
