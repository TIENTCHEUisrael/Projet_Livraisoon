using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_Livraison.Model
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public int Phone_number { get; set; }
        public ClientModel()
        {

        }

        public ClientModel(int id, string nom, int phone_number)
        {
            Id = id;
            Nom = nom;
            Phone_number = phone_number;
        }
    }
}
