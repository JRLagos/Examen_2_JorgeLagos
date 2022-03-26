using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class ProductoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=Jorge2022;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public DataTable ListarProductos()
        {
            DataTable lista = new DataTable();

            try
            {
                string sql = "SELECT * FROM producto;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                lista.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return lista;
        }

        public bool InsertarProducto(Producto producto)
        {
            bool inserto = false;
            try
            {
                string sql = "INSERT INTO producto VALUES (@IdProducto, @Nombre, @Precio, @Existencia);";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.ExecuteNonQuery();
                inserto = true;

                conn.Close();
            }
            catch (Exception)
            {
            }
            return inserto;
        }

        public bool ModificarProducto(Producto producto)
        {
            bool modifico = false;
            try
            {
                string sql = "UPDATE producto SET IdProducto = @IdProducto, Nombre = @Nombre, " +
                             "Precio = @Precio, Existencia = @Existencia WHERE IdProducto = @IdProducto;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProducto", producto.IdProducto);
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Existencia", producto.Existencia);
                cmd.ExecuteNonQuery();
                modifico = true;
                conn.Close();
            }
            catch (Exception)
            {
            }
            return modifico;
        }

        public bool EliminarProducto(string IdProducto)
        {
            bool elimino = false;
            try
            {
                string sql = "DELETE FROM producto WHERE IdProducto = @IdProducto;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@IdProducto", IdProducto);

                cmd.ExecuteNonQuery();
                elimino = true;
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return elimino;
        }

    }
}
