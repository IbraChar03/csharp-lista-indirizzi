namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {


            try
            {
                StreamReader testo = File.OpenText("c:\\addresses.csv");
                while(!testo.EndOfStream)
                {
                    string riga = testo.ReadLine();
                    var splitTesto = riga.Split(",");


                }

            }
            catch { 
            }

        }
    }
}