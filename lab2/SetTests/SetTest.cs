using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using program_lab2;

namespace SetTests
{
    [TestClass]
    public class SetTest
    {
        [TestMethod]
        public void CountAfterEmptyConstructor()
        {
            Set<int> set = new Set<int>();
            int countExpected = 0;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Count after empty constructor does not work correctly");
        }

        [TestMethod]
        public void CountAfterConstructorWithArgs()
        {
            Set<int> set = new Set<int>() { 1, 2, 3, 4, 5 };
            int countExpected = 5;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Count after constructor with args does not work correctly");
        }

        [TestMethod]
        public void AddNewElem()
        {
            Set<int> set = new Set<int> { 1, 2, 3 };
            set.Add(4);
            int countExpected = 4;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Add new elem does not work correctly");
        }

        [TestMethod]
        public void AddAnExistingElem()
        {
            Set<int> set = new Set<int>() { 1, 2, 3 };
            set.Add(3);
            int countExpected = 3;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Add an existing elem does not work correctly");
        }

        [TestMethod]
        public void AddNullElem()
        {
            Set<string> set = new Set<string>();
            set.Add(null);
            int countExpected = 0;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Add null elem does not work correctly");
        }

        [TestMethod]
        public void RemoveAnExistingElem()
        {
            Set<int> set = new Set<int>() { 1, 2, 3 };
            set.Remove(3);
            int countExpected = 2;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Remove an existing elem does not work correctly");
        }

        [TestMethod]
        public void RemoveANonExistingElem()
        {
            Set<int> set = new Set<int>() { 1, 2, 3 };
            set.Remove(4);
            int countExpected = 3;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Remove an non existing elem does not work correctly");
        }

        [TestMethod]
        public void RemoveNullElem() 
        {
            Set<string> set = new Set<string>();
            set.Remove(null);
            int countExpected = 0;
            int countActual = set.Count;
            Assert.AreEqual(countExpected, countActual, "Remove null elem does not work correctly");
        }

        [TestMethod]
        public void ContainsExistingElem()
        {
            Set<int> set = new Set<int>() { 1, 2, 3 };
            bool actual = set.Contains(3);
            bool expected = true;
            Assert.AreEqual(expected, actual, "Contains existing elem does not work correctly");
        }

        [TestMethod]
        public void ContainsNonExistingElem()
        {
            Set<int> set = new Set<int>() { 1, 2, 3 };
            bool actual = set.Contains(4);
            bool expected = false;
            Assert.AreEqual(expected, actual, "Contains non existing elem does not work correctly");
        }

        [TestMethod]
        public void UnionTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            Set<int> set2 = new Set<int>() { 3, 4 };
            int countExpected = 4;
            set1.Union(set2);
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Union does not work correctly");
        }

        [TestMethod]
        public void IntersectionTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            Set<int> set2 = new Set<int>() { 3, 4 };
            int countExpected = 1;
            set1.Intersection(set2);
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Intersection does not work correctly");
        }

        [TestMethod]
        public void DifferenceTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            Set<int> set2 = new Set<int>() { 3, 4 };
            int countExpected = 2;
            set1.Difference(set2);
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Difference does not work correctly");
        }

        [TestMethod]
        public void SubsetTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3, 4 };
            Set<int> set2 = new Set<int>() { 3, 4 };
            bool expected = true;
            bool actual = set1.Subset(set2);
            Assert.AreEqual(expected, actual, "Subset does not work correctly");
        }

        [TestMethod]
        public void PlusWithElem()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3, 4 };
            set1 += 5;
            int countExpected = 5;
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Plus with elem does not work correctly");
        }

        [TestMethod]
        public void PlusWithSet()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3, 4 };
            Set<int> set2 = new Set<int>() { 4, 5, 6 };
            set1 += set2;
            int countExpected = 6;
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Plus with set does not work correctly");
        }

        [TestMethod]
        public void MultiplicationTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            Set<int> set2 = new Set<int>() { 3, 4 };
            int countExpected = 1;
            set1 *= set2;
            int countActual = set1.Count;
            Assert.AreEqual(countExpected, countActual, "Multiplication does not work correctly");
        }

        [TestMethod]
        public void OperatorInt()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            int countExpected = 3;
            int countActual = (int)set1;
            Assert.AreEqual(countExpected, countActual, "Operator int does not work correctly");
        }

        [TestMethod]
        public void OperatorBool() 
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            bool expected = true;
            bool actual = (set1 ? true : false);
            Assert.AreEqual(expected, actual, "Operator bool does not work correctly");
        }

        [TestMethod]
        public void ToStringTest()
        {
            Set<int> set1 = new Set<int>() { 1, 2, 3 };
            string expected = "1, 2, 3";
            string actual = set1.ToString();
            Assert.AreEqual(expected, actual, "Method toString does not work correctly");
        }
    }
}
