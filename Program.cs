using System;

namespace C_EDX
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinksMachine myMachine = new DrinksMachine("kitchen", "make", "DM1000");
            Console.WriteLine(myMachine.Location);
            Console.WriteLine(myMachine.Make);
            Console.WriteLine(myMachine.Model);
            Console.WriteLine(myMachine.Model);
            myMachine.MakeCappuccino();
        }
    }
}
