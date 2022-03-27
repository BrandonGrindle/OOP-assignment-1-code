using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    internal class Longwords
    {
         private List<string> longword = new List<string>();
        public void longwords(string input)
        {
            
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length >= 7)
                {
                    longword.Add(words[i]);
                }
            }
            LongWordFile(longword);
        }

        private static void LongWordFile(List<string> longword)
        {
            Console.WriteLine("please input the filepath(not including txt file) where you would like the word length file to be located: ");
            string filepath = Console.ReadLine();
            Console.WriteLine("please input a file name");
            string filename = Console.ReadLine();
            string filecreator = filepath + "\\" + filename + ".txt";
            try
            {
                using (StreamWriter writer = File.CreateText(filecreator))
                {
                    for (int i = 0; i < longword.Count; i++)
                    {
                        writer.WriteLine(longword[i]);
                    }
                }
                Console.WriteLine("file created!");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("filepath cannot be found");
            }
            catch (FileLoadException)
            {
                Console.WriteLine("filepath cannot be loaded");
            }
   
        }
    }
}
