public class DVD : Documento
{
    public int durata { get; set; }

    public DVD(int durata, string titolo, int anno, string settore, string autore) : base( titolo, anno, settore, autore)
    {
        this.durata = durata;
        this.codice += "DV";
        this.scaffale += "/D";
    }
}