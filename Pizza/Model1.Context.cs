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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PizzaEntities : DbContext
    {
        public PizzaEntities()
            : base("name=PizzaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<BonLiv> BonLiv { get; set; }
        public virtual DbSet<CataloguePizza> CataloguePizza { get; set; }
        public virtual DbSet<CdeClient> CdeClient { get; set; }
        public virtual DbSet<CLIENT> CLIENT { get; set; }
        public virtual DbSet<Fabrication> Fabrication { get; set; }
        public virtual DbSet<Facture_Client_BonLiv> Facture_Client_BonLiv { get; set; }
        public virtual DbSet<LignesCdeClient> LignesCdeClient { get; set; }
        public virtual DbSet<Livraison> Livraison { get; set; }
        public virtual DbSet<Livreur> Livreur { get; set; }
        public virtual DbSet<Paiement_Fact_Client> Paiement_Fact_Client { get; set; }
        public virtual DbSet<Quartier> Quartier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
