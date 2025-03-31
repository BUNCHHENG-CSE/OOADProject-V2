using Microsoft.Data.SqlClient;
using System.Data;
using OOADPROV2.Models;
using OOADPROV2.Utilities;
using OOADPROV2.Utilities.Strategies;
namespace OOADPROV2.Utilities.Strategies.Search;
public class SearchByTextStrategy : ISearchStrategy
{
    public List<Products> Search(string searchText)
    {
        var result = new List<Products>();
        using (var conn = Helper.Instance.OpenConnection())
        {
            SqlCommand cmd = new SqlCommand("spSearchProducts", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@SearchText", searchText);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new Products
                {
                    ProductsID = Convert.ToInt32(reader["ProductsID"]),
                    ProductName = reader["ProductsName"].ToString(),
                    ProductsPrice = Convert.ToDecimal(reader["Price"]),
                    ProductsStock = Convert.ToInt32(reader["ProductsStock"]),
                    ProductImage = reader["ProductsImage"] as byte[],
                    Category = new Categories
                    {
                        CategoryName = reader["CategoryName"].ToString()
                    }
                };
                result.Add(product);
            }
        }
        return result;
    }
}

