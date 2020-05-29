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
            MatchCollection m = r.Matches(text);
            foreach (Match x in m)
            {
                return true;
            }
            return false;
        }

        public void Output_on_display()
        {
             MatchCollection m = r.Matches(text);
              foreach (Match x in m)
                  Console.Write(x.Value + "\n\r");
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
            Console.WriteLine(s);
            return s;
        }
        
        public Regex R
        {
            get { return r; }
            set { r = value; }
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Мальчик проснулся в 11:50, а должен был проснуться в 09:00.";
            Console.WriteLine("ТЕКСТ:  " + text + "\n\r");
            string pattern = ("[0-2][0-9]:[0-6][0-9]");
            Console.WriteLine("ШАБЛОН:  " + pattern + "\n\r");
            Regular myReg = new Regular(pattern,text);
            Console.WriteLine("СОДЕРЖИТ ЛИ ТЕКСТ ФРАГМЕНТЫ, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:");
            if (myReg.Match_patter())
            {
                Console.WriteLine("Содержит\n\r");
            }
            else
            {
                Console.WriteLine("Не содержит\n\r");
            }
            Console.WriteLine("ФРАГМЕНТЫ ТЕКСТА, СООТВЕТСТВУЮЩИЕ ШАБЛОНУ ПОЛЯ:");
            myReg.Output_on_display();
            Console.WriteLine();
            Console.WriteLine("УДАЛЕНИЕ ИЗ ТЕКСТА ФРАГМЕНТОВ, СООТВЕТСТВУЮЩИХ ШАБЛОНУ ПОЛЯ:");
            myReg.Text = myReg.Delete();
            myReg.Output_on_display();
            Console.ReadKey();
        }
    }
}
