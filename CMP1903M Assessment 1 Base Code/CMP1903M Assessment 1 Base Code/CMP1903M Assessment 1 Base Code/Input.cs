using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        public string text;
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.WriteLine("Please input your text: ");
            text = Console.ReadLine();
            if (text == null)
            {
                Console.WriteLine("invalid input");
            }
            else
            {
                
            }
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            try
            {
                text = System.IO.File.ReadAllText(fileName);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("this file cannot be found");
            }
            catch (IOException)
            {
                Console.WriteLine("this file is in use");
            }
            
            return text;
        }

    }
}
