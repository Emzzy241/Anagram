using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

namespace Anagram.Tests
{
    [TestClass]
    public class WordChangerTests
    {
        // 1st Test: Tests the Change word to array method
        [TestMethod]
        public void ChangeWordToArray_ChangesAWordToAnArray_Array()
        {
            // Arrange
            string userInput =  "bola";

            // Act: since the methods is static, we call them on the class itself
            char[] result = WordChanger.ChangeWordToArray(userInput);

            // Assert
            Assert.AreEqual(typeof(char[]), result.GetType());
        }

        // 2nd Test: Tests the Sort array method functionality
        // 2nd Test: 
        [TestMethod]
        public void ChangeWordToArray_SortsTheArray_Array()
        {
            // Arrange
            string userInput = "bola";
            
            // Act
            char[] result = WordChanger.ChangeWordToArray(userInput);
            char[] expectedResult = {'a', 'b', 'l', 'o'};
            
            // Assert
            CollectionAssert.AreEqual(expectedResult, result);

        }

        // 3rd Test: Tests the Store Main method functionality
        [TestMethod]
        public void StoreMainWord_StoreWord_Void()
        {
            // Act
            string userInput = "cat";
            char[] catSorted = {'a', 'c', 't'};

            // Act
            WordChanger.StoreMainWord(userInput);
            Dictionary<string, char[]> result = WordChanger.mainWordDictionary;
            Dictionary<string, char[]> expectedResult = new Dictionary<string, char[]>() {  {"cat", catSorted}, };
        
            // Assert
            CollectionAssert.AreEqual(expectedResult["cat"], result[userInput]);
        }
        
   }
}