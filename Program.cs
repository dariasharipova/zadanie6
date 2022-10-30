
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        // string predlojenie = Console.ReadLine();
        // predlojenie = predlojenie.ToUpper();
        // predlojenie = predlojenie.Replace("А","A");
        // predlojenie = predlojenie.Replace("Б","B");
        // predlojenie = predlojenie.Replace("В","V");
        // predlojenie = predlojenie.Replace("Г","G");
        // predlojenie = predlojenie.Replace("Д","D");
        // predlojenie = predlojenie.Replace("Е","E");
        // predlojenie = predlojenie.Replace("Ё","E");
        // predlojenie = predlojenie.Replace("Ж","ZH");
        // predlojenie = predlojenie.Replace("З","Z");
        // predlojenie = predlojenie.Replace("И","I");
        // predlojenie = predlojenie.Replace("Й","I");
        // predlojenie = predlojenie.Replace("К","K");
        // predlojenie = predlojenie.Replace("Л","L");
        // predlojenie = predlojenie.Replace("М","M");
        // predlojenie = predlojenie.Replace("Н","N");
        // predlojenie = predlojenie.Replace("О","O");
        // predlojenie = predlojenie.Replace("П","P");
        // predlojenie = predlojenie.Replace("Р","R");
        // predlojenie = predlojenie.Replace("С","S");
        // predlojenie = predlojenie.Replace("Т","T");
        // predlojenie = predlojenie.Replace("У","U");
        // predlojenie = predlojenie.Replace("Ф","F");
        // predlojenie = predlojenie.Replace("Х","KH");
        // predlojenie = predlojenie.Replace("Ц","TS");
        // predlojenie = predlojenie.Replace("Ч","CH");
        // predlojenie = predlojenie.Replace("Ш","SH");
        // predlojenie = predlojenie.Replace("Щ","SHCH");
        // predlojenie = predlojenie.Replace("Ъ","IE");
        // predlojenie = predlojenie.Replace("Ы","Y");
        // predlojenie = predlojenie.Replace("Ь","");
        // predlojenie = predlojenie.Replace("Э","E");
        // predlojenie = predlojenie.Replace("Ю","IU");
        // predlojenie = predlojenie.Replace("Я","IA");
        // Console.WriteLine(predlojenie);

        string slovo = "клавиатура";
        string podslovo = slovo.Substring(4);
        Console.WriteLine(slovo[6]+podslovo.Remove(2)+podslovo.Remove(0,4));
        string podslovo2 = slovo.Substring(7);
        Console.WriteLine(slovo[8]+podslovo2.Remove(1)+slovo[0]+slovo.Remove(0,9));
    }

}