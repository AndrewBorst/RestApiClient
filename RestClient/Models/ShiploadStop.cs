using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class ShiploadStop
    {
        public string StopId { get; set; }
        public int? StopSeq { get; set; }
        public string AdressId { get; set; }
        public string Docnum { get; set; }
        public string TrackNum { get; set; }
        public string HostAdrId { get; set; }
        public string CarMoveId { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
