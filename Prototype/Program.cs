using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two instances and clone each
            Telo T1 = new Telo(10, "ggg");
            System s1 = new ConcretePrototype1(T1);
            System c1 = s1.Clone();

            c1.SsS.DLINA = 8;
            c1.SsS.NAME = "rrrrrr";

            Console.WriteLine("Dlina: {0} Name: {1}", c1.SsS.DLINA, c1.SsS.NAME);

            Console.WriteLine("Dlina: {0} Name: {1}", s1.SsS.DLINA, s1.SsS.NAME);

            Telo T2 = new Telo(50, "hohoho");
            System s2 = new ConcretePrototype2(T2);
            System c2 = s2.Clone();

            c2.SsS.DLINA = 25;
            c2.SsS.NAME = "zozozo";

            Console.WriteLine("Dlina: {0} Name: {1}", c2.SsS.DLINA, c2.SsS.NAME);

            Console.WriteLine("Dlina: {0} Name: {1}", s2.SsS.DLINA, s2.SsS.NAME);


            // Wait for user
            Console.Read();
        }
    }
}
