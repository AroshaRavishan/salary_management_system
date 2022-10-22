using System;

namespace salary_management_system
{
    internal class SqlCommand
    {
        private string sql;
        private SqlConnection con;

        public SqlCommand(string sql, SqlConnection con)
        {
            this.sql = sql;
            this.con = con;
        }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}