using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using SampleASPCore.Models;

namespace SampleASPCore.DAL
{
    public class JenisDALDapper : IJenis
    {
        private IConfiguration _config;
        public JenisDALDapper(IConfiguration config)
        {
            _config = config;
        }

        public void Create(Jenis obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(Jenis obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jenis> GetAll()
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Jenis order by NamaJenis";
                var results = conn.Query<Jenis>(strSql);
                return results;
            }
        }

        public Jenis GetById(string id)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                string strSql = @"select * from Jenis where Id=@Id";
                var param = new { Id = id };
                var results = conn.QuerySingle<Jenis>(strSql, param);
                return results;
            }    
        }

        public IEnumerable<Jenis> GetByNamaJenis(string nama)
        {
            throw new NotImplementedException();
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }


    }
}
