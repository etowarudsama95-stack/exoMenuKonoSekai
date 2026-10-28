namespace exoMenuKonoSekai;

class Program
{
    static void Main(string[] args)
    {

        string? choix;
        do
        {
            Console.WriteLine("===== MENU KONOSEKAI =====");
            Console.WriteLine("1. Voir l'energie");
            Console.WriteLine("2. s'entrainer");
            Console.WriteLine("3. Partir en Mission");
            Console.WriteLine("0. Quitter");

            Console.Write("choix :");
            choix = Console.ReadLine();


        }
        while (choix != "0");
    }
}