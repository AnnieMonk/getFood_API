using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MKuhinja
    {
        public int KuhinjaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<MRestoran> Restoran { get; set; }
    }
}
