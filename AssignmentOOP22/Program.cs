namespace AssignmentOOP22
{

    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part02_Question01
            /* Person[] people = new Person[3];

             people[0] = new Person { Name = "Abdalla", Age = 30 };
             people[1] = new Person { Name = "Mohamed", Age = 25 };
             people[2] = new Person { Name = "Tarek", Age = 35 };

             foreach (Person person in people)
             {
                 Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
             }*/
            #endregion

            #region Part02_Question02

            /* Person[] people = new Person[3];

             for (int i = 0; i < people.Length; i++)
             {
                 Console.Write($"Enter name number {i+1}: ");
                 string name = Console.ReadLine();

                 if (string.IsNullOrWhiteSpace(name))
                 {
                     name = "Unknown";
                 }

                 int age;
                 while (true)
                 {
                     Console.Write($"Enter age number {i+1}: ");
                     if (int.TryParse(Console.ReadLine(), out age))
                     {
                         break;
                     }
                     else
                     {
                         Console.WriteLine("Invalid input. Please enter a valid integer for age.");
                     }
                 }

                 people[i] = new Person { Name = name, Age = age };
             }

             Person oldestPerson = people[0];

             for (int i = 1; i < people.Length; i++)
             {
                 if (people[i].Age > oldestPerson.Age)
                 {
                     oldestPerson = people[i];
                 }
             }

             Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}");*/


            #endregion

            #region Part03_Question06
            /*Employee[] employees = new Employee[3];

            employees[0] = Employee.CreateEmployee(SecurityPrivileges.DBA);
            employees[1] = Employee.CreateEmployee(SecurityPrivileges.Guest);
            employees[2] = Employee.CreateEmployee(SecurityPrivileges.DBA | SecurityPrivileges.Guest | SecurityPrivileges.Developer | SecurityPrivileges.Secretary);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }*/

            #endregion

            #region Part03_Question07

            /*employees = Employee.SortEmployees(employees);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }*/
            #endregion


        }
    }
}
