using _2001202045_VuNgoDat_Buoi6.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _2001202045_VuNgoDat_Buoi6.Core.Services
{
    public class DAL
    {
        public string cnStr = @"Data Source=DESKTOP-GUE0JS7;Initial Catalog=QL_DTDD1;Integrated Security=True";
        public List<Product> GetProducts()
        {
            List<Product> list = new List<Product>();
            using (SqlConnection conn = new SqlConnection(cnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"select * from sanpham", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Product(
                        int.Parse(reader["MaSP"].ToString()),
                        reader["TenSP"].ToString(),
                        reader["DuongDan"].ToString(),
                        float.Parse(reader["Gia"].ToString()),
                        reader["MoTa"].ToString(),
                        int.Parse(reader["MaLoai"].ToString())
                        ));
                }
            }
            return list;
        }
        public List<Brand> GetBrandForProds()
        {
            List<Brand> list = new List<Brand>();
            using (SqlConnection conn = new SqlConnection(cnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "getBrands";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Brand(
                        int.Parse(reader["MaSP"].ToString()),
                        reader["TenSP"].ToString(),
                        reader["TenLoai"].ToString()
                        ));
                }
            }
            return list;
        }
        public List<Product> GetProducts(string txtSearch)
        {
            List<Product> list = new List<Product>();
            using (SqlConnection conn = new SqlConnection(cnStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"exec getProduts @tensp", conn);
                cmd.Parameters.AddWithValue("@tensp", txtSearch);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Product(
                        int.Parse(reader["MaSP"].ToString()),
                        reader["TenSP"].ToString(),
                        reader["DuongDan"].ToString(),
                        float.Parse(reader["Gia"].ToString()),
                        reader["MoTa"].ToString(),
                        int.Parse(reader["MaLoai"].ToString())
                        ));
                }
            }
            return list;
        }
    }
}