//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service_Commercial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service_Commercial()
        {
            this.Client = new HashSet<Client>();
        }
    
        public long IdentifiantServiceCommercial { get; set; }
        public string NomDuCommercial { get; set; }
        public string PrenomDuCommercial { get; set; }
        public string AdresseDuCommercial { get; set; }
        public string VilleDuCommercial { get; set; }
        public Nullable<long> CodePostalDuCommercial { get; set; }
        public Nullable<long> TelephoneDuCommercial { get; set; }
        public Nullable<bool> ClientParticulier { get; set; }
        public string AdresseMailDuCommercial { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Client> Client { get; set; }
    }
}
