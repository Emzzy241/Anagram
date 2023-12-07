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
        public void changeWordToArray_ChangesAWordToAnArray_Array()
        {
            // Arrange
            string userInput =  "bola";

            // Act: since the methods is static, we call them on the class itself
            char[] result = WordChanger.ChangeWordToArray(userInput);

            // Assert
            Assert.AreEqual(typeof(char[]), result.GetType());
        }

        // 2nd Test: Tests the Store Main method functionality
        [TestMethod]
        public void changeWordToArray_SortsTheArray_Array()
        {
            // Arrange
            string userInput = "bola";
            
            // Assert
            char[] result = WordChanger.ChangeWordToArray(userInput);
            char[] expectedResult = {'a', 'b', 'l', 'o'};
            
            // Act
            CollectionAssert.AreEqual(expectedResult, result);

        }
        
        
   }
}