using System.Data;
using System.Data.SqlClient;

namespace CaseStudy.DAL
{
    public class BaseRepository
    {
        protected IDbConnection con;
        public BaseRepository()
        {
            string connectStr = @"Data Source=DESKTOP-GP2BSL1;Initial Catalog=CaseStudy;Integrated Security=True";
            con = new SqlConnection(connectStr);
        }
    }
}
