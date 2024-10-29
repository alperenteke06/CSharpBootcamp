using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/* CRUD -> Create, Read, Update and Delete */
			Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
			Console.WriteLine();
			Console.WriteLine("-------------------------------------");
            #region Process of Create New Category
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO TblCategory (CategoryName) VALUES (@categoryName)", conn);
            //cmd.Parameters.AddWithValue("@categoryName", categoryName);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.Write("Kategori Başarıyla Eklendi!");
            #endregion

            #region Process of Create New Product
            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("INSERT INTO TblProduct (ProductName, ProductPrice, ProductStatus) VALUES" +
            //	"(@productName, @productPrice, @productStatus)", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", 1);
            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Ürün Ekleme İşlemi Başarılı!");
            #endregion

            #region Process of List Products
            //SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("SELECT * FROM TblProduct", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //	foreach(var item in row.ItemArray)
            //	{
            //     Console.Write(item.ToString() + " ");
            //	}
            //Console.WriteLine();
            //}
            //conn.Close();
            #endregion

            #region Process of Delete a Product
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("DELETE FROM TblProduct WHERE ProductId = @productId", conn);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Console.WriteLine("Ürün Silme İşlemi Tamamlandı!");
            #endregion

            #region Process of Update a Product
            //Console.Write("Güncelleme İşlemi Yapılacak Ürün Id: ");
			//int productId = int.Parse(Console.ReadLine());
            //Console.Write("Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());
			//SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
			//conn.Open();
            //SqlCommand cmd = new SqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productId", productId);
            //cmd.ExecuteNonQuery();
            //Console.WriteLine("Güncelleme İşlemi Başarılı!");
            //conn.Close();
			#endregion

			Console.Read();
		}
	}
}
