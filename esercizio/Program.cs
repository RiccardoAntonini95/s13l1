namespace esercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Atleta fenomeno = new Atleta();
            fenomeno.nome = "Usain";
            fenomeno.cognome = "Bolt";
            fenomeno.eta = 37;
            fenomeno.centoPiani = 9.58;


            Console.WriteLine($"{fenomeno.nome} {fenomeno.cognome} è un atleta Giamaicano di {fenomeno.eta} anni che corre i 100 mt con la misura record di {fenomeno.centoPiani}!");
        }
    }

    public class Atleta
    {
        public string nome;
        public string cognome;
        public int eta;
        public double centoPiani;

        //public datiAtleta(); 
    }

    public class Dipendente
    {
        public string nome;
        public string cognome;
        public string ruolo;
    }

    public class Animale
    {
        public string nome;
        public string razza;
    }

    public class Veicolo
    {
        public string modello;
        public int velocita;
    }
}
