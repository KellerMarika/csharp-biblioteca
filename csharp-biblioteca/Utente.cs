using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente
    {
        public string cognome { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string recapito_telefonico { get; set; }

        //private static int _contatore;
        //public static int contatore
        //{
        //    get { return _contatore; }
        //    set
        //    {
        //        _contatore = value;
        //    }
        //}

        //public void stampaContatore()
        //{
        //    Console.WriteLine(User.contatore);
        //}

        public Utente(string cognome, string nome, string email,  string password, string recapito_telefonico) {
      
            this.cognome = cognome;
            this.nome = nome;
            this.email = email;
            this.password = password;
            this.recapito_telefonico = recapito_telefonico;
        }

        public string getUser()
        {
            return this.cognome+ " " + this.nome;
        }
    }
}


