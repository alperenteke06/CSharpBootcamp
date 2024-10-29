using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Ado.NET
			string processNumber;
			Console.WriteLine("***** C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("-------------------------------------------------------");
			Console.WriteLine("1-) Kategoriler");
			Console.WriteLine("2-) Ürünler");
			Console.WriteLine("3-) Siparişler");
			Console.WriteLine("4-) Çıkış Yap");
			Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz: ");
			processNumber = Console.ReadLine();
			Console.WriteLine("-------------------------------------------------------");

			SqlConnection conn = new SqlConnection("Data Source=ALPERENTEKE; Initial Catalog=BootcampDB; integrated security=true");
			conn.Open();
			SqlCommand cmd = new SqlCommand("SELECT * FROM TblCategory", conn);
			SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			conn.Close();
		
			foreach(DataRow row in dataTable.Rows)
			{
				foreach(var item in row.ItemArray)
				{
                    Console.Write($"{item.ToString()}");
				}
                Console.WriteLine();
			}
			Console.Read();
		}
	}
}
