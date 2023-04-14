namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Indirizzo> indirizzi = new List<Indirizzo>();


            try
            {
                StreamReader testo = File.OpenText("c:\\addresses.csv");
                while(!testo.EndOfStream)
                {
                    string riga = testo.ReadLine();
                    var splitTesto = riga.Split(",");
                 
                    Indirizzo indirizzo = new Indirizzo((splitTesto[0] == "") ? "Non definito" : splitTesto[0], (splitTesto[1] == "") ? "Non definito" : splitTesto[1], (splitTesto[2] == "") ? "Non definito" : splitTesto[2], (splitTesto[3] == "") ? "Non definito" : splitTesto[3], (splitTesto[4] == "") ? "Non definito" : splitTesto[4], (splitTesto[5] == "") ? "Non definito" : splitTesto[5]);
                    indirizzi.Add(indirizzo);



                }

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            foreach(Indirizzo ind in indirizzi)
            {
                Console.WriteLine("INDIRIZZO :");
                Console.WriteLine($"Nome : {ind.Nome}");
                Console.WriteLine($"Cognome : {ind.Cognome}");
                Console.WriteLine($"Via : {ind.Via}");
                Console.WriteLine($"Città : {ind.Città}");
                Console.WriteLine($"Provincia : {ind.Provincia}");
                Console.WriteLine($"Cap : {ind.Cap}");
            }

        }
    }
}