using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Livraison.Model
{
    public class LivraisonModel
    {
        public int Id_livraison { get; set; }
        public string Reference { get; set; }
        public string Lieu { get; set; }
        public DateTime CreatedAd { get; set; }
        public ClientModel Client { get; set; }

        public LivraisonModel(int id_livraison, string reference, string lieu, DateTime createdAd, ClientModel client)
        {
            Id_livraison = id_livraison;
            Reference = reference;
            Lieu = lieu;
            CreatedAd = createdAd;
            Client = client;
        }
    }
}
