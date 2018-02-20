using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class ShiploadMove
    {
        public string CarMoveId { get; set; }
        public string HostMoveId { get; set; }
        public string HostClientId { get; set; }
        public string Carcod { get; set; }
        public string MoveDocnum { get; set; }
        public string MoveTrackNum { get; set; }
        public string TrlrId { get; set; }
        public string TrlrNum { get; set; }
        public string TrlrTyp { get; set; }
        public string TrlrBroker { get; set; }
        public string TrlrSize { get; set; }
        public string TrlrSeal1 { get; set; }
        public string TrlrSeal2 { get; set; }
        public string TrlrSeal3 { get; set; }
        public string TrlrSeal4 { get; set; }
        public string DriveName { get; set; }
        public string DriveLic { get; set; }
        public DateTime? CloseDte { get; set; }
        public DateTime? PendDte { get; set; }
        public DateTime? DispatchDte { get; set; }
        public string Sitcod { get; set; }
        public string WhId { get; set; }
        public string Trnnum { get; set; }
        public DateTime? Trndte { get; set; }
        public string VcWhName { get; set; }
        public string Carnam { get; set; }
        public string Scac { get; set; }
        public DateTime? CreateDte { get; set; }
    }
}
