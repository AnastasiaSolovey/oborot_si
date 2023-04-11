using DatabaseAdapter.BasicMethods;
using LoggerNetFramework;
using System;
using System.Collections.Generic;
using System.Data;

namespace DatabaseAdapter
{
    public class MySqlAdapter:IDatabaseAdapter
    {
        private MySqlBasicMethods BaseDB;
        private bool needToWriteLog = true;

        /// <summary>
        /// Создание экземпляра адаптера для работы с базой данных MySQL
        /// </summary>
        /// <param name="connectionString">Строка подключения к бд</param>
        /// <param name="writeLogData">Флаг необходимости записи лога. По умолчанию - true</param>
        public MySqlAdapter(string connectionString, bool writeLogData = true)
        {
            BaseDB = new MySqlBasicMethods(connectionString, needToWriteLog);
            this.needToWriteLog = writeLogData;
        }


        /// <summary>
        /// Получить список объектов из БД
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="query">Запрос к БД</param>
        /// <returns>Возвращает List с объектами типa T</returns>
        public List<T> GetListDataByQuery<T>(string query)
        {
            try
            {
                List<T> outList = new List<T>();

                DataTable dt = new DataTable();
                dt = BaseDB.ExecuteDataTableQuery(query);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    T outputObject = (T)Activator.CreateInstance(typeof(T), new object[] { dt.Rows[i] });
                    outList.Add(outputObject);
                }

                return outList;
            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log($"Не удалось получить список объектов класса {typeof(T).Name}.\n" + ex.Message);
                return null;
            }

        }

        /// <summary>
        /// Получить объект из БД
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="query">Запрос к БД</param>
        /// <returns>Возвращает объект типа T</returns>
        public T GetObjectDataByQuery<T>(string query)
        {
            try
            {
                T outputObject = default(T);

                DataTable dt = new DataTable();
                dt = BaseDB.ExecuteDataTableQuery(query);
                if (dt.Rows.Count > 0)
                {
                    outputObject = (T)Activator.CreateInstance(typeof(T), new object[] { dt.Rows[0] });
                }

                return outputObject;
            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log($"Не удалось получить список объектов класса {typeof(T).Name}.\n" + ex.Message);
                return default(T);
            }

        }

        /// <summary>
        /// Отправить в БД запрос действия (добавление, изменение, удаление)
        /// </summary>
        /// <param name="query">Запрос к БД</param>
        /// <returns>Возвращает статус запроса. True - успех, false - неудача</returns>
        public bool ExecuteActionQuery(string query)
        {
            try
            {
                if (BaseDB.ExecuteActionQuery(query))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log("Ошибка при исполнении запроса действия.\n" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Отправить в БД запрос действия (добавление, изменение, удаление), содержащий файл
        /// </summary>
        /// <param name="query">Запрос в БД. 
        /// !!! ВАЖНО !!! В MySQL место вставки файла записывается как @FilePayload
        /// Пример: INSERT INTO documents (doc_name, file_data) VALUES ('dummy', @FilePayload)</param>
        /// <param name="byteData">Данные файла</param>
        /// <returns>Возвращает статус запроса. True - успех, false - неудача</returns>
        public bool ExecuteActionQuery(string query, byte[] byteData)
        {
            try
            {
                if (BaseDB.ExecuteSendFileQuery(query, byteData))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log("Ошибка при исполнении запроса действия с файлом.\n" + ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Получить скалярное значение из БД
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="query">Запрос к БД</param>
        /// <returns>Возвращает скалярное значение типа T</returns>

        public T GetScalarQuery<T>(string query)
        {
            try
            {
                T scalar = default(T);
                object result = BaseDB.ExecuteScalarQuery(query);
                scalar = (T)Convert.ChangeType(result, typeof(T));
                return scalar;
            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log("Ошибка при исполнении запроса со скалярным результатом.\n" + ex.Message);
                return default(T);
            }
        }

        /// <summary>
        /// Получить DataTable из БД
        /// </summary>
        /// <param name="query">Запрос к БД</param>
        /// <returns>Возвращает DataTable, если не удалось выполнить запрос - возвращает null</returns>
        public DataTable GetDataTableQuery(string query)
        {
            try
            {
                return BaseDB.ExecuteDataTableQuery(query);
            }
            catch (Exception ex)
            {
                if (needToWriteLog)
                    FileLogger.Log("Ошибка при исполнении запроса с табличным результатом.\n" + ex.Message);
                return new DataTable();
            }
        }
    }
}