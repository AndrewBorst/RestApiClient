using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class TocustXref
    {
        public string Carcod { get; set; }
        public string ClientId { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateDte { get; set; }
        public string Custtype { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDte { get; set; }
        public string Tocust { get; set; }
    }
}
