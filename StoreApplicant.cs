
namespace oop1
{
    internal class StoreApplicant : Istore
    {
       public static Aplicant[] arrayapplicants = new Aplicant[Aplicant.Count];
        private int index = 0;
        public  void StoreApplicants(Aplicant aplicants)
        {
            arrayapplicants[index] = aplicants;
            index++;
        }
    }
}
