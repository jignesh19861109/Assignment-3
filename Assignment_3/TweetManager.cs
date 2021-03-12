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
    class TweetManager
    {
        private static Tweet[] tweets;
        private static string fileName = "tweets.txt";

        static TweetManager()
        {
            tweets = new Tweet[File.ReadLines(fileName).Count()];
            StreamReader reader = new StreamReader(fileName);
            string line = reader.ReadLine();
            int index = 0;
            while (line != null)
            {
                tweets[index] = Tweet.Process(line);
                line = reader.ReadLine();
                index += 1;
            }
        }

        public static void ShowAll()
        {
            foreach (Tweet tweet in tweets)
            {
                Console.WriteLine("\nFrom '{0}' To '{1}'    Category: '{2}'\nMessage: {3}\n", tweet.From, tweet.To, tweet.Category, tweet.Message);
            }
            Console.WriteLine("----------------------------------------------------------------");

        }

        public static void ShowAll(string category)
        {
            foreach (Tweet tweet in tweets)
            {
                if (tweet.Category == category)
                {
                    Console.WriteLine("\nFrom '{0}' To '{1}'    Category:'{2}'\nMessage: {3}\n", tweet.From, tweet.To, tweet.Category, tweet.Message);

                }
            }
            Console.WriteLine("----------------------------------------------------------------");
        }

        public static void ConvertToJson()
        {
            StreamWriter writer = new StreamWriter("tweets.json");
            foreach (Tweet tweet in tweets)
            {
                writer.Write(JsonSerializer.Serialize(tweet));
            }
        }

    }


}
