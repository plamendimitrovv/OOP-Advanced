using System;

namespace Generic_Scale
{
    public class Program
    {
        static void Main(string[] args)
        {

            var scale = new Scale<int>(18, 8);
            var scale2 = new Scale<string>("a2bd", "abd");
            var scale3 = new Scale<double>(1.01, 0.5);

            Console.WriteLine(scale.GetHeavier());
            Console.WriteLine(scale2.GetHeavier());
            Console.WriteLine(scale3.GetHeavier());


        }
    }
}
