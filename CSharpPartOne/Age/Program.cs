﻿namespace Age
{ 
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            
            var  birDateof=  Console.ReadLine();
            DateTime nowDateTime=DateTime.Now;
            DateTime birDateTime = DateTime.Parse(String.Format("{0:mm.dd.yyyy}",birDateof));
            var byear = birDateTime.Year;
            var nowyear = nowDateTime.Year;
            var age = nowyear - byear;
            Console.WriteLine(age);
            Console.WriteLine(age + 10);

        }
    }
}
