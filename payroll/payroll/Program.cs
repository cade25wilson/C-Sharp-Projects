using System;

namespace payroll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep();
            Console.WriteLine("Please enter your name: ");
            string emp_Name = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Hello "+ emp_Name);
            Console.WriteLine("Enter hours worked in the last 7 days: ");
            double work_Hours = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your hourly rate: in usd: ");
            double hourly_Rate = Convert.ToDouble(Console.ReadLine());
            double net_Pay = work_Hours * hourly_Rate;
            double overtime_Rate = hourly_Rate * 1.5;
            double overtime_Hours = work_Hours - 40;
            double overtime_Money = overtime_Hours * overtime_Rate;
            double added_Pay = overtime_Money + net_Pay;
            if (work_Hours <= 40)
            {
                overtime_Hours = 0;
                Console.WriteLine("Your pay before taxes is " + net_Pay);

            }
            Console.WriteLine("Your pay before taxes with overtime is " + added_Pay);
            double oasdi = 0.062 * added_Pay;
            double medicare = 0.0145 * added_Pay;
            double federal_With = 0.062 * added_Pay;
            Console.WriteLine("Please enter your state tax percentage");
            double state_tax = Convert.ToDouble(Console.ReadLine())/ 100 * added_Pay;
            Console.WriteLine("Please enter any amount extra you would like to withold");
            double witholding = Convert.ToDouble(Console.ReadLine());
            double tax_Ded = added_Pay - oasdi - medicare - federal_With - state_tax - witholding;
            Console.WriteLine("Your pay after deductions is " + tax_Ded);
            Console.WriteLine("Medicare took $" + medicare + " out of your paycheck");
            Console.WriteLine("OASDI took $" + oasdi + " out of your paycheck");
            Console.WriteLine("Federal Witholding took $" + federal_With + " out of your paycheck");
            Console.WriteLine("State tax took $" + state_tax + " out of your paycheck");
            Console.WriteLine("You witheld an extra $" + witholding + " from your paycheck");



        }
    }
}
