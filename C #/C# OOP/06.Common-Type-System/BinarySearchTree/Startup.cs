namespace BinarySearchTree
{
    using System;

    public class Startup
    {
        public static void Main()
        {

                var bst = new BinarySearchTree<int>();

                for (int i = 0; i < 20; i++)
                {
                    bst.Insert(i + 1);
                }

                Console.WriteLine("Initially: {0}", bst);
                bst.BalanceTree();

                Console.WriteLine("Balanced: {0}", bst);
                Console.WriteLine("Traverse and print (DFS)");
                bst.TraverseDFS();

                var bst2 = new BinarySearchTree<int>();
                for (int i = 0; i < 20; i++)
                {
                    bst2.Insert(i + 1);
                }
                bst2.BalanceTree();
                Console.WriteLine("Second tree (balanced): {0}", bst2);

                Console.WriteLine("First tree equals second tree? {0}", bst.Equals(bst2));

                var bst3 = (BinarySearchTree<int>)bst2.Clone();
                Console.WriteLine("Third tree, cloned from second: {0}", bst3);
                Console.WriteLine("Traverse and print cloned tree (DFS)");
                bst3.TraverseDFS();
            }
        }
    }