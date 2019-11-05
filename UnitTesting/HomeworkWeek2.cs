﻿using Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting
{
    [TestClass]
    public class HomeworkWeek2
    {
        [TestMethod]
        public void ReturnYCoord_Returns_YCoordAndProvesValueType()
        {
            int initialXCoord = 10;
            int numberToAdd = 12;
            int returnedYCoord = ValueTypeOperations.ReturnYCoord(initialXCoord, numberToAdd);

            int expectedYValue = initialXCoord + numberToAdd;

            Assert.AreEqual(returnedYCoord, expectedYValue);
            Assert.AreEqual(initialXCoord, 10);
        }

        [TestMethod]
        public void ReturnPerson2Age_Returns_SecondPersonAndProvesReferenceType()
        {
            PersonModel initialPerson1 = new PersonModel();
            PersonModel returnedPerson2 = new PersonModel();
            
            initialPerson1.age = 20;
            int newPerson1Age = 25;

            returnedPerson2.age = ReferenceTypeOperations.ReturnPerson2Age(initialPerson1, newPerson1Age);

            Assert.AreEqual(initialPerson1.age, 25);
            Assert.AreEqual(returnedPerson2.age, 25);
        }
    }
}
