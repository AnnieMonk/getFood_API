using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model.Requests
{
    public class RestoranSearchRequest
    {

        public int? RestoranId { get; set; }
        public int? KuhinjaId { get; set; }
        public string Naziv { get; set; }
        public int? MinimalnaNarudzba { get; set; }
    }
}
