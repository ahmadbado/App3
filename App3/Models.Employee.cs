
namespace App3
{
    public class Employee
    {
        public string CalcSalary(string name, double salary, double salesAmount, double overTime)

        {
            double OverTimeCost = (((salary / 30) / (8)) * (overTime * 1.5)) + salary;
            double OverTimeCost1 = (((salary / 30) / (8)) * (overTime * 1.5));
            if (salesAmount >= 0 && salesAmount < 1000)
            {
                salary = salary;
            }

            else if (salesAmount >= 1000 && salesAmount < 5000)
            {
                salary = salary + (salesAmount * 0.02);
            }
            else if (salesAmount >= 5000 && salesAmount < 10000)
            {
                salary = salary + (salesAmount * 0.04);
            }
            else if (salesAmount >= 10000 && salesAmount < 15000)
            {
                salary = salary + (salesAmount * 0.06);
            }
            else if (salesAmount >= 15000)
            {
                salary = salary + (salesAmount * 0.09);
            }

            return "Name: " + name + "\n Total Salary : " + salary + "\n Sales Amount: " + salesAmount + "\n overtime: " + overTime +
                "\n Total Salary after over Time: " + OverTimeCost + "\n Total Salary after over Time as Money: " + OverTimeCost1;

        }
    }

}









