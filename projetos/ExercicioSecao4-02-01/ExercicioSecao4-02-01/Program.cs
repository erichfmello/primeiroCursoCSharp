using System;

namespace ExercicioSecao4_02_01 {
    class Program {
        static void Main(string[] args) {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            ret.Altura = double.Parse(Console.ReadLine());
            ret.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(ret.ToString());
        }
    }
}
