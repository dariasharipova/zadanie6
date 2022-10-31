
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        static string vvod()
        {
            string predlojenie = Console.ReadLine();
            predlojenie = predlojenie.ToUpper();
            return predlojenie;
        }
        static string zamena()
        {
            string perevod = vvod();
            perevod = perevod.Replace("А","A");
            perevod = perevod.Replace("Б","B");
            perevod = perevod.Replace("В","V");
            perevod = perevod.Replace("Г","G");
            perevod = perevod.Replace("Д","D");
            perevod = perevod.Replace("Е","E");
            perevod = perevod.Replace("Ё","E");
            perevod = perevod.Replace("Ж","ZH");
            perevod = perevod.Replace("З","Z");
            perevod = perevod.Replace("И","I");
            perevod = perevod.Replace("Й","I");
            perevod = perevod.Replace("К","K");
            perevod = perevod.Replace("Л","L");
            perevod = perevod.Replace("М","M");
            perevod = perevod.Replace("Н","N");
            perevod = perevod.Replace("О","O");
            perevod = perevod.Replace("П","P");
            perevod = perevod.Replace("Р","R");
            perevod = perevod.Replace("С","S");
            perevod = perevod.Replace("Т","T");
            perevod = perevod.Replace("У","U");
            perevod = perevod.Replace("Ф","F");
            perevod = perevod.Replace("Х","KH");
            perevod = perevod.Replace("Ц","TS");
            perevod = perevod.Replace("Ч","CH");
            perevod = perevod.Replace("Ш","SH");
            perevod = perevod.Replace("Щ","SHCH");
            perevod = perevod.Replace("Ъ","IE");
            perevod = perevod.Replace("Ы","Y");
            perevod = perevod.Replace("Ь","");
            perevod = perevod.Replace("Э","E");
            perevod = perevod.Replace("Ю","IU");
            perevod = perevod.Replace("Я","IA");
            return perevod;
        }
        Console.WriteLine(zamena());

        string slovo = "клавиатура";
        string podslovo = slovo.Substring(4);
        Console.WriteLine(slovo[6]+podslovo.Remove(2)+podslovo.Remove(0,4));
        string podslovo2 = slovo.Substring(7);
        Console.WriteLine(slovo[8]+podslovo2.Remove(1)+slovo[0]+slovo.Remove(0,9));
    }

}