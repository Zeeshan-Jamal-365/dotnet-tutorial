//OOP
using ConsoleApp1;


//Person p = new Person();
//p.Id = 1;
//Console.WriteLine(p.Id);


//Employee e = new Employee(500000);
//e.Department = "HR";
//e.Designation = "HR manager";
////e.Salary = 50000;
//e.Id = 2;
//e.Name ="Kobe" ;
//e.Phone ="8689696";
//e.Email ="Kobe@edu.com";
//e.Address ="fsadfsdf,dfsdfgfdg,sdasdasd";

//Console.WriteLine("Id: "+e.Id);
//Console.WriteLine("Name: "+e.Name);
//Console.WriteLine("Phone: "+e.Phone);
//Console.WriteLine("Email: "+e.Email);
//Console.WriteLine("Address: "+e.Address);
//Console.WriteLine("Department: " + e.Department);
//Console.WriteLine("Designation: "+e.Designation);
//Console.WriteLine("basic: "+e.Salary);
//Console.WriteLine("Total: " + e.Total());



//MyEmployee e2 = new MyEmployee(40000);
//Console.WriteLine(e2.TotalSalary(4500));
//Console.WriteLine(e2.TotalSalary(5000,20000));
//Console.WriteLine(e2.TotalSalary(5000, 10000, 10000));

Calculator c1 = new Calculator();
Console.WriteLine(c1.Mul(6, 2));
Console.WriteLine(c1.Add(6, 2));
Console.WriteLine(c1.Sub(6, 2));
Console.WriteLine(c1.Div(6, 2));
Console.WriteLine(c1.total()+"\n");

ICalculator c = new Calculator();
Console.WriteLine(c.Mul(5, 2));
Console.WriteLine(c.Add(5, 2));
Console.WriteLine(c.Sub(5, 2));
Console.WriteLine(c.Div(5, 2));

Console.ReadKey();
