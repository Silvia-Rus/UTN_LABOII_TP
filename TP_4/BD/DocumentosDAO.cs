using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;
using System.Diagnostics;

namespace BD
{
    public class DocumentosDAO
    {

        private static SqlConnection connection;
        private static SqlCommand command;
        private static string connectionString = "Server = .; Database=BlaBlaBla; Trusted_Connection=true";

        /// <summary>
        /// Sincroniza una base de datos con la aplicación.
        /// </summary>
        /// <returns></returns>
        public static List<Documento> GetAllDocumentos()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM Documentos", connection))
                {
                    try
                    {
                        List<Documento> listaDocumentos = new List<Documento>();
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        using (SqlDataReader dataReader = cmd.ExecuteReader())
                        {
                            while (dataReader.Read())
                            {                                                          
                                switch(dataReader["TipoDeDocumento"].ToString())
                                {
                                    case "Libro":
                                    Libro documento = new Libro
                                    {
                                        Barcode = Convert.ToInt32(dataReader["Barcode"]),
                                        Titulo = dataReader["Titulo"].ToString(),
                                        Autor = dataReader["Autor"].ToString(),
                                        Anio = Convert.ToInt16(dataReader["AnioPublicacion"]),
                                        NumeroPaginas = Convert.ToInt16(dataReader["NumeroPaginas"]),
                                        Id = dataReader["Id"].ToString(),
                                        Notas = dataReader["Notas"].ToString(),
                                        EstadoEncuadernacion = (Entidades.Encuadernacion)Enum.Parse(typeof(Entidades.Encuadernacion), dataReader["EstadoEncuadernacion"].ToString()),
                                        FaseProceso = (Entidades.PasosProceso)Enum.Parse(typeof(Entidades.PasosProceso), dataReader["PasoProceso"].ToString()),
                                        FechaCarga = Convert.ToDateTime(dataReader["FechaCarga"]),
                                        FechaDistribucion = Convert.ToDateTime(dataReader["FechaDistribucion"]),
                                        FechaGuillotinado = Convert.ToDateTime(dataReader["FechaGuillotinado"]),
                                        FechaEscaneo = Convert.ToDateTime(dataReader["FechaEscaneo"]),
                                        FechaAprobacion = Convert.ToDateTime(dataReader["FechaAprobacion"])
                                    };
                                        listaDocumentos.Add(documento);
                                        break;
                                    case "Articulo":
                                        Articulo articulo = new Articulo
                                        {
                                            Barcode = Convert.ToInt32(dataReader["Barcode"]),
                                            Titulo = dataReader["Titulo"].ToString(),
                                            Autor = dataReader["Autor"].ToString(),
                                            Anio = Convert.ToInt16(dataReader["AnioPublicacion"]),
                                            NumeroPaginas = Convert.ToInt16(dataReader["NumeroPaginas"]),
                                            Id = dataReader["Id"].ToString(),
                                            Notas = dataReader["Notas"].ToString(),
                                            Fuente = dataReader["Fuente"].ToString(),
                                            EstadoEncuadernacion = (Entidades.Encuadernacion)Enum.Parse(typeof(Entidades.Encuadernacion), dataReader["EstadoEncuadernacion"].ToString()),
                                            FaseProceso = (Entidades.PasosProceso)Enum.Parse(typeof(Entidades.PasosProceso), dataReader["PasoProceso"].ToString()),
                                            FechaCarga = Convert.ToDateTime(dataReader["FechaCarga"].ToString()), //EXCEPCIÓN OVERLOAD
                                            FechaDistribucion = Convert.ToDateTime(dataReader["FechaDistribucion"]),
                                            FechaGuillotinado = Convert.ToDateTime(dataReader["FechaGuillotinado"]),
                                            FechaEscaneo = Convert.ToDateTime(dataReader["FechaEscaneo"]),
                                            FechaAprobacion = Convert.ToDateTime(dataReader["FechaAprobacion"]),                                   
                                            
                                        };
                                        listaDocumentos.Add(articulo);
                                        break;                                                              
                                }
                            }
                        }
                        return listaDocumentos;
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                        throw ex;                     
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Añade los datos de un documento nuevo a la base de datos.
        /// </summary>
        /// <param name="tipoDeDocumento"></param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="anio"></param>
        /// <param name="numeroPaginas"></param>
        /// <param name="id"></param>
        /// <param name="barcode"></param>
        /// <param name="notas"></param>
        /// <param name="estadoEncuadernacion"></param>
        /// <param name="pasoProceso"></param>
        /// <param name="fechaCarga"></param>
        /// <param name="fechaDistribucion"></param>
        /// <param name="fechaGuillotinado"></param>
        /// <param name="fechaEscaneo"></param>
        /// <param name="fechaRevision"></param>
        /// <param name="fechaAprobacion"></param>
        /// <param name="fuente"></param>
        /// <returns></returns>
        public static bool GuardarDocumentos(string tipoDeDocumento, string titulo, string autor, short anio, short numeroPaginas, string id, int barcode, string notas,
                                      Encuadernacion estadoEncuadernacion, PasosProceso pasoProceso,
                                      string fechaCarga, string fechaDistribucion, string fechaGuillotinado, string fechaEscaneo, string fechaRevision, string fechaAprobacion,
                                      string fuente)
        {

            bool retorno = false;
            try
            {
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "INSERT INTO Documentos (TipoDeDocumento,Barcode,Titulo,Autor,AnioPublicacion,NumeroPaginas,[Id],Notas,Fuente,EstadoEncuadernacion,pasoProceso, FechaCarga,FechaDistribucion,FechaGuillotinado,FechaEscaneo,FechaRevision,FechaAprobacion) " +
                    "VALUES (@TipoDocumento,@Barcode,@Titulo,@Autor,@AnioPublicacion,@NumeroPaginas,@Id,@Notas,@Fuente,@EstadoEncuadernacion,@PasoProceso,@FechaCarga,@FechaDistribucion,@FechaGuillotinado,@FechaEscaneo,@FechaRevision,@FechaAprobacion)";
               
                command.Parameters.AddWithValue("@TipoDocumento", tipoDeDocumento);
                command.Parameters.AddWithValue("@Barcode", barcode);
                command.Parameters.AddWithValue("@Titulo", titulo);
                command.Parameters.AddWithValue("@Autor", autor);
                command.Parameters.AddWithValue("@AnioPublicacion", anio);
                command.Parameters.AddWithValue("@NumeroPaginas", numeroPaginas);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Notas", notas);
                command.Parameters.AddWithValue("@EstadoEncuadernacion", estadoEncuadernacion);
                command.Parameters.AddWithValue("@PasoProceso", pasoProceso);
                command.Parameters.AddWithValue("@FechaCarga", fechaCarga);
                command.Parameters.AddWithValue("@FechaDistribucion", fechaDistribucion);
                command.Parameters.AddWithValue("@FechaGuillotinado", fechaGuillotinado);
                command.Parameters.AddWithValue("@FechaEscaneo", fechaEscaneo);
                command.Parameters.AddWithValue("@FechaRevision", fechaRevision);
                command.Parameters.AddWithValue("@FechaAprobacion", fechaAprobacion);
                command.Parameters.AddWithValue("@Fuente", fuente);

                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }

            return retorno;
        }
        /// <summary>
        /// Actualiza los datos de un documento preexistente que entra por parámetro.
        /// </summary>
        /// <param name="documento"></param>
        /// <returns></returns>
        public static bool ActualizaDocumentos(Documento documento)
        {
            bool retorno = false;
            try
            {

                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = $"UPDATE [Documentos] " +
                                          $"SET titulo = @Titulo, autor = @Autor, anioPublicacion = @AnioPublicacion, numeroPaginas = @NumeroPaginas, id = @Id, notas = @Notas," +
                                          $"estadoEncuadernacion = @EstadoEncuadernacion, pasoProceso = @PasoProceso" +
                                          $" WHERE barcode = @Barcode";

                command.Parameters.AddWithValue("@Titulo", documento.Titulo);
                command.Parameters.AddWithValue("@Autor", documento.Autor);
                command.Parameters.AddWithValue("@AnioPublicacion", documento.Anio);
                command.Parameters.AddWithValue("@NumeroPaginas", documento.NumeroPaginas);
                command.Parameters.AddWithValue("@Id", documento.Id);
                command.Parameters.AddWithValue("@Notas", documento.Notas);
                command.Parameters.AddWithValue("@EstadoEncuadernacion", documento.EstadoEncuadernacion);
                command.Parameters.AddWithValue("@PasoProceso", documento.FaseProceso);
                command.Parameters.AddWithValue("@Barcode", documento.Barcode);

                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }
        /// <summary>
        /// Actualiza las fechas de un documento preexistente.
        /// </summary>
        /// <param name="documento"></param>
        /// <returns></returns>
        public static bool ActualizaFechas(Documento documento)
        {
            bool retorno = false;
            try
            {

                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = $"UPDATE [Documentos] " +
                                          $"SET fechaCarga = @FechaCarga, fechaDistribucion = @FechaDistribucion, fechaGuillotinado = @FechaGuillotinado, fechaEscaneo = @FechaEscaneo, fechaRevision = @FechaRevision, fechaAprobacion = @FechaRevision, pasoProceso = @PasoProceso"  +
                                          $" WHERE barcode = @Barcode";

                command.Parameters.AddWithValue("@FechaCarga", documento.FechaCarga.ToString());
                command.Parameters.AddWithValue("@FechaDistribucion", documento.FechaDistribucion.ToString());
                command.Parameters.AddWithValue("@FechaEscaneo", documento.FechaEscaneo.ToString());
                command.Parameters.AddWithValue("@FechaGuillotinado", documento.FechaGuillotinado.ToString());
                command.Parameters.AddWithValue("@FechaRevision", documento.FechaRevision.ToString());
                command.Parameters.AddWithValue("@FechaAprobacion", documento.FechaAprobacion.ToString());
                command.Parameters.AddWithValue("@PasoProceso", documento.FaseProceso);
                command.Parameters.AddWithValue("@Barcode", documento.Barcode);

                connection.Open();
                command.ExecuteNonQuery();

                retorno = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return retorno;
        }

    }
}
