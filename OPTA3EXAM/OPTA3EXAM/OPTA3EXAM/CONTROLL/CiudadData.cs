using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using EXA3.MODELOS;
using EXA3.CONTROLL;
using WebApi.Data;
using System.Security.Cryptography;
using System;

namespace EXA3.CONTROLL
{
    public class CiudadData
    {
        

        public static bool Registrar (Ciuadd oCiudadd)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                string insertQuery = "INSERT INTO Ciudad (ID, Ciudad, Departamento,Codigo_Postal ) VALUES (@c1, @c2, @c3, @c4)";

                SqlCommand cmd = new SqlCommand(insertQuery, oConexion);
                
                cmd.Parameters.AddWithValue("@c1",'2');
                cmd.Parameters.AddWithValue("@c2",'2');
                cmd.Parameters.AddWithValue("@c3",'2');
                cmd.Parameters.AddWithValue("@c4",'2');
                

                using (SqlCommand command = new SqlCommand(insertQuery, oConexion))
                
                //var conn = conexion.GetConexion();
                //var comando = new Npgsql.NpgsqlCommand("INSERT INTO ciudad(idCiudad, Descripcion, nombre_corto, estado)" +
                //                                    "VALUES(@idCiudad, @descripcion, @nombre_corto, @estado)", conn);
                //comando.Parameters.AddWithValue("descripcion", ciudad.descripcion);
                //comando.Parameters.AddWithValue("nombre_corto", ciudad.nombre_corto);
                //comando.Parameters.AddWithValue("estado", ciudad.estado);
                //comando.Parameters.AddWithValue("idCiudad", ciudad.idCiudad);

                //comando.ExecuteNonQuery();

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }



            }
        }
        ////modificar
        //public static bool Modificar(Ciudadd oCiudadd)
        //{
        //    using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
        //    {
        //        SqlCommand cmd = new SqlCommand("cp_editcity", oConexion);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ID", oCiudadd.ID);
        //        cmd.Parameters.AddWithValue("@Ciudad", oCiudadd.Ciudad);


        //        try
        //        {
        //            oConexion.Open();
        //            cmd.ExecuteNonQuery();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }
        //}


        //public static List<Ciudadd> Listar()
        //{
        //    List<Ciudadd> oListaUsuario = new List<Ciudadd>();
        //    using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
        //    {
        //        SqlCommand cmd = new SqlCommand("cp_listarcity", oConexion);
        //        cmd.CommandType = CommandType.StoredProcedure;

        //        try
        //        {
        //            oConexion.Open();
        //            cmd.ExecuteNonQuery();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {

        //                while (dr.Read())
        //                {
        //                    oListaUsuario.Add(new Ciudadd()
        //                    {
        //                        ID = Convert.ToInt32(dr["ID"]),
        //                        Ciudad = dr["Ciuadad"].ToString(),


        //                    });
        //                }

        //            }



        //            return oListaUsuario;
        //        }
        //        catch (Exception ex)
        //        {
        //            return oListaUsuario;
        //        }
        //    }
        //}

        //public static Ciudadd Obtener(int ID)
        //{
        //    Ciudadd oCiudadd = new Ciudadd();
        //    using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
        //    {
        //        SqlCommand cmd = new SqlCommand("cp_obtenercity", oConexion);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ID", ID);

        //        try
        //        {
        //            oConexion.Open();
        //            cmd.ExecuteNonQuery();

        //            using (SqlDataReader dr = cmd.ExecuteReader())
        //            {

        //                while (dr.Read())
        //                {
        //                    oCiudadd = new Ciudadd()
        //                    {

        //                        ID = Convert.ToInt32(dr["ID"]),
        //                        Ciudad = dr["Ciudad"].ToString(),

        //                    };
        //                }

        //            }



        //            return oCiudadd;
        //        }
        //        catch (Exception ex)
        //        {
        //            return oCiudadd;
        //        }
        //    }
        //}
        //public static bool Eliminar(int ID)
        //{
        //    using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
        //    {
        //        SqlCommand cmd = new SqlCommand("cp_eliminarcity", oConexion);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@ID", ID);

        //        try
        //        {
        //            oConexion.Open();
        //            cmd.ExecuteNonQuery();
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}