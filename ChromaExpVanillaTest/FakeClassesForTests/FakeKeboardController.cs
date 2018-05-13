﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Interfacer.Interfaces;
using Custom = Corale.Colore.Razer.Keyboard.Effects.Custom;

namespace ChromaExpVanillaTest.FakeClassesForTests
{
    class FakeKeboardController : IKeyboardController
    {
        public void CapsLockOn()
        {
            Console.WriteLine("CapsLockOn");
        }

        public void CapsLockOff()
        {
            Console.WriteLine("CapsLockOff");
        }

        public void NumLockOn()
        {
            Console.WriteLine("NumLockOn");
        }

        public void NumLockOff()
        {
            Console.WriteLine("NumLockOff");
        }

        public void SetEng()
        {
            Console.WriteLine("SetEng");
        }

        public void SetHeb()
        {
            Console.WriteLine("SetHeb");
        }

        public void Animation(List<List<IColoredKey>> keyBlocks)
        {
            Console.WriteLine("Animation");
        }

        public void FrameAnimation(List<List<IColoredKey>> blocksAnimationConceptStage2)
        {
            Console.WriteLine("FrameAnimation");
        }

        public Custom CustomLayer { get; set; }

        public Task SetColorBase()
        {
            Console.WriteLine("SetColorBase");
            return Task.CompletedTask;
        }

        public void InitiateCustom()
        {
            Console.WriteLine("InitiateCustom");
        }

        public void TimeAnimation()
        {
            Console.WriteLine("TimeAnimation");
        }

        public void FirstAnimation()
        {
            Console.WriteLine( "FirstAnimation" );
        }

        public void SecondAnimation()
        {
            Console.WriteLine( "SecondAnimation" );
        }

        public void SetBase()
        {
            Console.WriteLine( "SetBase" );
        }

        public void ClearCustom()
        {
            Console.WriteLine( "ClearCustom" );
        }
    }
}