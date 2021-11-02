﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax.
             *
             * HINT: Use the List of Methods defined in the Lecture Material Google Doc ***********
             *
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //Print the Sum and Average of numbers
            //double sum = 0, avg = 0;
            // double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //  for (int i = 0; i < numbers.Length; i++)
            //  {
            //      sum += numbers[i];
            //  }
            //  avg = sum / numbers.Length;
            //  Console.WriteLine("The Sum is : " + sum);
            //  Console.WriteLine("The Average is : " + avg);

            //  Console.ReadKey();
            var sum = numbers.Sum();
            var avg = numbers.Average();
            Console.WriteLine($"Sum: {sum} " );
            Console.WriteLine($"Averge:{avg}");

            //Order numbers in ascending order and decsending order. Print each to console.
            var asc = numbers.OrderBy(num => num);
            Console.WriteLine("-------------------");
            Console.WriteLine("Asc");
            
            foreach(var num in asc)
            {
                Console.WriteLine(num);
            }
            var desc = numbers.OrderByDescending(x => x);
            Console.WriteLine("-------------------");
            Console.WriteLine("Desc");
            foreach (var num in desc)
            {
                Console.WriteLine(num);
            }

            //Print to the console only the numbers greater than 6
            var greaterThanSix = numbers.Where(num => num > 6);

            foreach(var item in greaterThanSix)
            {
                Console.WriteLine(item);
            }
            //Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            
            
            Console.WriteLine("First 4 asc");

            foreach (var num in asc.Take(4))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("First 4 desc");

            foreach (var num in desc.Take(4))
            {
                Console.WriteLine(num);
            }

            //Change the value at index 4 to your age, then print the numbers in decsending order

            numbers[4] = 32;
            Console.WriteLine("This will display my name age");
            foreach(var item in numbers.OrderByDescending(num => num))
            {
                Console.WriteLine(item);
            }

            // List of employees ***Do not remove this***
            var employees = CreateEmployees();



            //Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S.
            //Order this in acesnding order by FirstName.
            var filtered =
                employees.Where(person => person.FirstName.StartsWith('C') || person.FirstName.StartsWith('S') || person.FirstName.StartsWith('M')) 
                .OrderBy(person => person.FirstName);
            

            Console.WriteLine("C , M, or S Employees");
            foreach(var employee in filtered)
            {
                Console.WriteLine(employee.FullName);
            }

           



            //Print all the employees' FullName and Age who are over the age 26 to the console.
            //Order this by Age first and then by FirstName in the same result.
            var overTwentySix = employees.Where (emp => emp.Age > 26)
                .OrderBy(emp => emp.Age).ThenBy(emp => emp.FirstName);

            Console.WriteLine("Over 26");
            foreach(var person in overTwentySix)
            {
                Console.WriteLine($"Full Name: {person.FullName} Age: {person.Age}  YOE: {person.YearsOfExperience}");
            }
            //Print the Sum and then the Average of the employees' YearsOfExperience
            //if their YOE is less than or equal to 10 AND Age is greater than 35

            var yoeEmployees = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
           // var sum = yoeEmployees.Sum(emp => YearsOfExperience);
           


            //Add an employee to the end of the list without using employees.Add()


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
        
    }
}
