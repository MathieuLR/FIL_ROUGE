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
    
    public partial class composer
    {
        public Nullable<long> quantite_livrer { get; set; }
        public Nullable<decimal> PrixVendu { get; set; }
        public long IdentifiantProduit { get; set; }
        public long IdentfiantLieuDeLivraison { get; set; }
    
        public virtual Livraison Livraison { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
