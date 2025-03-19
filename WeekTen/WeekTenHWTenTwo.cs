using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTen
{
    class WeekTenHWTenTwo
    {
        public static void TestWeekTen()
        {
            // #1
            List<int> testInput = new List<int>() { 2, -1, 3, -3, 10, -200 };
            Console.WriteLine(@"Input: { 2, -1, 3, -3, 10, -200}");
            List<int> answer = PositivesFromList<int>(testInput);
            foreach(int n in answer)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();

            // #2
            foreach(Employee e in LINQDataBasePractice())
            {
                Console.WriteLine($"{e.EmployeeName}, {e.EmployeeAge}, ${e.EmployeeSalary} ");
            }

            // #3
            List<string> cities = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            string a = "A";
            string m = "M";
            foreach (string s in FindString(a, m, cities))
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();

            //#4
            RequestNumsAndDisplay();
        }

        public class Employee
        {
            public string EmployeeName { get; set; }
            public int EmployeeAge { get; set; }
            public double EmployeeSalary { get; set; }
            public Employee()
            {
                EmployeeName = "BLANK";
                EmployeeAge = 0;
                EmployeeSalary = 0;
            }
        }
        //1. Write a program in C# Sharp to find the +ve numbers from a list of numbers using where conditions in LINQ Query.
        //Input: { 2, -1, 3, -3, 10, -200}
        //Expected output: {2, 3, 10}
        public static List<T> PositivesFromList<T>(List<T> list) where T : struct, IComparable<T>
        {
            List<T> positives = new List<T>();
            var zero = default(T);
            positives = list.Where<T>(n => n.CompareTo(zero) > 0).ToList();
            return positives;
        }
        //2.Write a program to create a list of employees. Consider a hard coded list. Display all employees who have salary more than $5000 and age < 30.
        public static List<Employee> LINQDataBasePractice()
        {
            Employee jim = new Employee() { EmployeeName = "Jim", EmployeeAge = 33, EmployeeSalary = 500443.50 };
            Employee sally = new Employee() { EmployeeName = "Salley", EmployeeAge = 22, EmployeeSalary = 325256463 };
            Employee patty = new Employee() { EmployeeName = "Patty", EmployeeAge = 56, EmployeeSalary = 4346666 };
            Employee john = new Employee() { EmployeeName = "John", EmployeeAge = 36, EmployeeSalary = 45366666.55 };
            Employee heidi = new Employee() { EmployeeName = "Heidi", EmployeeAge = 19, EmployeeSalary = 543534543.66 };
            Employee raj = new Employee() { EmployeeName = "Raj", EmployeeAge = 25, EmployeeSalary = 435354.45 };
            Employee madhu = new Employee() { EmployeeName = "Madhu", EmployeeAge = 44, EmployeeSalary = 2542526 };
            Employee jeannie = new Employee() { EmployeeName = "Jeannie", EmployeeAge = 42, EmployeeSalary = 5666.50 };
            Employee ida = new Employee() { EmployeeName = "Ida", EmployeeAge = 66, EmployeeSalary = 524626 };
            Employee matt = new Employee() { EmployeeName = "Matt", EmployeeAge = 29, EmployeeSalary = 549543.33 };
            Employee alex = new Employee() { EmployeeName = "Alex", EmployeeAge = 47, EmployeeSalary = 65000 };

            List<Employee> list = new List<Employee> { jim, sally, patty, john, heidi, raj, madhu, jeannie, ida, matt, alex };

            // delayed query
            var employeeAgeSalaryResult = from employee in list
                                          orderby employee.EmployeeName
                                          where employee.EmployeeAge < 30 && employee.EmployeeSalary > 5000
                                          select employee;

            // immediate query with ToList()
            List<Employee> returnList = employeeAgeSalaryResult.ToList();
            return returnList;
        }
        //3. Write a program in C# Sharp to find a string that starts and ends with a specific character.
        //Test Data :
        //The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
        //Input starting character for the string : A
        //Input ending character for the string : M
        //Expected Output :
        //The city starting with A and ending with M is : AMSTERDAM
        public static List<string> FindString(string start, string end, List<string> words)
        {
            var list = words.Where<string>(w => w.StartsWith(start) && w.EndsWith(end));
            return list.ToList();
        }
        //4. Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.
        //Test Data :
        //The members of the list are :
        //55 200 740 76 230 482 95
        //Expected Output :
        //The numbers greater than 80 are :
        //200
        //740
        //230
        //482
        //95
        public static void RequestNumsAndDisplay()
        {
            Console.WriteLine("Enter a set of numbers seperated by spaces: ");
            string inputNums = Console.ReadLine();

            try
            {
                string[] arrNums = inputNums.Split(' ');
                int[] nums = Array.ConvertAll<string, int>(arrNums, int.Parse);
                Console.WriteLine("The numbers greater than 80 are: ");

                foreach(int n in nums.Where<int>(n => n > 80)){
                    Console.Write($"{n} ");
                }
            } 
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
   
}
