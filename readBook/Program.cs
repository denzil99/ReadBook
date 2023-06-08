using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Denzil\\Desktop\\Text1.txt";
            Stopwatch sw = new Stopwatch();
            StreamReader sr = new StreamReader(path);
            List<string> list = new List<string>();
            LinkedList<string> lList = new LinkedList<string>();

            var txt = sr.ReadToEnd();
            string[] words = txt.Split(new char[] { ' ',  '\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            sw.Start();

            foreach (string word in words)
            {
                list.Add(word);
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.ToString());

            sw.Restart();

            foreach (string word in words)
            {
                lList.AddLast(word);
            }

            sw.Stop();

            Console.WriteLine(sw.Elapsed.ToString());

            Console.ReadKey();
        }
    }
}
