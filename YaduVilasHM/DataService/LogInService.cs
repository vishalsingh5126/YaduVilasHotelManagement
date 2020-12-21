using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using YaduVilasHM.Models;
using System.Data.SqlClient;
using YaduVilasHM.Repository;

namespace YaduVilasHM.DataService
{
    public class LogInService : BaseRepository
    {
        public LogInService() : base()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        }
        private string ConnectionString { get; set; }
        public async Task<User> GetUserLoggedIn(string username,string password)
        {
            User user = new User();

            var parameter = new DynamicParameters();
            parameter.Add("@username", username);
            parameter.Add("@password", password);
            return await WithConnection(async conn =>
           {
               var result = await conn.QueryMultipleAsync(CommandText.VadidateUser, param: parameter, null,null,CommandType.StoredProcedure);
               user = result.Read<User>().FirstOrDefault();
               if (user != null)
               {
                   user.Role = result.Read<Role>().FirstOrDefault();
                   user.Sections = result.Read<Section>().ToList();
               }
               return user;

           });
        }
    }
}
