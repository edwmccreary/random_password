using System;
using System.Text;

namespace random_password.Models
{
    public class Password
    {
        public string code {get;set;} = "";
        public char[] elements = new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z','1','2','3','4','5','6','7','8','9','0'};
        public int numPasswords {get;set;} = 0;

        public void Generate(int length){
            Random rand = new Random();
            StringBuilder password = new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                password.Append(elements[rand.Next(elements.Length)]);
            }
            code = password.ToString();
            numPasswords++;
            Console.WriteLine("code: "+code);
        }
    }
}