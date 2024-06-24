using BinaryTree;

namespace Assignment7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int searchFor = 7;
            var binaryTree = new BinaryTree<int>() { 8, 5, 12, 3, 7, 10, 15 };

            if( binaryTree.Contains(searchFor) )
            {
                Console.WriteLine($"Tree contains {searchFor}");
            }
            else
            {
                Console.WriteLine($"Tree does not contain {searchFor}");
            }
        }
    }
}
