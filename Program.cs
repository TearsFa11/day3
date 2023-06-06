using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeBook EmpBook = new EmployeeBook();
            Console.WriteLine("Выберите номер задания(30.03) 1-6:");
            int kazenak = int.Parse(Console.ReadLine());
            switch (kazenak)
            {
                case 1:
                    EmpBook.GetEmployeesInfo();
                    break;
                case 2:
                    EmpBook.GetSalary();
                    break;
                case 3:
                    EmpBook.GetMinSalaryEmp();
                    break;
                case 4:
                    EmpBook.GetMaxSalaryEmp();
                    break;
                case 5:
                    EmpBook.GetAvgSalary();
                    break;
                case 6:
                    EmpBook.GetAllNames();
                    break;
            }
            Console.WriteLine("Выберите номер задания(03.04) 1-8:");
            int sgush = int.Parse(Console.ReadLine());
            switch (sgush)
            {
                case 1:
                    EmpBook.GetUpSalaryEmp();
                    break;
                case 2:
                    EmpBook.GetDepartmentLowestSalary();
                    break;
                case 3:
                    EmpBook.GetDepartmentHighestSalary();
                    break;
                case 4:
                    EmpBook.GetDepartmentCalculateAverageSalary();
                    break;
                case 5:
                    EmpBook.GetDepartmentSalaryIndexing();
                    break;
                case 6:
                    EmpBook.GetAllDepartmentEmployeeNames();
                    break;
                case 7:
                    EmpBook.SalaryLess();
                    break;
                case 8:
                    EmpBook.SalaryMoreOrEqually();
                    break;
            }
            Console.WriteLine("Выберите номер задания (05.04) 1-4");
            int tea = int.Parse(Console.ReadLine());
            switch (tea)
            {
                case 1:
                    EmpBook.Add();
                    break;
                    case 2:
                    EmpBook.Remove();
                    break; 
                case 3:
                    EmpBook.Edit();
                    break;
                    case 4:
                    EmpBook.EmployeesDepartments();
                    break; 
            }

        }
    }
}
