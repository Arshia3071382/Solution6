// See https://aka.ms/new-console-template for more information
using HR;
using Microsoft.VisualBasic;

HRManager hrManager = new HRManager();

Employee employee1 = new Employee("ali","ahmadi",123,DateTime.Now);
Employee employee2 = new Employee("vahid","sari",243,DateTime.Now);

hrManager.AddEmployee(employee1);
hrManager.AddEmployee(employee2);
Bank bank = new Bank(hrManager.GetEmployees());
bank.StartDeposits();