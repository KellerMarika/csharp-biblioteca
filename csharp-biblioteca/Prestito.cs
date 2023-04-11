public class Prestito
{
    public string Utente { get; set; }
    public DateTime Data_inizio { get; set; }
    public DateTime Data_scadenza { get; set; }
    public List <Documento> Documenti { get; set; }

  

    public Prestito(string utente, DateTime Data_inizio, DateTime Data_scadenza, List <Documento> Documenti )
    {
        this.Utente = utente;
        this.Data_inizio = Data_inizio;
        this.Data_scadenza=Data_scadenza;
        this.Documenti = Documenti;
    }
}
