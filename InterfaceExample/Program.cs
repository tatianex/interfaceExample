using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Porco porco = new Porco();  // cria um objeto Porco
            Cobra cobra = new Cobra();  // cria um objeto Cobra

            porco.Som();
            porco.Locomover();
            porco.TomarBanhoNaLama();

            cobra.Som();
            cobra.Locomover();
            cobra.TomarBanhoNaAreia();

            Console.ReadLine();
            
        }
        interface IAnimal
        {
            void Som();  // método interface, sem implementação
            void Locomover();  // método interface, sem implementação
        }
        class Porco : IAnimal
        {
            public void Som()
            {
                // A implementação, o código do método som() é criado aqui
                Console.WriteLine("O porco fala oinc! oinc!");
            }
            public void Locomover()
            {
                // A implementação, o código do método locomover() é criado aqui
                Console.WriteLine("O porco se locomove por quatro patas.");
            }
            public void TomarBanhoNaLama()
            {
                Console.WriteLine("O porco toma banho na lama.\n");
            }
        }

        class Cobra : IAnimal
        {
            public void Som()
            {
                // A implementação, o código do método som() é criado aqui
                Console.WriteLine("A cobra fala s...sss..s!");
            }
            public void Locomover()
            {
                // A implementação, o código do método locomover() é criado aqui
                Console.WriteLine("A cobra se locomove se rastejando.");
            }
            public void TomarBanhoNaAreia()
            {
                Console.WriteLine("A cobra toma banho na areia.\n");
            }

        }
    }
}
