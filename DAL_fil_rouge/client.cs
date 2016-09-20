using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_fil_rouge
{
    public class client
    {
        public Int64 IdentifiantClient { get; set; }
        public Nullable<Int64> ReferenceDuClient { get; set; }
        public string NomDuClient { get; set; }
        public string PrenomDuClient { get; set; }
        public Nullable<Int64> Coefficient { get; set; }
        public string AdresseDuClient { get; set; }
        public string VilleDuClient { get; set; }
        public Nullable<Int64> CodePostalDuClient { get; set; }
        public string AdresseMailDuClient { get; set; }
        public Nullable<Int64> TelephoneDuClient { get; set; }
        public Nullable<Int64> IdentifiantServiceCommercial { get; set; }
        public Nullable<Int64> NumeroSiret { get; set; }
        public string NomEnseigne { get; set; }
        public string ComplementAdresse { get; set; }

        public string Affichage { get; set; }
        public string AffichageTotal { get; set; }
        public string AdresseDeLivraisonClient { get; set; }
        public string VilleDeLivraisonClient { get; set; }
        public string ComplementAdresseClient { get; set; }
        public string CodePostalDeLivraisonClient { get; set; }
        public bool ClientParticulier { get; set; }
        public bool Sexe { get; set; }
        public bool ClientActif { get; set; }
        





    }
}
