using System;
using System.Text;

namespace ConsoleUtilities
{
    internal interface IConsoleUtilities
    {
        public void Write(string stringInput);
        public void Write(string[] arrayInput);
        public string Read();
               
    }
    public class ConsoleTools: IConsoleUtilities
    {
        public void Write(string stringText)
        {
            ConsoleOutput.WritetoConsole(stringText);                
        }
        public void Write(string[] arrayInput)
        {
            ConsoleOutput.WritetoConsole(arrayInput);
        }
        public string Read()
        {
            string input = ConsoleInput.ReadInput();
            return input;
        }
    }
    internal static class ConsoleInput
    {
        public static string ReadInput()
        {
            return Console.ReadLine();
        }
    }
    
        internal static class ConsoleOutput { 
        public static void WritetoConsole(string stringInput)
        {
            StringBuilder sb = SbUtilities.StringBuilderFactory(stringInput);
            Console.WriteLine(sb);
        }
        public static void WritetoConsole(string[] arrayInput)
        {
            StringBuilder sb = SbUtilities.StringBuilderFactory(arrayInput);

            Console.WriteLine(sb);
        }
    }

    internal static class SbUtilities
    {
        internal static StringBuilder AddArraytoStringBuilder(StringBuilder objStringBuilder, string[] arrString)
        {
            foreach (string strStringElement in arrString)
            {
                objStringBuilder.Append(" " + strStringElement);
            }
            return objStringBuilder;
        }
        public static StringBuilder StringBuilderFactory(string strText)
        {
            int intStringLength = strText.Length;
            StringBuilder StringBuilder = new StringBuilder(strText, intStringLength);
            return StringBuilder;
        }
        public static StringBuilder StringBuilderFactory(string[] arrText)
        {
            StringBuilder StringBuilderObject = new StringBuilder();
            StringBuilderObject = AddArraytoStringBuilder(StringBuilderObject, arrText);
            return StringBuilderObject;
        }

    }
}
