using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Anton Kalashnick task 1
            string login = "bionic88";
            byte[] bytes = new byte[192];
            int kol=0;
            for(int i=0; i<47; i++)
            {
              bytes[kol] = (byte)i;
                kol++;
            }
            for(int i=58; i<64; i++)
            {
              bytes[kol] = (byte)i;
                kol++;
            }
            for(int i=91; i<96; i++)
            {
              bytes[kol] = (byte)i;
                kol++;
            }
            for(int i=123; i<255; i++)
            {
              bytes[kol] = (byte)i;
                kol++;
            }
           
            char[] chars = System.Text.Encoding.ASCII.GetChars(bytes);
            
            bool flag = false;
            
            foreach(var item in chars)
            {
                for(int i=0; i<login.Length;i++)
                {
                    if(login[i] == item)
                    {
                        flag = true;   
                    }
                
            }   }
            
            
            if(login.Length >= 2 && login.Length <= 10 && Char.IsDigit((char)login[0]) == false && flag == false)

                Console.WriteLine("Данный логин - {0}, вполне корректен", login);
            
            else

                Console.WriteLine("Логин не корректен");

            Console.ReadLine();

            #endregion

            #region Anton Kalashnick task 2

            

        public static class MyString {

   
            public static List < string > Short(string message, int length) {
                var returnList = new List < string > ();
                    foreach(var s in message.Split(' ')) {
                    if (length > s.Length) returnList.Add(s);
                    }
                        return returnList;
            }
	  
   
        public static List < string > RemoveEndsLetter(string message, char letter) {
            var returnList = new List < string > ();
                foreach(var s in message.Split(' ')) {
                    if (!s.EndsWith(letter.ToString())) returnList.Add(s);
                }
                    return returnList;
        }
  
        public static string LongWord(string message) {
            var words = message.Split(' ');
            var longWord = "";
            foreach(var word in words) {
                if (word.Length > longWord.Length) longWord = word;
            }
                return longWord;
    }
   
            public static StringBuilder LongWords(string message) {
            var long_Words = new List < string > ();
            var lengthOfTheLongWord = 0;
            var words = message.Split(' ');
            StringBuilder sb = new StringBuilder();

                foreach(var word in words) {
                    if (word.Length > lengthOfTheLongWord) lengthOfTheLongWord = word.Length;
                }
                    foreach(var word in words) {
                    if (word.Length == lengthOfTheLongWord) long_Words.Add(word);
                    }
                        return sb;
            }





             static void Main(string[] args) {
    
                Console.WriteLine("Текст для обработки:");
                var bigString = "Многие думают, что Lorem Ipsum - взятый с потолка псевдо-латинский набор слов, но это не совсем так. Его корни уходят в один фрагмент классической латыни 45 года н.э., то есть более двух тысячелетий назад.";


                Console.WriteLine(bigString);
                Console.WriteLine("\n\nВывод слов, которые короче 4 символов:");
                foreach(var s in MyString.Short(bigString, 4)) {
                Console.WriteLine(s);
                }

                    Console.WriteLine("\nВывод слов, которые не заканчиваются на букву е: " + " ;");
                    foreach(var s in MyString.RemoveEndsLetter(bigString, 'е')) {
                    Console.Write(s + "; ");
                    }


                    Console.WriteLine("\n\nСамые длинные слова:");
	   
                    Console.WriteLine(MyString.LongWords(bigString).ToString());

                    Console.ReadLine();
             }
        }



    }

}
            
              
            

            

            

            #endregion
            
        }
    }
}
