using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class WordChanger
    {
        public static Dictionary<string, char[]> mainWordDictionary = new Dictionary<string, char[]>(){ };
        public static Dictionary<string, char[]> listDictionary = new Dictionary<string, char[]>(){ };

        public static char[] ChangeWordToArray(string userInput)
        {
            string newWord = userInput.ToLower();
            char[] wordArray = newWord.ToCharArray();
            Array.Sort(wordArray);
            return wordArray;
        }

        public static void StoreMainWord(string mainword)
        {
            char[] wordArray = WordChanger.ChangeWordToArray(mainword);
            mainWordDictionary.Add(mainword, wordArray);
        }

        public static void StoreListWords(string listWord)
        {
            char[] wordArray = WordChanger.ChangeWordToArray(listWord);
            listDictionary.Add(listWord, wordArray);
        }



        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Learn
    
    // public string TargetWord { get; set; } = "bread";

    //     // private List<MyAnagrams> _anagramInstances = new List<MyAnagrams>() {};

    //     // public string[] ArrWords {get; set;} = {"dear", "red"};
    
    
    //     public MyAnagrams(string myWord)
    //     {
    //         myWord = TargetWord.ToLower();

    //     }

    //     // A List method that takes in a list and determines if an anagram can be created

    //      public List<string> FindAnagrams(List<string> wordList)
    //     {
    //         List<string> anagrams = new List<string>();

    //         foreach (string word in wordList)
    //         {
    //             if (IsAnagram(word.ToLower()) && !TargetWord.Equals(word.ToLower()))
    //             {
    //                 anagrams.Add(word);
    //             }
    //         }

    //         return anagrams;
    //     }

    //       public List<string> FindPartialAnagrams(List<string> wordList)
    // {
    //     List<string> partialAnagrams = new List<string>();

    //     foreach (string word in wordList)
    //     {
    //         if (IsPartialAnagram(word.ToLower()) && !TargetWord.Equals(word.ToLower()))
    //         {
    //             partialAnagrams.Add(word);
    //         }
    //     }

    //     return partialAnagrams;
    // }

    // private bool IsAnagram(string word)
    // {
    //     char[] chars1 = TargetWord.ToCharArray();
    //     char[] chars2 = word.ToCharArray();

    //     Array.Sort(chars1);
    //     Array.Sort(chars2);

    //     return ArraysAreEqual(chars1, chars2);
    // }

    // private bool IsPartialAnagram(string word)
    // {
    //     // Check if all characters in the target word are present in the input word
    //     foreach (char c in TargetWord)
    //     {
    //         if (word.IndexOf(c) == -1)
    //         {
    //             return false;
    //         }
    //     }

    //     return true;
    // }

    // private bool ArraysAreEqual<T>(T[] array1, T[] array2)
    // {
    //     return array1.Length == array2.Length && Array.TrueForAll(array1, item => Array.Exists(array2, item2 => item.Equals(item2)));
    // }
        
    
    }

}