// using System;
// using System.Collections.Generic;

// class AnagramChecker
// {
//     private string targetWord;

//     public AnagramChecker(string targetWord)
//     {
//         this.targetWord = targetWord.ToLower(); // Convert to lowercase for case-insensitive comparison
//     }

//     public List<string> FindAnagrams(List<string> wordList)
//     {
//         List<string> anagrams = new List<string>();

//         foreach (string word in wordList)
//         {
//             if (IsAnagram(word.ToLower()) && !targetWord.Equals(word.ToLower()))
//             {
//                 anagrams.Add(word);
//             }
//         }

//         return anagrams;
//     }

//     public List<string> FindPartialAnagrams(List<string> wordList)
//     {
//         List<string> partialAnagrams = new List<string>();

//         foreach (string word in wordList)
//         {
//             if (IsPartialAnagram(word.ToLower()) && !targetWord.Equals(word.ToLower()))
//             {
//                 partialAnagrams.Add(word);
//             }
//         }

//         return partialAnagrams;
//     }

//     private bool IsAnagram(string word)
//     {
//         char[] chars1 = targetWord.ToCharArray();
//         char[] chars2 = word.ToCharArray();

//         Array.Sort(chars1);
//         Array.Sort(chars2);

//         return ArraysAreEqual(chars1, chars2);
//     }

//     private bool IsPartialAnagram(string word)
//     {
//         // Check if all characters in the target word are present in the input word
//         foreach (char c in targetWord)
//         {
//             if (word.IndexOf(c) == -1)
//             {
//                 return false;
//             }
//         }

//         return true;
//     }

//     private bool ArraysAreEqual<T>(T[] array1, T[] array2)
//     {
//         return array1.Length == array2.Length && Array.TrueForAll(array1, item => Array.Exists(array2, item2 => item.Equals(item2)));
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter a single word:");
//         string targetWord = Console.ReadLine().ToLower();

//         Console.WriteLine("Enter a list of words separated by spaces:");
//         List<string> wordList = new List<string>(Console.ReadLine().Split(' '));

//         AnagramChecker anagramChecker = new AnagramChecker(targetWord);

//         List<string> anagrams = anagramChecker.FindAnagrams(wordList);
//         List<string> partialAnagrams = anagramChecker.FindPartialAnagrams(wordList);

//         Console.WriteLine("\nAnagrams found:");
//         PrintList(anagrams);

//         Console.WriteLine("\nPartial Anagrams found:");
//         PrintList(partialAnagrams);
//     }

//     static void PrintList(List<string> list)
//     {
//         foreach (var item in list)
//         {
//             Console.Write(item + " ");
//         }
//         Console.WriteLine();
//     }
// }
