using Int.Victoria.Scheduler.BusinessObject;

namespace Int.Victoria.Scheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipe = args[0].ToLower();               

            if (tipe.ToLower().Equals("productcatalog"))
            {
                BOProductCatalog bOProductCatalog = new BOProductCatalog();
                bOProductCatalog.GenerateProductCatalog();
            }           
        }
    }
}