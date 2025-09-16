﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.StepanovNV.Sprint0.Task2.V0.lib;
namespace Tyuiu.StepanovNV.Sprint0.Task2.V0.test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Игорь", res);

        }
    }
}
