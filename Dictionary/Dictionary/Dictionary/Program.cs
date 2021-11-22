using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> phonebook = new Dictionary<string, long>();
            phonebook.Add("John", 9133161234);
            phonebook["Bob"] = 9133164321;

            phonebook.Remove("John");


            // Console.WriteLine(phonebook["John"]);
            Console.WriteLine(phonebook.Count);
            Console.ReadLine();

        }
    }
}
