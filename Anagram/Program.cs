// =bn

using System;
using System.Collections.Generic;
using System.Linq;
using Anagram.Models;

namespace Anagram

{
    class Program
    {
        static void Main()
        {



            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Hello. Type in a word:");
            string mainword = Console.ReadLine();
            WordChanger.StoreMainWord(mainword);
            Console.WriteLine("Now, enter in 3 words that you think is an anagram and our program will check it");
            Console.WriteLine("Enter a word:");
            string word1 = Console.ReadLine();
            WordChanger.StoreListWords(word1);
            Console.WriteLine("Enter a word:");
            string word2 = Console.ReadLine();
            WordChanger.StoreListWords(word2);
            Console.WriteLine("Enter a word:");
            string word3 = Console.ReadLine();
            WordChanger.StoreListWords(word3);
            Console.WriteLine($"These are the words that were an anagram for {mainword}");
            // List<string> keys = new List<string> { };
            foreach (KeyValuePair<string, char[]> word in WordChanger.listDictionary)
            {
                char[] listArray = word.Value;
                char[] mainArray = WordChanger.mainWordDictionary[mainword];
                if (listArray.SequenceEqual(mainArray) == true)
                {
                    Console.WriteLine($"{word.Key} IS AN ANAGRAM!");
                }
                else
                {
                    Console.WriteLine($"{word.Key} is not an anagram for {mainword}!");
                }
            }



            // Console.WriteLine("Enter a single word:");
            // string targetWord = Console.ReadLine().ToLower();

            // Console.WriteLine("Enter a list of words separated by spaces:");
            // List<string> wordList = new List<string>(Console.ReadLine().Split(' '));

            // MyAnagrams myAnagram = new MyAnagrams(targetWord);

            // List<string> anagrams = myAnagram.FindAnagrams(wordList);
            // List<string> partialAnagrams = myAnagram.FindPartialAnagrams(wordList);

            // foreach (var item in list)
            //     {
            //         Console.WriteLine(item + " ");
            //     }
            //     Console.WriteLine();

            // Console.WriteLine("\nAnagrams found:");
            // PrintList(anagrams);

            // Console.WriteLine("\nPartial Anagrams found:");
            // PrintList(partialAnagrams);

            // static void PrintList(List<string> list)
            // {
            //     foreach (string item in list)
            //     {
            //         Console.Write(item + " ");
            //     }
            //     Console.WriteLine();
            // }



            // Example with an array of integers
            // int[] intArray = { 5, 2, 8, 1, 3 };
            // Console.WriteLine("Original array of integers:");
            // PrintArray(intArray);

            // Array.Sort(intArray);
            // Console.WriteLine("\nSorted array of integers:");
            // PrintArray(intArray);

    //         // Example with an array of strings
    //         string[] stringArray = { "apple", "orange", "banana", "grape", "kiwi" };
    //         Console.WriteLine("\nOriginal array of strings:");
    //         PrintArray(stringArray);

    //         Array.Sort(stringArray);
    //         Console.WriteLine("\nSorted array of strings:");
    //         PrintArray(stringArray);

    //         // Example with an array of custom objects
    //         Person[] peopleArray = {
    //             new Person("John", 25),
    //             new Person("Alice", 30),
    //             new Person("Bob", 22),
    //             new Person("Eve", 28)
    //         };
    //         Console.WriteLine("\nOriginal array of custom objects:");
    //         PrintArray(peopleArray);

    //         // Sorting based on the custom comparison (by age)
    //         Array.Sort(peopleArray, (p1, p2) => p1.Age.CompareTo(p2.Age));
    //         Console.WriteLine("\nSorted array of custom objects by age:");
    //         PrintArray(peopleArray);
    //     }

        // static void PrintArray<T>(T[] array)
        // {
        //     foreach (var item in array)
        //     {
        //         Console.Write(item + " ");
        //     }
        //     Console.WriteLine();
        // }
    // }

    // class Person
    // {
    //     public string Name { get; set; }
    //     public int Age { get; set; }

    //     public Person(string name, int age)
    //     {
    //         Name = name;
    //         Age = age;
    //     }

    //     public override string ToString()
    //     {
    //         return $"{Name} ({Age} years old)";
    //     }


   
    //     Console.WriteLine("Enter a single word:");
    //     string inputWord = Console.ReadLine().ToLower(); // Convert to lowercase for case-insensitive comparison

    //     Console.WriteLine("Enter a list of words separated by spaces:");
    //     string[] wordList = Console.ReadLine().Split(' ');

    //     List<string> anagrams = FindAnagrams(inputWord, wordList);

    //     Console.WriteLine("\nAnagrams found:");
    //     foreach (string anagram in anagrams)
    //     {
    //         Console.WriteLine(anagram);
    //     }
    

    // static List<string> FindAnagrams(string inputWord, string[] wordList)
    // {
    //     List<string> anagrams = new List<string>();

    //     foreach (string word in wordList)
    //     {
    //         if (IsAnagram(inputWord, word.ToLower()) && !inputWord.Equals(word.ToLower()))
    //         {
    //             anagrams.Add(word);
    //         }
    //     }

    //     return anagrams;
    // }

    // static bool IsAnagram(string word1, string word2)
    // {
    //     char[] chars1 = word1.ToCharArray();
    //     char[] chars2 = word2.ToCharArray();

    //     Array.Sort(chars1);
    //     Array.Sort(chars2);

    //     return Enumerable.SequenceEqual(chars1, chars2);
    // }
        }
    
    }
}