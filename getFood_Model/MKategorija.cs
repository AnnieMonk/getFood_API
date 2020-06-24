using System;
using System.Collections.Generic;
using System.Text;

namespace getFood_Model
{
    public class MKategorija
    {
        public int KategorijaId { get; set; }
        public string Naziv { get; set; }

        public virtual ICollection<MMeniKategorija> MeniKategorija { get; set; }
    }
}
