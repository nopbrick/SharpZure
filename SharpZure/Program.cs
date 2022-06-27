using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpZure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainAsync().Wait();
            
            //Modules.Users.GetUsers(sp);
            Console.WriteLine();
        }

        static async Task MainAsync()
        {
            var sp = AuthProvider.GetProviderWithDeviceCode();
            var users = await Modules.Users.GetUsers(sp);
            foreach (var user in users)
            {
                Console.WriteLine(user.DisplayName);
            }
        }
    }
}
