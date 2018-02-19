using System;
using System.Collections.Generic;

namespace RestClient.Models
{
    public partial class OrderNotes
    {
        public string ClientId { get; set; }
        public string Ordnum { get; set; }
        public string Nottyp { get; set; }
        public string Notlin { get; set; }
        public string Nottxt { get; set; }
        public DateTime CreateDte { get; set; }
    }
}
