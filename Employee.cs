
namespace oop1
{
    internal class Employee
    {
        
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public void PrintEmployee()
        {
            Admin admin = new();
            admin.CheckAplicant();
            foreach(var emp in admin.statusesAccepted)
                Console.WriteLine($"the name: {emp.Name} || job: employee");
            
        }
        public void SetName(string firstname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
                throw new Exception("you must enter the full name(first name and last name) please check that");
            FirstName = firstname;
            LastName = lastname;
        }

    }
}
