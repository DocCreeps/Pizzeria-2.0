//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizza
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facture_Client_BonLiv
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facture_Client_BonLiv()
        {
            this.Paiement_Fact_Client = new HashSet<Paiement_Fact_Client>();
        }
    
        public int N_Facture { get; set; }
        public int N_BonLiv { get; set; }
        public System.DateTime Date_Facture { get; set; }
        public decimal Montant_Total { get; set; }
        public Nullable<int> N_Client { get; set; }
    
        public virtual BonLiv BonLiv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paiement_Fact_Client> Paiement_Fact_Client { get; set; }
    }
}
