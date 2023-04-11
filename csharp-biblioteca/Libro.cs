
public class Libro : Documento
{
    public int numero_pagine { get; set; }

    public Libro(int numero_pagine, string titolo, int anno, string settore, string autore) : base(titolo, anno,settore, autore)
    {
        this.numero_pagine = numero_pagine;
        this.codice += "LB";
        this.scaffale += "/L";
    }
}
