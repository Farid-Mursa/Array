using ArrayAddRemove;

namespace Arrayfasfas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] arr = { "Ferid","Salam","Saqol","Hello","NoHello" };
            ArrayHelper.Add(ref arr, "Pirivit");
            ArrayHelper.Add(ref arr, "Pokavet");
            ArrayHelper.Remove(ref arr, "Ferid");

            foreach (string item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}