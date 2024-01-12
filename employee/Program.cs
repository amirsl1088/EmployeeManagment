using employee;

Console.WriteLine("enter employee id");
var employeeId = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter salary");
var salary = int.Parse(Console.ReadLine()!);
Console.WriteLine("enter department");
var department = Console.ReadLine()!;
var employee = new Employee(employeeId, salary);
var manager = new Manager(employeeId, salary);
manager.Depatment = department;
employee.PrintDetails();
manager.PrintDetails();