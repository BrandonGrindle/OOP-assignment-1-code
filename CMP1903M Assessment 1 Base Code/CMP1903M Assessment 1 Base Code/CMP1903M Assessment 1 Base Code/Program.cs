//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            Console.WriteLine("would you like to 1. input the text manually or 2. read text from a file?");
            string inputValue = Console.ReadLine();

            try
            {
               if (inputValue == "1")
                {
                    input.manualTextInput();
                }
                else if (inputValue == "2")
                {
                    Console.WriteLine("please input/copy the filepath:");
                    string File = Console.ReadLine();
                    string Filename = File.Trim('"');
                    try
                    {
                        input.fileTextInput(Filename);
                    }
                    catch
                    {
                        Console.WriteLine("invalid file path, please check the file path for any mistakes");
                    }
                }
                else
                {
                    Console.WriteLine("invalid input")
                }
            }
            catch
            {
                Console.WriteLine("invalid input, please try again");
            }

            
            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method
            Analyse analyse = new Analyse();
            Console.WriteLine(input.text);
            analyse.analyseText(input.text);
            
            


            //Receive a list of integers back
            //List<int> value = new List<int>(analyse.values);

            //Report the results of the analysis
            Report results = new Report();
            results.valueOutput(analyse.values, input.text);
            //TO ADD: Get the frequency of individual letters?


        }
        
        
    
    }
}
