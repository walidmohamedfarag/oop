
namespace oop1
{
    internal class Aplicant
    {
        public Aplicant()
        {
            Count++;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public static int Count { get; private set; }
        private DateOnly _birthdate;
        public DateOnly BirthDate  
        {
            get { return _birthdate; }
            set
            {
                if (value < new DateOnly(1990, 1, 1))
                    throw new Exception("Invalide Date...Please Enter The Right Date ");
                _birthdate=value;
            }
        }
        public int YearsExperience { get; set; }
        private string _aplicantEmail;
        public string AplicantEmail 
        {
            get { return _aplicantEmail; }
            set 
            {
                if (!value.Contains("@gmail.com", StringComparison.OrdinalIgnoreCase))
                      throw new Exception("please enter the right email ");
                _aplicantEmail = value;
            }
        
        }

        public void SetName(string firstname,string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
                throw new Exception("you must enter the full name(first name and last name) please check that");
            FirstName = firstname;
            LastName = lastname;
        }


    }
}
