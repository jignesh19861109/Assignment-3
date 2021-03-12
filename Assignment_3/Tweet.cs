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

    class Tweet
    {

        private static int recentId = 1;

        public int Id { set; get; }
        public string From { set; get; }
        public string To { set; get; }
        public string Message { set; get; }
        public string Category { set; get; }

        public Tweet(string from, string to, string message, string category)
        {
            From = from;
            To = to;
            Message = message;
            Category = category;
            Id = ++recentId;
        }

        public static Tweet Process(string line)
        {
            try
            {
                string[] newLine = line.Split(new char[] { '\t' });
                return new Tweet(newLine[0], newLine[1], newLine[2], newLine[3]);
            }
            catch (IndexOutOfRangeException e)
            {

                Console.WriteLine(e.Message);
                return new Tweet("Invalid", "Invalid", "Invalid", "Invalid");

            }



        }
    }
}
