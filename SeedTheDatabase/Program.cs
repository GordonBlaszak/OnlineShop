using Database;
using System;

namespace SeedTheDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Data.Entity.Database.SetInitializer(new OrdersInitializer());
            using (var context = new OrdersContext())
            {
                //might help
                //          context.Database.ExecuteSqlCommand(
                //TransactionalBehavior.DoNotEnsureTransaction,
                //@"ALTER DATABASE [OnlineShop2] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                Console.WriteLine("Database exists: {0}", context.Database.Exists());
                context.Database.Initialize(true);
            }
        }
    }
}
