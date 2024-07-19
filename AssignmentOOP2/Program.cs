namespace AssignmentOOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Employee01 = new Employee(10, "Karim", 2500, 40);
            Console.WriteLine(Employee01);

            Employee01.ID = 20; // Direct access of the attribute
            // If I change ID to EmpID for example, I'll need to change it everywhere in the program
            // I can change the ID at anytime

            Employee01.SetName("Fayez");
            Console.WriteLine(Employee01.GetName());
            // chnaging the attribute name won't affect the code here
            // since it's accessed through the getter setter

            Employee01.Salary = 3500;
            Console.WriteLine(Employee01.Salary);
            // Access through property


            // Constructor test
            Phonebook Note = new Phonebook(3);
            Note.AddPerson(0, "Karim", 123);
            Note.AddPerson(1, "Amr", 456);
            Note.AddPerson(2, "Mona", 789);

            // Getter Setter test
            int KarimNumber = Note.GetPersonNumber("Karim");
            Console.WriteLine(KarimNumber == -1 ? "Person Not Found" : KarimNumber);
            Note.ChangePersonNumber("Karim", 666);
            Console.WriteLine(Note.GetPersonNumber("Karim") == -1 ? "Person Not Found" : Note.GetPersonNumber("Karim"));

            // Indexer test
            Note["Karim"] = 010123;
            Console.WriteLine(Note["Karim"]);

            Console.WriteLine(Note[0]);
        }
    }
}
