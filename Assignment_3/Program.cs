using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Assignment_3
{

    class Program
    {
        static void Main(string[] args)
        {

            TweetManager.ShowAll();
            Console.WriteLine("Enter category: ");
            string category = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------");
            TweetManager.ShowAll(category);
            TweetManager.ConvertToJson();

        }
    }
}
