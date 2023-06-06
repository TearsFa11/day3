using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class EmployeeBook
    {
      
        
            private List<Employee> employee = new List<Employee>()
            {
                new("Громова Ева Ивановна", 1 , 13000),
                new("Фетисов Максим Елисеевич", 1 , 23000),
                new("Чернышев Андрей Артёмович", 2 , 8000),
                new("Дубова Софья Робертовна", 2 , 1000),
                new("Кузнецова Маргарита Лукинична", 3 , 14000),
                new("Гаврилова Марьям Савельевна", 3 , 9000),
                new("Логинов Матвей Георгиевич", 4 ,8000),
                new("Спиридонов Кирилл Николаевич", 4 , 5000),
                new("Бабушкина Ульяна Олеговна", 5 , 7000),
                new("Лебедева Анна Сергеевна", 5 , 9000)
            };
            double sum_salary = 0;
            double avg_salary = 0;
            int count = 0;

            public void GetEmployeesInfo()
            {
                foreach (var emp in employee)
                {
                    Console.WriteLine($"фио {emp.Fullname} департамент {emp.Department} зарплата {emp.Salary}");
                }
            }

            public void GetSalary()
            {
                foreach (var emp in employee)
                {
                    sum_salary += emp.Salary;
                }
                Console.WriteLine("сумма затрат на зарплату: " + sum_salary);
            }

            public void GetMaxSalaryEmp()
            {

                Console.WriteLine($"Максимальная зарплата   {employee.Max(e => e.Salary)}");
            }

            public void GetMinSalaryEmp()
            {
                Console.WriteLine($"Минимальная зарплата   {employee.Min(e => e.Salary)}");
            }

            public void GetAvgSalary()
            {
                foreach (var emp in employee)
                {
                    count++;
                    avg_salary += emp.Salary;
                }
                avg_salary /= count;
                Console.WriteLine($"Средняя зарплата {avg_salary}");
            }
            public void GetAllNames()
            {
                foreach (var emp in employee)
                {
                    Console.WriteLine($"Фио {emp.Fullname}");
                }

            }
            public void GetUpSalaryEmp()
            {
                Console.WriteLine("На какой коэффициент вы хотите поднять зарплату ");
                double up = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employee)
                {
                    emp.Salary *= up;
                    Console.WriteLine($"Зарплата увеличена.Теперь равняется {emp.Salary} y {emp.Fullname}");

                }
            }

            public void GetDepartmentLowestSalary()
            {
                double minSalary = double.MaxValue;
                foreach (var emp in employee)
                {
                    if (emp.Department == 3 && emp.Salary < minSalary)
                    {
                        minSalary = emp.Salary;
                        Console.WriteLine($"Сотрудник отдела 3 с наименьшей зарплатой:\n, ФИО: {emp.Fullname}," + $" Зарплата: {emp.Salary}");
                    }
                }
            }

            public void GetDepartmentHighestSalary()
            {
                double maxSalary = double.MinValue;
                foreach (var emp in employee)
                {
                    if (emp.Department == 3 && emp.Salary > maxSalary)
                    {
                        maxSalary = emp.Salary;
                        Console.WriteLine($"Сотрудник отдела 3 с наибольшей зарплатой:\n ФИО: {emp.Fullname}," + $" Зарплата: {emp.Salary}");
                    }
                }
            }

            public void GetDepartmentCalculateAverageSalary()
            {
                double totalSalary = 0;
                int count = 0;
                foreach (var emp in employee)
                {
                    if (emp != null && emp.Department == 3)
                    {
                        totalSalary += emp.Salary;
                        count++;
                    }
                }
                Console.WriteLine("Средняя зарплата отдела 3: " + totalSalary / count);
            }

            public void GetDepartmentSalaryIndexing()
            {
                Console.WriteLine("Укажите индексацию на которую необходимо повысить зарплаты сотрудников 3-его отдела");
                double indexingSalary = Convert.ToDouble(Console.ReadLine());
                foreach (var emp in employee)
                {
                    if (emp.Department == 3)
                    {
                        emp.Salary *= indexingSalary;
                        Console.WriteLine("Зарплата сотрудников отдела 3 после индексации: " + emp.Salary);
                    }
                }
            }

            public void GetAllDepartmentEmployeeNames()
            {
                foreach (var emp in employee)
                {
                    if (emp.Department == 3)
                        Console.WriteLine($"ФИО: {emp.Fullname}, Зарплата: {emp.Salary}");
                }
            }
            public void SalaryLess()
            {
                Console.WriteLine("\nСотрудники с зарплатой меньше 80000:");
                foreach (var emp in employee)
                {
                    if (emp.Salary < 80000)
                    {
                        Console.WriteLine($"ФИО: {emp.Fullname}, Зарплата: {emp.Salary}");
                    }
                }
            }

            public void SalaryMoreOrEqually()
            {
                Console.WriteLine("Сотрудники с зарплатой 80000 или больше:");                            
                foreach (var emp in employee)
                {
                    if (emp.Salary >= 80000)
                    {
                        Console.WriteLine($"ФИО: {emp.Fullname}, Зарплата: {emp.Salary}");
                    }
                }
            }
        public void Add()
        {
            Console.Write("Введите ФИО нового сотрудника: ");
            string newFIO = Console.ReadLine();

            Console.Write("Введите номер отдела нового сотрудника: ");                            //Данный метод позволяет добавить нового сотрудника в список работников компании. При вызове метода
                                                                                                  //пользователю предлагается ввести данные нового сотрудника: ФИО, номер отдела и зарплату.
                                                                                                  //Затем происходит проверка введенного номера отдела. Если номер не соответствует допустимым значениям(от 1 до 5),
                                                                                                  //то пользователь получает сообщение об ошибке и ему предлагается повторно ввести номер отдела.
            int newDepartment = Convert.ToInt16(Console.ReadLine());

            if (newDepartment < 1 && newDepartment > 5)
            {
                Console.Write("Номер отдела введён некорректно!\nВведите номер отдела нового сотрудника: ");
                newDepartment = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Введите зарплату нового сотрудника: ");
            int newSalary = Convert.ToInt32(Console.ReadLine());

            bool addEmp = false;

            for (int i = 0; i < employee.Count; i++)
            {
                if (i != employee[i].ID)
                {
                    employee.Insert(i, new Employee(newFIO, newDepartment, newSalary));
                    employee[i].ID = i;
                    addEmp = true;
                }
            }
            if (addEmp == false)
            {
                employee.Add(new Employee(newFIO, newDepartment, newSalary));
            }
            Console.WriteLine("Cотрудник добавлен");
        }

        public void Remove()
        {
            Console.Write("Введите ID или ФИО сотрудника для удаления: ");                        //Данный метод предназначен для удаления сотрудника из списка работников компании.
                                                                                                  //При вызове метода пользователю предлагается ввести ID или ФИО сотрудника, которого нужно удалить.
                                                                                                  //Далее метод проходит по списку работников и ищет тех, чьё ФИО или ID совпадают с введенным пользователем.
                                                                                                  //Если находится более одного сотрудника с таким ФИО, то пользователь должен уточнить ID нужного сотрудника.
            string removeEmp = Console.ReadLine();
            int counter = 0;

            foreach (var emp in employee)
            {
                if (removeEmp == emp.Fullname)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.Fullname}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");
                    counter++;
                }
            }

            if (counter > 1)
            {
                Console.Write("Уточните ID сотрудника для удаления: ");
                removeEmp = Console.ReadLine();
            }

            foreach (var emp in employee)
            {
                if (removeEmp == emp.ID.ToString())
                {
                    employee.RemoveAt(emp.ID);
                    Console.WriteLine("Сотрудник удалён");
                    break;
                }
            }
        }

        public void Edit()
        {
            Console.Write("Введите ID или ФИО сотрудника: ");                                                                    //Данный метод предназначен для редактирования данных конкретного сотрудника в списке работников компании.
                                                                                                                                 //При вызове метода пользователь должен ввести ID или ФИО сотрудника, чьи данные он хочет отредактировать.
                                                                                                                                 //Затем метод ищет в списке работников сотрудника с введенным ID или ФИО и в случае успешного нахождения выводит информацию
                                                                                                                                 //о нем на экран.Пользователю предлагается выбрать, какие данные необходимо изменить: зарплату, отдел или зарплату и отдел сразу.
            string empInfo = Console.ReadLine();
            int counter = 0;

            foreach (var emp in employee)
            {
                if (empInfo == emp.Fullname)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.Fullname}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");
                    counter++;
                }
            }

            Console.WriteLine("Введите чтобы изменить: \n" + "1 - Зарплату\n" + "2 - Отдел\n" + "3 - Зарплату и отдел");
            string action = Console.ReadLine();

            foreach (var emp in employee)
            {
                if (empInfo == emp.ID.ToString())
                {
                    switch (action)
                    {
                        case "1":
                            Console.Write("Введите зарплату сотрудника: ");
                            action = Console.ReadLine();
                            emp.Salary = Convert.ToInt32(action);
                            break;
                        case "2":
                            Console.Write("Введите отдел сотрудника: ");
                            action = Console.ReadLine();
                            emp.Department = Convert.ToInt32(action);
                            break;
                        case "3":
                            Console.Write("Введите зарплату сотрудника: ");
                            action = Console.ReadLine();
                            emp.Salary = Convert.ToInt32(action);
                            Console.Write("Введите отдел сотрудника: ");
                            action = Console.ReadLine();
                            emp.Department = Convert.ToInt32(action);
                            break;
                    }

                    Console.WriteLine("Данные сотрудника изменены");
                    break;
                }
            }
        }

        public void EmployeesDepartments()                                                           //Данный метод предназначен для вывода списка сотрудников компании, отсортированных по отделам.
                                                                                                     //Внутри метода используется цикл for для перебора всех отделов в компании, начиная с первого и заканчивая пятым.
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + "-й отдел: ");
                foreach (var emp in employee)
                {
                    if (i == emp.Department)
                    {
                        Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.Fullname}, Зарплата: {emp.Salary}");
                    }
                }
            }
        }
    }
}

    