using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AdventureWorksModel;

namespace AdventureWorksDAL
{
    public class Catalog
    {
        public List<Category> GetCategories()
		{
			// declare the SqlDataReader, which is used in
			// both the try block and the finally block
			SqlDataReader rdr = null;

			// create a connection object
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ToString();
			SqlConnection conn = new SqlConnection(connString);

			// create a command object
			SqlCommand cmd  = new SqlCommand("SELECT * FROM Production.ProductCategory", conn);

            List<Category> categoriesList = new List<Category>();

			try
			{
				// open the connection
				conn.Open();

				// 1. get an instance of the SqlDataReader
				rdr = cmd.ExecuteReader();


				// 2. add each Category object to return list
				while (rdr.Read())
				{
                    Category category = new Category();
                    category.ProductCategoryId = (int)rdr["ProductCategoryID"];
                    category.Name = (string)rdr["Name"];

                    categoriesList.Add(category);
				}
			}
			finally
			{
				// 3. close the reader
				if (rdr != null)
				{
					rdr.Close();
				}

				// close the connection
				if (conn != null)
				{
					conn.Close();
				}
			}

            return categoriesList;
		}
    }
}
