using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleASPCore.Models;
using Dapper;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SampleASPCore.DAL
{
    public class IRumahmakanDAL : IRumahmakan
    {
        private IConfiguration _config;
        public IRumahmakanDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Create(Rumahmakan obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Rumahmakan obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rumahmakan> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"SELECT * FROM dbo.Rumahmakan 
                                  INNER JOIN dbo.Jenis ON 
                                  dbo.Jenis.JenisID = dbo.Rumahmakan.JenisID";
                var results = conn.Query<Rumahmakan, Jenis, Rumahmakan>(strSql, (r, j) =>
                {
                    r.Jenis = j;
                    return r;
                }, splitOn: "JenisID");
                return results;
            }
        }

        public Rumahmakan GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RumahmakanWithJenis> GetRumahmakanWithJenis()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from ViewRumahmakanWithJenis order by NamaRestaurant asc";
                var results = conn.Query<RumahmakanWithJenis>(strSql);
                return results;
            }
        }
    }
}
