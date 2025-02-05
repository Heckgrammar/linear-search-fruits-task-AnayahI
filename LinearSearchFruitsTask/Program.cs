namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {// Linear Search Homework
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("What word would you like to find?");
            string value = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < fruits.Length; i++) 
            {
                if (value == fruits[i])
                {
                    found = true;
                }
            }
            if (found == true) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }
    }
}
