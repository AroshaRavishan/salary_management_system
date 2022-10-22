using System;

namespace salary_management_system
{
    internal class SqlConnection
    {
        private string connectionString;

        public SqlConnection(string connectionString)
        {
            this.connectionString = connectionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}