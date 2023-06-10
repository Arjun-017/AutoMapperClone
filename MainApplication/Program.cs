using AutoMapperClone;

namespace MainApplication
{

    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee() { FirstName = "Arjun", LastName = "Haridas", EmployeeId = 10 };
            Person person = SlowMapper.Map<Employee, Person>(employee);

            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
        }
    }
}

