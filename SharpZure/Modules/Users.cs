using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpZure.Modules
{
    internal class Users
    {
        public static async Task<IGraphServiceUsersCollectionPage> GetUsers(GraphServiceClient graphServiceClient)
        {
            return await graphServiceClient.Users.Request().GetAsync();         
        }
    }
}
