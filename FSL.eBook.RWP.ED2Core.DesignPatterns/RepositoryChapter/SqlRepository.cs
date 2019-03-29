using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace FSL.eBook.RWP.ED2Core.DesignPatterns.RepositoryChapter
{
    public abstract class SqlRepository
    {
        private SqlConnection _connection = null;
        private string _connectionStringId;
        private string _connectionString;
        private readonly IConfiguration _configuration;

        public SqlRepository(
            IConfiguration configuration) :
            this("RealWorldProgramming")
        {
            _configuration = configuration;
        }

        public SqlRepository(
            string connectionStringId)
        {
            _connectionStringId = connectionStringId;
        }
        
        public virtual string ConnnectionStringId
        {
            get
            {
                return _connectionStringId;
            }
        }
        
        protected SqlConnection Database
        {
            get
            {
                if (_connection == null)
                {
                    if (string.IsNullOrEmpty(_connectionString))
                    {
                        _connectionString = _configuration.GetConnectionString(
                            ConnnectionStringId);
                    }

                    _connection = new SqlConnection(_connectionString);
                }

                return _connection;
            }
        }

        public SqlRepository UseConnectionStringId(
            string connectionStringId)
        {
            _connectionStringId = connectionStringId;

            return this;
        }

        public SqlRepository UseConnectionString(
            string connectionString)
        {
            _connectionString = connectionString;

            return this;
        }
    }
}