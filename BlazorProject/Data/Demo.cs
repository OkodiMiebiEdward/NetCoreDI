using BlazorProject.Interface;
using System;

namespace BlazorProject.Data
{
    public class Demo : IDemo
    {
        public DateTime StartupTime { get; init; }
        public Demo()
        {
            StartupTime = DateTime.Now;
        }

        public string GetName()
        {
            return "My name is Demo";
        }
    }
}
