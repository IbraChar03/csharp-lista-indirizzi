namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Indirizzo> indirizzi = new List<Indirizzo>();
            List<Indirizzo> indirizziNonValidi = new List<Indirizzo>();

            try
            {
                StreamReader testo = File.OpenText("c:\\addresses.csv");
                while(!testo.EndOfStream)
                {
                    string riga = testo.ReadLine();
                   
                    var arrayIndirizzo = riga.Split(",");
                  
                    if(arrayIndirizzo.Length != 6)
                    {
                        Indirizzo indirizzoNonValido = new Indirizzo();

                        indirizziNonValidi.Add(indirizzoNonValido);
                    }
                    else
                    {
                        Indirizzo indirizzo = new Indirizzo((arrayIndirizzo[0] == "" ) ? "Non definito" : arrayIndirizzo[0], (arrayIndirizzo[1] == "") ? "Non definito" : arrayIndirizzo[1], (arrayIndirizzo[2] == "" ) ? "Non definito" : arrayIndirizzo[2], (arrayIndirizzo[3] == "" ) ? "Non definito" : arrayIndirizzo[3], (arrayIndirizzo[4] == "") ? "Non definito" : arrayIndirizzo[4], (arrayIndirizzo[5] == "") ? "Non definito" : arrayIndirizzo[5]);

                        indirizzi.Add(indirizzo);
                    }
                   
                 
                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            foreach(Indirizzo ind in indirizzi)
            {
                
                Console.WriteLine("INDIRIZZO");
                Console.WriteLine($"Nome : {ind.Nome}");
                Console.WriteLine($"Cognome : {ind.Cognome}");
                Console.WriteLine($"Via : {ind.Via}");
                Console.WriteLine($"Città : {ind.Città}");
                Console.WriteLine($"Provincia : {ind.Provincia}");
                Console.WriteLine($"Cap : {ind.Cap}");
              
                
            }
            foreach (Indirizzo ind in indirizziNonValidi)
            {

                Console.WriteLine("Indirizzo non valido");
               
            }

        }
    }
}