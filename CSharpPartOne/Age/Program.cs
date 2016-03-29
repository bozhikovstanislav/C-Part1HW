namespace Age
{ 
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            
            var  birDateof=  Console.ReadLine();
            DateTime nowDateTime=DateTime.Now;
            DateTime birDateTime = DateTime.Parse(String.Format("{0:mm.dd.yyyy}",birDateof));
            var bmonth = birDateTime.Month;
            var bdate = birDateTime.Date;
            var byear = birDateTime.Year;
            var nowyear = nowDateTime.Year;
            bool islessthen = bmonth > nowDateTime.Month;
            var age = 0;
            if (islessthen)
            {
                 age = (nowyear - 1) - byear;
            }
            else
            {
                age = nowyear - byear;
            }

            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}
