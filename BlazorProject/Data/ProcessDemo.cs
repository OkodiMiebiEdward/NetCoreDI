﻿using BlazorProject.Interface;
using System;

namespace BlazorProject.Data
{
    public class ProcessDemo : IDemo
    {
        private readonly IDemo _demo;

        public ProcessDemo(IDemo demo)
        {
            _demo = demo;
        }

        public int GetDaysInMonth()
        {
            return _demo.StartupTime.Month switch
            {
                1 => 31,
                2 => 28,
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new IndexOutOfRangeException()
            };
        }

        public string GetName()
        {
            return "My name is process Demo";
        }
    }
}
