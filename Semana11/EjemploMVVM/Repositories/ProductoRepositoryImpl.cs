using EjemploMVVM.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace EjemploMVVM.Repositories
{
    public class ProductoRepositoryImpl : IProductoRepository
    {
        public List<Producto> ObtenerTodos()
        {
            string cn = "Server=.;Database=Northwind;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conex = new SqlConnection(cn))
            {
                conex.Open();
                string query = "SELECT ProductID,ProductName,UnitPrice,Discontinued From Products";

                SqlCommand command = new SqlCommand(query, conex);

                SqlDataReader reader = command.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                List<Producto> listaProductos = new List<Producto>();
                while (reader.Read())
                {
                    Producto producto = new Producto
                    {
                        Id = reader.GetInt32(0),
                        nombre=reader.GetString(1),
                        precio = reader.GetDecimal(2),
                        discontinuado = reader.GetBoolean(3)
                    };
                    listaProductos.Add(producto);
                }
                return listaProductos;
            }
        }
    }
}
