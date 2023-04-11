using csharp_biblioteca;

public class Bibilioteca
{
    public string Nome { get; set; }
    public string Indirizzo { get; set; }

    public List<Utente> Utenti { get; set; }
    public List<Documento> Documenti { get; set; }
    public List<Prestito> Prestiti { get; set; }



    public Bibilioteca(string nome, string indirizzo, List<Utente> utenti, List<Documento> documenti, List<Prestito> prestiti)
    {
        this.Nome = nome;
        this.Indirizzo = indirizzo;
        this.Utenti = utenti;
        this.Documenti = documenti;
        this.Prestiti = prestiti;
    }
}
