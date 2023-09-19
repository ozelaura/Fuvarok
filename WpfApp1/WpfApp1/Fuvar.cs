using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Fuvar
    {
       

        public int TaxiAzonosito { get; set; }
        public DateTime IndulasIdopont { get; set; }
        public int IndulasIdotartam { get; set; }
        public float Tavolsag { get; set; }
        public float Viteldij { get; set; }
        public float Borravalo { get; set; }
        public string FizetesModja { get; set; }

        // taxi_id;indulas;idotartam;tavolsag;viteldij;borravalo;fizetes_modja

        public Fuvar(string sor)
        {
            var sorAdatok = sor.Split(";");
            TaxiAzonosito = int.Parse(sorAdatok[0]);
            IndulasIdopont = DateTime.Parse(sorAdatok[1]);
            IndulasIdotartam = int.Parse(sorAdatok[2]);
            Tavolsag = float.Parse(sorAdatok[3]);
            Viteldij = float.Parse(sorAdatok[4]);
            Borravalo = float.Parse(sorAdatok[5]);
            FizetesModja = sorAdatok[6];
        }
    }
}
