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
    
    public partial class Livreur
    {
        public int N_Livreur { get; set; }
        public string NomLivreur { get; set; }
        public int N_Quartier { get; set; }
    
        public virtual Quartier Quartier { get; set; }
    }
}
