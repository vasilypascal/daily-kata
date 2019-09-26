using DailyKata.Katas;

namespace DailyKata
{
    public abstract class BaseEmployee
    {
       protected JobTitle _jobTitle;
       private readonly int baseSalary = 100;
        //protected double bonus = 0;
        public double GetBaseSalary()
        {
            return baseSalary;
        }
    }
}
