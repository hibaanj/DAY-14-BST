using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1_adding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Binarytree tree = new Binarytree();
            tree.Add(56);
            tree.Add(30);
            tree.Add(70);

            tree.TravesePreOrder(tree.Root);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}