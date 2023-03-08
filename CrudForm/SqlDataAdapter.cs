using MySql.Data.MySqlClient;
using System.Data;

namespace CrudForm
{
    internal class SqlDataAdapter
    {
        private MySqlCommand command;

        public SqlDataAdapter(MySqlCommand command)
        {
            this.command = command;
        }

        internal void Fill(DataTable dt)
        {
            throw new NotImplementedException();
        }
    }
}