using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Task_11
{
    class Regular
    {
       
        public Regular(string pattern, string txt)
        {
            r = new Regex(pattern);
            text = txt;
        }
        private Regex r;
        private string text;

        public bool Match_patter()
        {
            return r.IsMatch(text);
        }

        public void Output_on_display()
        {
            MatchCollection m = r.Matches(text);
            foreach (Match x in m)
                Console.Write(x.Value);
        }

        public string Delete()
        {
            MatchCollection m = r.Matches(text);
            string s = text;
            foreach (Match x in m)
            {
                int i = s.IndexOf(x.Value);
                int l = x.Value.Length;
                s = s.Remove(i, l);
            }
            return s;
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public Regex R
        {
            get { return r; }
            set { r = value; }
        }
    

    }
    class Program
    {
        static void Main(string[] args)
        {
            Regular myReg = new Regular("[^.В!]", "Добрый день. Как Ваше настроение? Всего доброго!");
            myReg.Output_on_display();
            myReg.Text = myReg.Delete();
            myReg.Output_on_display();
            Console.ReadKey();
        }
    }
}
 