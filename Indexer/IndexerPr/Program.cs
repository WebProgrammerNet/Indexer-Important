using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerPr
{
    class Program
    {
       

        static void Main(string[] args)
        {
                      Student cavid = new Student("Cavid", "Basirov");
            Group p111 = new Group("P111", 17);
            p111[0] = cavid;
            // Console.WriteLine(p111[0]);
            string result = p111.ToString();
            Console.WriteLine(result);

            
            Console.ReadLine();
        }
    }
}


