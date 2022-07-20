using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder s = new StringBuilder("Omkar");

            s.Append(" Gorhe");
            s.AppendLine("Mumbai");
            s.Remove(11, 6);
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
