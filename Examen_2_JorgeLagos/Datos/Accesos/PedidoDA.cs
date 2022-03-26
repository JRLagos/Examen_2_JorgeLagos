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
    public class PedidoDA
    {
        readonly string cadena = "Server=localhost; Port=3306; Database=examen2; Uid=root; Pwd=Jorge2022;";

        MySqlConnection conn;
        MySqlCommand cmd;

        public int InsertarFactura(Pedido pedido)
        {
            int IdPedido = 0;
            try
            {
                string sql = "INSERT INTO pedido (NombreCliente, Cantidad, SubTotal, Isv, TotalPagar) VALUES (@NombreCliente, @Cantidad, @SubTotal, @Isv, @TotalPagar); select last_insert_id();";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NombreCliente", pedido.NombreCliente);
                cmd.Parameters.AddWithValue("@Cantidad", pedido.Cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", pedido.SubTotal);
                cmd.Parameters.AddWithValue("@Isv", pedido.Isv);
                cmd.Parameters.AddWithValue("@TotalPagar", pedido.TotalPagar);
                IdPedido = Convert.ToInt32(cmd.ExecuteScalar());


                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return IdPedido;
        }

        public DataTable ListarPedido()
        {
            DataTable listaPedido = new DataTable();

            try
            {
                string sql = "SELECT * FROM pedido;";
                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);

                MySqlDataReader reader = cmd.ExecuteReader();
                listaPedido.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
            }
            return listaPedido;
        }

    }
}
