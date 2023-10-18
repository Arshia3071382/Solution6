using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Id { get; set; }
        public DateTime Employment{get; set;}

        public Employee(string name, string surname,int id,DateTime employment)
        {
            Name = name;
            Surname = surname;
            Id = id;
            Employment = employment;



        }
        public void Hire()
        {
            Console.WriteLine("Employee {0} {1} (ID:{2})has been hired on {3}",Name,Surname,Id,Employment);

        }
        public void Fire()
        {

            Console.WriteLine("Employee {0} {1} (ID:{2})has been fired",Name,Surname,Id);
        }
    }
    public class Bank
    {
        private List<Employee> employees;

        public Bank(List<Employee> employees)   
        {  
        this.employees = employees;
        
        
        }
        public void StartDeposits()
        {
            foreach(Employee employee in employees)  
            { 
            Thread depositThread = new Thread(() => { DepositToEmployee(employee); });
            depositThread.Start();
            }


        }
        private void DepositToEmployee(Employee employee) 
        { 
            while(true)
            {
                Thread.Sleep(5000);
                Console.WriteLine("depositing $100 to employee (Id:{0}) bank account",employee.Id);


            }
        
        
        }


    }
    public class HRManager
    {
        private List<Employee> employees;
        public HRManager()
        {
          employees  = new List<Employee>();


        }
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            employee.Hire();

        }
        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
            employee.Fire();

        }
        public List<Employee>GetEmployees()
        {
            return employees;

        }

    }
}
