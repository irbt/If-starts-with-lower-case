//Given a string, write a method that checks if each word in the string starts with lower case and if so, removes this letter from the string.
using System;
using System.Collections.Generic;


namespace Program{
    class IfStartsWithLowerCaseTASK{

        public static void IfStartsWithLowerCase (string s){
            
            string [] tab =  s.Split(" ");
            
            for (int i = 0; i < tab.Length; i++)
            {
                string test = tab[i];
                if (Char.IsUpper(test, 0))
                {
                    Console.Write(test + " ");
                }else{
                    string result = test.Substring(1);
                    Console.Write(result);

                }
            }



            
        }
        public static void Main(){
            IfStartsWithLowerCase("Alfa Beta gamma");// → "Alfa Beta amma"

        }
    }
}