using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_fil_rouge
{
   public class commande
    {
        public Int64 IdentifiantCommande { get; set; }
        public long NumeroDeCommande { get; set; }
        public DateTime DateDeCommande { get; set; }
        public string AdresseDeLivraison { get; set; }
        public string VilleDeLivraison { get; set; }
        public string CodePostalDeLivraison { get; set; }
        public decimal PrixTotalCommande { get; set; }
        public string AdresseDeFacturation { get; set; }
        public string VilleDeFacturation { get; set; }
       public long CodePostalDeFacturation { get; set; }
        public long IdentifiantClient { get; set; }
        public long NumeroFacture { get; set; }
    }
}
