﻿//------------------------------------------------------------------------------
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
    
    public partial class Livraison
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Livraison()
        {
            this.composer = new HashSet<composer>();
        }
    
        public long IdentifiantLieuDeLivraison { get; set; }
        public Nullable<bool> LivraisonPartielle { get; set; }
        public Nullable<System.DateTime> DateDeLivraison { get; set; }
        public Nullable<long> NumeroDeLivraison { get; set; }
        public string BonDeLivraison { get; set; }
        public Nullable<long> IdentifiantCommande { get; set; }
    
        public virtual Commande Commande { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<composer> composer { get; set; }
    }
}


