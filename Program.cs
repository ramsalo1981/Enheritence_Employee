namespace CAEnheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("..................(1).....................");
            Employee emp = new Developer(1, "Issam", 190, 10, true);

            Console.WriteLine(emp);

            Console.WriteLine("-------------");

            Employee emp1 = new Sales(2, "Reem", 176, 8,10000,0.05m);

            Console.WriteLine(emp1);

            Console.WriteLine("-------------");

            Employee emp2 = new Maintenance(3, "Salim", 185, 9);

            Console.WriteLine(emp2);
            Console.WriteLine("-------------");

            Employee emp3 = new Manager(4, "Ahmad", 176, 10);

            Console.WriteLine(emp3);
            Console.WriteLine("\n..................(2).....................");

            Developer e = new Developer(1, "Issam", 190, 10, true);

            Console.WriteLine(e);

            Console.WriteLine("-------------");

            Sales e1 = new Sales(2, "Reem", 176, 8, 10000, 0.05m);

            Console.WriteLine(e1);

            Console.WriteLine("-------------");

            Maintenance e2 = new Maintenance(3, "Salim", 185, 9);

            Console.WriteLine(e2);
            Console.WriteLine("-------------");

            Manager e3 = new Manager(4, "Ahmad", 176, 10);

            Console.WriteLine(e3);


            Console.WriteLine("\n..................(3).....................");
            Employee[] employees = { e, e1, e2, e3 };

            foreach (var employee in employees)
            {
                Console.WriteLine("\n======================");
                Console.WriteLine(employee);
            }

            Console.ReadKey();
        }
    }
    
}