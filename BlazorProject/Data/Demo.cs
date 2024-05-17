using System;

namespace BlazorProject.Data
{
    public class Demo
    {
        public DateTime StartupTime { get; init; }
        public Demo()
        {
            StartupTime = DateTime.Now;
        }
    }
}
