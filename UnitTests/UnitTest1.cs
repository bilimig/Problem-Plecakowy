using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2_KO; // Import projektu g��wnego

namespace TestProject
{
    [TestClass]
    public class ProblemTests
    {
        [TestMethod]
        public void TestAtLeastOneItemFits()
        {
            
            Problem problem = new Problem(10, 10); 
            int capacity = 10;

           
            problem.Solve(capacity);

           
            Assert.IsTrue(problem._result_items.Count > 0); 
        }

        [TestMethod]
        public void TestNoItemFits()
        {
           
            Problem problem = new Problem(10, 10); 
            int capacity = 1; 

          
            problem.Solve(capacity);

            
            Assert.IsTrue(problem._result_items.Count == 0); 
        }

        [TestMethod]
        public void TestItemOrderDoesNotAffectSolution()
        {
     
            Problem problem1 = new Problem(10, 10); 
            Problem problem2 = new Problem(10, 10); 
            int capacity = 10;

            
            problem1.Solve(capacity);
            problem2.Solve(capacity);

            
            CollectionAssert.AreEqual(problem1._result_items, problem2._result_items); 
        }

        [TestMethod]
        public void TestSpecificInstanceSolution()
        {
           
            Problem problem = new Problem(10, 10); 
            int capacity = 10;

            problem.Solve(capacity);

          
           
            Assert.AreEqual(10, problem._sorted_items[0].value); 
        }

     
        [TestMethod]
        public void TestCapacityZero()
        {
            // Arrange
            Problem problem = new Problem(10, 10); 
            int capacity = 0;

         
            problem.Solve(capacity);

           
            Assert.AreEqual(0, problem._result_items.Count); 
        }

        [TestMethod]
        public void TestNegativeCapacity()
        {
        
            Problem problem = new Problem(10, 10); 
            int capacity = -10;

           
            Assert.ThrowsException<ArgumentException>(() => problem.Solve(capacity)); 
        }

        [TestMethod]
        public void TestNullItemsList()
        {
           
            Problem problem = new Problem(10, 10); 
            problem.items = null;

           
            Assert.ThrowsException<NullReferenceException>(() => problem.Solve(10)); 
        }
    }
}