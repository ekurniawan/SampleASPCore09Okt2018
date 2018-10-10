using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleASPCore.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SampleASPCore.DAL
{
    public class JenisDAL : IJenis
    {
        private IConfiguration _config;
        public JenisDAL(IConfiguration config)
        {
            _config = config;
        }

        private string GetConnStr()
        {
            return _config.GetConnectionString("DefaultConnection");
        }

        public void Create(Jenis obj)
        {
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {

            }
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
            List<Jenis> listJenis = new List<Jenis>();
            using(SqlConnection conn = new SqlConnection(GetConnStr()))
            {
                var strSql = @"select * from Jenis order by NamaJenis";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            listJenis.Add(
                                new Jenis { JenisID=Convert.ToInt32(dr["JenisID"]),
                                NamaJenis=dr["NamaJenis"].ToString()});
                        }
                    }
                    dr.Close();
                    return listJenis;
                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
        }

        public Jenis GetById(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jenis> GetByNamaJenis(string nama)
        {
            throw new NotImplementedException();
        }
    }
}
