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
        public async Task Test_StateCheckerReturnsAction()
        {
            IKeyboardController keyboardController = new FakeKeboardController();
            CheckState checker = new CheckState();
            var returnedStateActions = await checker.States( keyboardController );
            returnedStateActions.Invoke();
            Assert.True(returnedStateActions.GetType() == typeof(Action));
        }

        [Test]
        public async Task Test_StateCheckerReturnsEnglish()
        {
            IKeyboardController keyboardController = new FakeKeboardController();
            var checker = new CheckState {KeyboardLayout = new FakeGetKeyboardLayout("en-US")};
            var returnedStateActions = await checker.States( keyboardController );
            returnedStateActions.Invoke();
            foreach (var delegateItem in returnedStateActions.GetInvocationList().Where(x => x.Method.Name == "SetEng"))
            {
                Console.WriteLine(delegateItem.GetMethodInfo());
                Assert.True(delegateItem.GetMethodInfo().Name == "SetEng");
            }
        }

        [Test]
        public async Task Test_StateCheckerReturnsHebrew()
        {
            IKeyboardController keyboardController = new FakeKeboardController();
            var checker = new CheckState {KeyboardLayout = new FakeGetKeyboardLayout("he-IL")};
            var returnedStateActions = await checker.States( keyboardController );
            returnedStateActions.Invoke();
            foreach (var delegateItem in returnedStateActions.GetInvocationList().Where(x => x.Method.Name == "SetHeb"))
            {
                Console.WriteLine(delegateItem.GetMethodInfo());
                Assert.True(delegateItem.GetMethodInfo().Name == "SetHeb");
            }
        }
    }
}