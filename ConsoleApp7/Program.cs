using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] arra1 = { 1, 2, 3 };
            ArrayList array = new ArrayList(5) ;
            array.Add(1);
            array.Add(48);
            array.Add(56);
            array.Add("salam");
            array.AddRange(arra1);

            array.Remove("salam");
            array.GetAll();

            

        }
    }
}
