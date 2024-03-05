/*List<int> list = new List<int>() {2,37,5,4,3,9,1 };

            var even=from val in list
                     where val%2== 0
                     select val;

            foreach (var val in even) 
            {
                Console.WriteLine(val);
            }*/

/*using System;
using System.Linq;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 22 },
            new Person { Name = "David", Age = 28 }
        };

        // LINQ query to filter people over 25 years old
        var result = from person in people
                     where person.Age > 25
                     select person;

        // Display the result
        Console.WriteLine("People over 25:");
        foreach (var person in result)
        {
            Console.WriteLine($"{person.Name}, {person.Age} years old");
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

public class Employee
{ 
    public string Name { get; set; }
    public int Id { get; set; }

    public int Salary { get; set; }

    public string Department { get; set; }

    


    
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>()
        {
            new Employee { Name = "shashank", Id = 01, Salary = 10000, Department = "EEE" },
        new Employee { Name = "harsha", Id = 02, Salary = 20000, Department = "CS" },
        new Employee { Name = "Dileep", Id = 03, Salary = 30000, Department = "civil" },
        new Employee { Name = "murali", Id = 04, Salary = 40000, Department = "EEE" }
    };

        var res=(from emp in list
                where emp.Name=="shashank"
                select emp);

        foreach (var item in res)
        {
            Console.WriteLine($"Id:{item.Id} Salary:{item.Salary} Department:{item.Department}");
        }
    }
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
public class elemat
    { 
 public static void Main(string[] args)
{ 
       List<int> lis = new List<int>(){2,5,6,7,28,9};

        //var simp = lis.ElementAt(2);
        //var simp = lis.ElementAtOrDefault(-1);
        //var simp=lis.Contains(2);
          var simp = (from result in lis select result).Single();

        Console.WriteLine(simp);

        *//*var res = (from el in lis
                    select el).ElementAt(5);*/

/* var res = (from el in lis
            select el).ElementAtOrDefault(3);*//*

// Console.WriteLine(res);
}
}*/

/*using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] IntArray = { 10, 20, 30, 40, 50, 60, 70 };

        //DefaultIfEmpty Method will return a new sequence with existing sequence values

        //Using Method Syntax
        var MethodSyntax = IntArray.DefaultIfEmpty();

        //Using Query Syntax
        var QuerySyntax = (from num in IntArray select num).DefaultIfEmpty();

        foreach (var num in MethodSyntax)
        {
            Console.Write($"{num} ");
        }

        foreach (var num in QuerySyntax)
        {
            Console.Write($"{num} ");
        }

        Console.ReadKey();
    }
}*/

/*using System;
using System.Collections.Generic;
using System.Linq;
public class first
{
    public static void Main(string[] args)
    {
        List<int> ls = new List<int>() 
        {2,4,6,1,9,7,6,4 }; 
        
        var res=ls.First();
        Console.WriteLine(res);

        var resliq=(from val in ls 
                   select val).First();
        Console.WriteLine(resliq);
    }
}*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;


public class myownexception : Exception
{ 
 public myownexception(string message) : base(message)
    {
    
    }
}

public class Employees
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }

    public override string ToString()
    {
        return $"{Name},{Id}{Salary},{Department}";
    }

    public  static bool isvalidname(string name)
    {
        return Regex.IsMatch(name,("[A-Za-z]"));
    }
}

public class program
{
   
    static void Main(string[] args)
    {

        if (Employees.isvalidname("Shashank"))
        {
            Console.WriteLine("invalid name");
        }

        List<Employees> ls = new List<Employees>()
    {
       
      new Employees{Name="shashank",Id=01,Salary=10000,Department="EC" },
      new Employees{Name="harsha",Id=02,Salary=20000,Department="EEE" },
      new Employees{Name="abhi",Id=03,Salary=30000,Department="CS" }
    };

        
        var res = ls.First();
        Console.WriteLine($"{res.Id},{res.Name},{res.Salary},{res.Department}");
        try
        {
            var res1 = (from val in ls
                        select val).First();
            Console.WriteLine($"{res1.Id},{res1.Name},{res1.Salary},{res1.Department}");

            throw new myownexception("this is my message");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }
        var res2 = ls.Where(b => b.Salary < 11000);

        foreach (var item in res2)
        {
            Console.WriteLine(item);
        }
    }
   

}
