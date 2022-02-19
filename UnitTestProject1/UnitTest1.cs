﻿using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(3, Class1.Add(1, 2));
        }

        [TestMethod]
        [ExpectedException(typeof(InputException))]
        public void 例外のテスト()
        {
            Assert.AreEqual(3, Class1.Add(-1, 2));
        }

        [TestMethod]
        public void TestMethod2()
        {
            // ChainingAssertionの書き方
            Class1.Add(1, 2).Is(3);
            var ex = AssertEx.Throws<InputException>(() => Class1.Add(-1, 2));
            ex.Message.Is("マイナス値は入力できません");
        }
    }
}
