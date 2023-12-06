using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
    [TestClass]
    public class MyAnagramsTests
    {
        // 1st Test: Ceates Instance of Anagram object
        [TestMethod]
        public void AnagramConstructor_CreatesInstanceOfAnagram_Anagram()
        {
            MyAnagrams newAnagram = new MyAnagrams();
            Assert.AreEqual(typeof(MyAnagrams), newAnagram.GetType());
        }

        // 2nd Test: Getting the word(my public auto-implemented property)
        [TestMethod]
        public void GetWord_ReturnsWord_String()
        {
            // Arrange
            MyAnagrams newAnagram = new MyAnagrams();
            string expectedWord = "bread";

            // Act 
            string returnWord = newAnagram.Word;

            // Assert
            Assert.AreEqual(expectedWord, returnWord);
        }

        // 3rd Test: Setting the word(my public auto-implemented property)
        [TestMethod]
         public void SetWord_SetsWord_String()
        {
            // Arrange
            MyAnagrams newAnagram = new MyAnagrams();
            string myWord = "bread";

            // Act 
            newAnagram.Word = myWord;

            // Assert
            Assert.AreEqual(myWord, newAnagram.Word);
        }

        // 4th Test: 
        [TestMethod]
         public void GetAllAnagrams_ReturnsListOfAnagram_List()
        {
            // Arrange
            MyAnagrams newAnagram1 = new MyAnagrams("drake");

            // Act 
            List<string> returnWord = new List<string>(){"raked", "deark", "ekard", "kared"};

            // Assert
            CollectionsAssert.AreEqual(expectedWord, returnWord);
        }
    }
}