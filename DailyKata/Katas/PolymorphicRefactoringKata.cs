using System;

namespace DailyKata.Katas
{
    public class PolymorphicRefactoringKata : BaseEmployee
    {
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
                    return GetBaseSalary(75);

                case JobTitle.Senior:
                    return GetBaseSalary(75, 20);

                case JobTitle.Consultant:
                    return GetBaseSalary(75, 25, 15);
                default:
                    throw new InvalidOperationException("Invalid job title");
            }
        }

        public double GetBaseSalary(double middlebonus)
        {
            return GetBaseSalary() + middlebonus;
        }
        public double GetBaseSalary(int middleBonus, int seniorBonus)
        {
            return GetBaseSalary() + middleBonus + seniorBonus;
        }
        public double GetBaseSalary(int middleBonus, int seniorBonus, int consultantBonus)
        {
            return GetBaseSalary() + middleBonus + seniorBonus + consultantBonus;
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
////constructor
//switch (_jobTitle)
//{
//    case JobTitle.Junior:
//        bonus = 0;
//        break;
//    case JobTitle.Middle:
//        bonus = 75;
//        break;
//    case JobTitle.Senior:
//        bonus = 75 + 20;
//        break;
//    case JobTitle.Consultant:
//        bonus = 75 + 25 + 15;
//        break;
//    default:
//        throw new InvalidOperationException("Invalid job title");
//}
