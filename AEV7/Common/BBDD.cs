using AEV7.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7
{


    public static class BBDD
    {
        private static string connectionString = $"datasource=localhost;"
            + $"port=3306;"
            + $"username=root;"
            + $"password=;"
            + $"database=aev7_empleados;";


        private static bool connectionWorking;
        private static string errorProduced;
        private static List<ArrayList> dataRows;
        public static bool ConnectionWorking => connectionWorking;
        public static string ErrorProduced => errorProduced;
        public static List<ArrayList> DataRows => dataRows;

        //SELECT QUERIES
        public static List<ArrayList> Leer(string querySQL)
        {
            connectionWorking = true;
            errorProduced = "";

            dataRows = new List<ArrayList>();

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(querySQL, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    ArrayList data = new ArrayList();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        data.Add(reader[i]);
                    }
                    dataRows.Add(data);
                }
            }
            catch (MySqlException ex)
            {
                connectionWorking = false;
                if (ex.Message.Contains("Unable to connect to any of the specified MySQL hosts"))
                    errorProduced = "No hay conexión con los servidores";
                else
                    errorProduced = ex.Message;

                //dataRows.Add(data);
            }
            databaseConnection.Close();
            return dataRows;
        }


        //INSERT, UPDATE, DELETE QUERIES
        /// <summary>
        /// Ejecuta la consulta pasada por parámetro de Insert, Update o Delete.
        /// </summary>
        /// <param name="querySQL">Parámetro SQL Query (Insert, Update, Delete).</param>
        /// <returns>Devuelve 'True' si se ha visto afectada alguna fila.</returns>
        public static bool Escribir(string querySQL)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                MySqlCommand commandDatabase = new MySqlCommand(querySQL, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    int rowsAffected = commandDatabase.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        return true;
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
        }


        public static bool Escribir(string querySQL, Image imgSource)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                MySqlCommand commandDatabase = new MySqlCommand(querySQL, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    commandDatabase.Parameters.AddWithValue("Imagen", ImgByteConverter.ImageToByte(imgSource)); //new Bitmap(imgPath)

                    databaseConnection.Open();
                    int retorno = commandDatabase.ExecuteNonQuery();
                    if (retorno > 0)
                        return true;
                    else
                        return false;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
