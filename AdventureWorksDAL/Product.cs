using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AdventureWorksModel;

namespace AdventureWorksDAL
{
    public class Product
    {

        public List<AdventureWorksModel.Product> GetProducts(int subcategoryId)
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            // Define parameter used in command object
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@SubcategoryId";
            param.Value = subcategoryId;
            param.SqlDbType = SqlDbType.Int;

            // create a command object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspGetProductsBySubcategory";

            cmd.Parameters.Add(param);

            List<AdventureWorksModel.Product> productsList = new List<AdventureWorksModel.Product>();

            try
            {
                // open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);

                string thumbnailPhotoFileName = string.Empty;
                string thumbnailsLocation = ConfigurationManager.AppSettings["TempThumbnailsLocation"];

                // 2. add each Category object to return list
                while (rdr.Read())
                {
                    AdventureWorksModel.Product product = new AdventureWorksModel.Product();
                    product.ProductId = (int)rdr["ProductID"];
                    product.Model = (string)rdr["Model"];
                    product.Name = (string)rdr["Name"];
                    product.ListPrice = (decimal)rdr["ListPrice"];
                    product.Weight = (decimal)rdr["Weight"];
                    product.UnitMeasure = (string)rdr["UnitMeasure"];
                    //product.ThumbnailPhoto = null; //TODO Read into byte array
                    //product.ThumbnailPhotoFileName = (string)rdr["ThumbnailPhotoFileName"];
                    thumbnailPhotoFileName = Path.Combine(thumbnailsLocation,(string)rdr["ThumbnailPhotoFileName"]);

                    if (!File.Exists(thumbnailPhotoFileName))
                    {

                        File.WriteAllBytes(thumbnailPhotoFileName, (byte[])rdr["ThumbnailPhoto"]);
                        //// again, we map the result to an SqlBytes instance
                        //byte[] bytes = rdr.GetSqlBytes(6).Buffer; // column ordinal, here 1st column -> 0

                        //// I use a file stream, but that could be any stream (asp.net, memory, etc.)
                        //using (FileStream file = File.OpenWrite(thumbnailPhotoFileName))
                        //{
                        //    bytes.
                        //    bytes.Stream.CopyTo(file);
                        //}
                    }

                    product.ProductSubcategoryId = subcategoryId;

                    productsList.Add(product);
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

            return productsList;
        }

        public AdventureWorksModel.Product GetProduct(int productId)
        {
            // declare the SqlDataReader, which is used in
            // both the try block and the finally block
            SqlDataReader rdr = null;

            // create a connection object
            string connString = ConfigurationManager.ConnectionStrings["AdventureWorksConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connString);

            // Define parameter used in command object
            SqlParameter param = new SqlParameter();
            param.ParameterName = "@ProductID";
            param.Value = productId;
            param.SqlDbType = SqlDbType.Int;

            // create a command object
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "uspGetProduct";

            cmd.Parameters.Add(param);

            AdventureWorksModel.Product product = new AdventureWorksModel.Product();

            try
            {
                // open the connection
                conn.Open();

                // 1. get an instance of the SqlDataReader
                rdr = cmd.ExecuteReader();


                // 2. add each Category object to return list
                if (rdr.Read())
                {
                    product.ProductId = (int)rdr["ProductID"];
                    product.Model = (string)rdr["Model"];
                    product.Name = (string)rdr["Name"];
                    product.ListPrice = (decimal)rdr["ListPrice"];
                    product.Weight = (decimal)rdr["Weight"];
                    product.UnitMeasure = (string)rdr["UnitMeasure"];
                    product.ThumbnailPhoto = null; //TODO Read into byte array
                    product.ThumbnailPhotoFileName = (string)rdr["ThumbnailPhotoFileName"];
                    product.LargePhoto = null; //TODO Read into byte array
                    product.LargePhotoFileName = (string)rdr["LargePhotoFileName"];
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

            return product;
        }


    }
}
