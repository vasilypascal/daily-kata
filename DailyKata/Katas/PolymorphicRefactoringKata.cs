using System;

namespace DailyKata.Katas
{
    public class PolymorphicRefactoringKata
    {
        private readonly JobTitle _jobTitle;

        public PolymorphicRefactoringKata(JobTitle jobTitle)
        {
            _jobTitle = jobTitle;
        }

        public double GetSalary()
        {
            switch (_jobTitle)
            {
                case JobTitle.Junior:
                    return GetBaseSalary();

                case JobTitle.Middle:
                    return GetBaseSalary() + 75;

                case JobTitle.Senior:
                    return GetBaseSalary() + 75 + 20;

                case JobTitle.Consultant:
                    return GetBaseSalary() + 75 + 25 + 15;

                default:
                    throw new InvalidOperationException("Invalid job title");
            }
        }

        private double GetBaseSalary()
        {
            return 100;
        }
    }

    public enum JobTitle
    {
        Unknown = 0,
        Junior,
        Middle,
        Senior,
        Consultant
    }
}
