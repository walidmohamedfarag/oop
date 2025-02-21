
using System.Runtime.InteropServices;

namespace oop1
{
    internal class Admin
    {
        private readonly Istore istore;

        public Admin(Istore _istore,int yearsexceprince)
        {
            istore= _istore;
            ExperiencYears = yearsexceprince;
        }
        StatusAplicant[] statusesAccepted;
        StatusAplicant[] statusesRejected;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ID { get; set; }
        public int ExperiencYears {  get;  }
        private int countAccepted;
        private int countRejected;
        public void SetName(string firstname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
                throw new Exception("you must enter the the full name (first name , last name)");
            FirstName = firstname;
            LastName = lastname;   
        }
        
        public void CheckAplicant()
        {
            foreach(var statu in StoreApplicant.arrayapplicants)
            {
                if (statu.YearsExperience >= ExperiencYears)
                    countAccepted++;
                else
                    countRejected++;
            }
            statusesAccepted = new StatusAplicant[countAccepted];
            statusesRejected = new StatusAplicant[countRejected];
            int indeacc = 0;
            int indexre = 0;
            foreach (var check in StoreApplicant.arrayapplicants)
            {
                if (check.YearsExperience >= ExperiencYears)
                {
                    StatusAplicant status=new();
                    status.Nmae = $"{check.FirstName} {check.LastName}";
                    status.Status = "Accepted";
                    statusesAccepted[indeacc] = status;
                    indeacc++;
                }
                else
                {
                    StatusAplicant status = new();
                    status.Nmae = $"{check.FirstName} {check.LastName}";
                    status.Status = "Rejected";
                    statusesRejected[indexre] = status;
                    indexre++;
                }

            }
        }
        public void PrintStatusApplicant()
        {
            foreach(var statusapp in statusesAccepted)
                Console.WriteLine($"Dear ({statusapp.Nmae}) You Will ({statusapp.Status})");
            foreach(var statusapp in statusesRejected)
                Console.WriteLine($"Dear ({statusapp.Nmae}) You Will ({statusapp.Status})");

        }
        
        public  void StoreApplicants(Aplicant aplicant)
        {
            istore.StoreApplicants(aplicant);
        }




    }
}
