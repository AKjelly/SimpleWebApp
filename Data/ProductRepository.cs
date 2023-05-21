using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;
using SimpleWebApp.Models;

namespace SimpleWebApp.Data
{
    public class ProductRepository
    {
        
        private readonly IConfiguration _configuration;

        public ProductRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            }
        }

        public IEnumerable<Product> GetAllProducts()
        {
            using (IDbConnection conn = Connection)
            {
                string query = "SELECT * FROM Products";
                return conn.Query<Product>(query);
            }
        }

        public void AddProduct(Product product)
        {
            using (IDbConnection conn = Connection)
            {
                string query = "INSERT INTO Products (ProductName,Price,Description,CreateDate) VALUES (@ProductName,@Price,@Description,@CreateDate)";
                conn.Execute(query, product);
            }
        }

        public Product GetProductById(int id)
        {
            using (IDbConnection conn = Connection)
            {
                string query = "SELECT * FROM Products WHERE Id = @Id";
                return conn.QueryFirstOrDefault<Product>(query, new { Id = id });
            }
        }
        public void UpdateProduct(Product product)
        {
            using (IDbConnection conn = Connection)
            {
                string query = "UPDATE Products SET ProductName = @ProductName, Price = @Price,Description=@Description,CreateDate=@CreateDate WHERE Id = @Id";
                conn.Execute(query, product);
            }
        }

        public void DeleteProduct(int id)
        {
            using (IDbConnection conn = Connection)
            {
                string query = "DELETE FROM Products WHERE Id = @Id";
                conn.Execute(query, new { Id = id });
            }
        }
    }
}
