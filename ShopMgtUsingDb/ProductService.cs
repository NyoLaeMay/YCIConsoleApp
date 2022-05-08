using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ShopMgtUsingDb
{
    public class ProductService
    {
        public List<ProductList> GetShopMgtDb()
        {
            List<ProductList> products = new List<ProductList>();
            SqlConnection sqlConnection = DatabaseConnector.GetConnection();
            string sqlcommand = "select * from Product";
            SqlCommand sqlCommand = new SqlCommand(sqlcommand, sqlConnection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())//0,1,2
            {
                ProductList product = new ProductList()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),                    
                    Price = Convert.ToDecimal(reader["Price"]),
                    Category = reader["Category"].ToString(),             
                };
                products.Add(product);
            }
            return products;
        }
        public void SaveProductList(ProductList product)
        {
            try
            {
                SqlConnection sqlConnection = DatabaseConnector.GetConnection();//always write
                string sqlquery = $"insert into Product values('{product.Id}','{product.Name}','{product.Price}','{product.Category}')";
                SqlCommand sqlCommand = new SqlCommand(sqlquery, sqlConnection);
                int result = sqlCommand.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Successfully Saved!!.");
                }
                else
                {
                    Console.WriteLine("Failed when insert record.");
                }
            }
            catch (SqlException sqlex)
            {

                throw sqlex;
            }
        }
        public void DeleteByProductId(int Id)
        {
            try
            {
                SqlConnection Connection = DatabaseConnector.GetConnection();
                string sqlDeleteQuery = $"Delete from Product where Id={Id}";
                SqlCommand sqlcommand = new SqlCommand(sqlDeleteQuery, Connection);
                int result = sqlcommand.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Successfully Deleted!!");
                else
                    Console.WriteLine("Failed when record is deleted.");
            }
            catch (SqlException sqlex)
            {

                throw sqlex;
            }
        }
        public void UpdateByProductId(ProductList product)
        {
            try
            {
                SqlConnection Connection = DatabaseConnector.GetConnection();
                string sqlUpdateQuery = $"Update Product set name='{product.Name}' where id={product.Id}";
                SqlCommand sqlcommand = new SqlCommand(sqlUpdateQuery, Connection);
                int result = sqlcommand.ExecuteNonQuery();
                if (result > 0)
                    Console.WriteLine("Successfully Updated!!");
                else
                    Console.WriteLine("Failed when record is updated.");
            }
            catch (SqlException sqlex)
            {

                throw sqlex;
            }
        }
    }
}
