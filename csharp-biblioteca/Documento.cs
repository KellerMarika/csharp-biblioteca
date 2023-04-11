public class Documento
{
       public string codice { get; set; }
        public string titolo { get; set; }
        public int anno { get; set; }
        public string settore { get; set; }
        public string scaffale { get; set; }
        public string autore { get; set; }

            public Documento(string titolo, int anno, string settore, string autore) {

             for (int i = 0; i < 6; i++)
             {
              this.codice += (new Random().Next(0, 10)).ToString();
             }

             for (int i = 0; i < 3; i++)
             {
             this.scaffale += (new Random().Next(0, 10)).ToString();
             }
             this.scaffale += "/" + settore.Substring(0, 2).ToUpper();


              this.titolo = titolo;
              this.anno = anno;
              this.settore = settore;
              this.autore = autore;
        }
    }
