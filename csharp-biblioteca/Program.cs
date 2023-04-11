using System;
using System.Reflection.Metadata;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //::::UTENTI :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            Utente utente1 = new Utente("keller", "marika", "Marikakeller92@gmail.com", "password1", "3334824545");

            List<Utente> Utenti = new List<Utente>();
            Utenti.Add(utente1);


        //::::DOCUMENTI:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            Libro libro1 = new Libro(128, "Il Bambino,La Talpa,La Volpe e Il Cavallo", 2020, "infanzia", "Charlie Mackesy");

            Libro libro2 = new Libro(1233, "Il Conte Di Montecristo", 1844, "storico", "Alexandre Dumas");

            Libro libro3 = new Libro(1233, "Buffy L'ammazzavampiri 12", 2023, "urban-Fantasy", "Joss Whedon");

            DVD dvd1 = new DVD(360, "Il Conte Di Montecristo", 1998, "storico", "Josée Dayan");
            DVD dvd2 = new DVD(360, "The Big Whale", 2023, "drammatico", "Darren Aronofsky");

            List<Documento> Documenti = new List<Documento>();
            Documenti.Add(libro1);
            Documenti.Add(libro2);
            Documenti.Add(libro3);
            Documenti.Add(dvd1);
            Documenti.Add(dvd2);

            foreach (var Doc in Documenti)
            {
                Console.WriteLine(Doc.codice);
                Console.WriteLine(Doc.titolo);
                Console.WriteLine("...................");
            }


            //:::::::RICERCA:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            var documentoTrovato1=  Documenti.Find(documento => documento.titolo == "Il Conte Di Montecristo");
            Console.WriteLine(documentoTrovato1.scaffale);

            //var documentoTrovato2 = Documenti.Find(documento => documento.codice == Documenti [Documenti.IndexOf(dvd1)].codice; //sta roba non si fa così
           
      
            //::::::PRESTITI::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

            List <Documento>DocumentiPrestito1= new List<Documento>();
            DocumentiPrestito1.Add(documentoTrovato1);

            var data_corrente = new DateTime(2023, 04, 11);

              Prestito prestito1= new Prestito(utente1.getUser(), data_corrente, data_corrente.AddMonths(1), DocumentiPrestito1);


            foreach (var doc in prestito1.Documenti)
            {
                Console.WriteLine("PRESO A PRESTITO: " + doc.titolo);
            }
            List<Prestito> Prestiti = new List<Prestito>();
            Prestiti.Add(prestito1);


            var prestitotoTrovato1 = Prestiti.Find(prestito => (prestito.Utente.Contains("marika") || prestito.Utente.Contains("keller")));

            Console.WriteLine(prestitotoTrovato1.Utente);
        
            foreach (var doc in prestitotoTrovato1.Documenti)
            {
                Console.WriteLine("PRESO A PRESTITO: " + doc.titolo);
            }

            Bibilioteca MyBiblioteca= new Bibilioteca("Biblioteca Comunale Delfini", "Corso Canalgrande, 103, 41121 Modena MO", Utenti,Documenti,Prestiti);

            Console.WriteLine("UTENTI IN BIBLIOTECA:::::::::::::::::::::::::::::");
            foreach (var utente in MyBiblioteca.Utenti)
            {
                Console.WriteLine(utente.getUser);
            }
            Console.WriteLine("DOCUMENTI IN BIBLIOTECA:::::::::::::::::::::::::::");
            foreach (var Doc in MyBiblioteca.Documenti)
            {
                Console.WriteLine(Doc.titolo);
            }
            Console.WriteLine("PRESTITI IN BIBLIOTECA:::::::::::::::::::::::::::");
            foreach (var prestito in MyBiblioteca.Prestiti)
            {
                Console.WriteLine(prestito.Utente + " HA PRESO:");
                foreach(var doc in prestito.Documenti)
                {
                    Console.WriteLine(doc.titolo);
                }
            }




        }

    }
}