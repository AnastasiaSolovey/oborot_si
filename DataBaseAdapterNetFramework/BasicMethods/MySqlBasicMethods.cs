using MySql.Data.MySqlClient;
using LoggerNetFramework;
using System.Data;
using System.Diagnostics;
using System;

namespace DatabaseAdapter.BasicMethods
{
    internal class MySqlBasicMethods
    {
        private MySqlConnection conn;
        private bool needToWriteLog = true;

        /// <summary>
        /// Инициализация соединения и базовых методов для работы с БД mysql
        /// </summary>
        /// <param name="connectionString">Строка подключения к БД</param>
        /// <param name="writeLogData">Флаг включения записи лога в файд</param>
        public MySqlBasicMethods(string connectionString, bool writeLogData)
        {
            this.conn = new MySqlConnection(connectionString);
            this.needToWriteLog = writeLogData;
        }

        /// <summary>
        /// Запрос для получения DataTable из БД
        /// </summary>
        /// <param name="query">Запрос к БД</param>
        /// <returns></returns>
        public DataTable ExecuteDataTableQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                conn.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "outputTable";
                return dt;
            }
            catch (Exception ex)
            {
                conn.Close();
                if(needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Получение скалярного значения из БД
        /// </summary>
        /// <param name="query">Запрос к БД</param>
        /// <returns></returns>
        public object ExecuteScalarQuery(string query)
        {
            try
            {

                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                object scalar = command.ExecuteScalar();
                conn.Close();
                return scalar;

            }
            catch (Exception ex)
            {
                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// Выполнение запроса действия
        /// </summary>
        /// <param name="query">Запрос к БД</param>
        /// <returns></returns>
        public bool ExecuteActionQuery(string query)
        {
            try
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {

                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// Выполнение запроса действия через команду MySQL
        /// </summary>
        /// <param name="cmd">Команда MySQL</param>
        /// <returns></returns>
        public bool ExecuteActionQuery(MySqlCommand cmd)
        {
            try
            {
                MySqlCommand command = cmd;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            catch (Exception ex)
            {

                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return false;
            }
        }


        /// <summary>
        /// Получение скалярного значения из БД через команду MySQL
        /// </summary>
        /// <param name="cmd">Команда MySQL</param>
        /// <returns></returns>
        public object ExecuteScalarQuery(MySqlCommand cmd)
        {
            try
            {

                MySqlCommand command = cmd;
                conn.Open();
                object scalar = command.ExecuteScalar();
                conn.Close();
                return scalar;

            }
            catch (Exception ex)
            {
                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Получение DataTable из БД через команду MySQL
        /// </summary>
        /// <param name="cmd">Команда MySQL</param>
        /// <returns></returns>
        public DataTable ExecuteDataTableQuery(MySqlCommand cmd)
        {
            try
            {

                MySqlCommand command = cmd;
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                conn.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "outputTable";
                return dt;

            }
            catch (Exception ex)
            {
                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Запрос на отправку файла в БД
        /// </summary>
        /// <param name="query">Запрос в БД. !!! ВАЖНО !!! В запросе место вставки файла записывается как @FilePayload
        /// Пример: INSERT INTO documents (doc_name, file_data) VALUES ('dummy', @FilePayload)</param>
        /// <param name="FilePayload">Содержимое файла</param>
        /// <returns></returns>
        public bool ExecuteSendFileQuery(string query, byte[] FilePayload)
        {
            try
            {

                MySqlCommand command = new MySqlCommand("", conn);
                command.CommandText = query;

                MySqlParameter file = new MySqlParameter("@FilePayload", MySqlDbType.Blob, FilePayload.Length);
                file.Value = FilePayload;

                command.Parameters.Add(file);

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                return true;

            }
            catch (Exception ex)
            {
                conn.Close();
                if (needToWriteLog)
                    FileLogger.Log($"Произошла ошибка при обращении к БД. {Environment.NewLine}{ex.Message}");
                return false;
            }
        }
    }
}