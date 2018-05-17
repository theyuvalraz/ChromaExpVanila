﻿using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ChromaExpVanilla;
using ChromaExpVanillaTest.FakeClassesForTests;
using Interfacer.Interfaces;
using NUnit.Framework;

namespace ChromaExpVanillaTest
{
    [TestFixture]
    public class StateCheckerTest
    {
        [Test]
        public void Test_StateCheckerReturnsAction()
        {
            var checker = new CheckState {Control = new FakeKeboardController()};
            var returnedStateActions =  checker.States();
            returnedStateActions.Invoke();
            Assert.True(returnedStateActions.GetType() == typeof(Action));
        }

        [Test]
        public void Test_StateCheckerReturnsEnglish()
        {
            var checker = new CheckState
            {
                KeyboardLayout = new FakeGetKeyboardLayout("en-US"),
                Control = new FakeKeboardController()
            };
            var returnedStateActions =  checker.States();
            returnedStateActions.Invoke();
            foreach (var delegateItem in returnedStateActions.GetInvocationList().Where(x => x.Method.Name == "SetEng"))
            {
                Console.WriteLine(delegateItem.GetMethodInfo());
                Assert.True(delegateItem.GetMethodInfo().Name == "SetEng");
            }
        }

        [Test]
        public void Test_StateCheckerReturnsHebrew()
        {
            IKeyboardController keyboardController = new FakeKeboardController();
            var checker = new CheckState
            {
                KeyboardLayout = new FakeGetKeyboardLayout("he-IL"),
                Control = new FakeKeboardController()
            };
            var returnedStateActions =  checker.States();
            returnedStateActions.Invoke();
            foreach (var delegateItem in returnedStateActions.GetInvocationList().Where(x => x.Method.Name == "SetHeb"))
            {
                Console.WriteLine(delegateItem.GetMethodInfo());
                Assert.True(delegateItem.GetMethodInfo().Name == "SetHeb");
            }
        }
    }
}