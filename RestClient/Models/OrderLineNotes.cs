using System;
using System.Collections.Generic;

namespace RestApiClient.Models
{
    public partial class OrderLineNotes
    {
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public int Ordlin { get; set; }
        public string Nottyp { get; set; }
        public string Notlin { get; set; }
        public string Nottxt { get; set; }
        public DateTime CreateDte { get; set; }
    }
}
