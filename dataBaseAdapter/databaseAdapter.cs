using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBaseAdapter
{
    public class databaseAdapter
    {
        internal class DatabaseOborotSI
        {
            /*   /// <summary>
               /// Получить список объектов из БД
               /// </summary>
               /// <typeparam name="T">Тип данных</typeparam>
               /// <param name="query">Запрос к БД</param>
               /// <returns>Возвращает List с объектами типa T</returns>
               List<T> GetListDataByQuery<T>(string query);

               /// <summary>
               /// Получить объект из БД
               /// </summary>
               /// <typeparam name="T">Тип данных</typeparam>
               /// <param name="query">Запрос к БД</param>
               /// <returns>Возвращает объект типа T</returns>
               T GetObjectDataByQuery<T>(string query);

               /// <summary>
               /// Отправить в БД запрос действия (добавление, изменение, удаление)
               /// </summary>
               /// <param name="query">Запрос к БД</param>
               /// <returns>Возвращает статус запроса. True - успех, false - неудача</returns>
               bool ExecuteActionQuery(string query);

               /// <summary>
               /// Отправить в БД запрос действия (добавление, изменение, удаление), содержащий файл
               /// 
               /// !!! ВАЖНО !!! В MySQL место вставки файла записывается как @FilePayload
               /// Пример: INSERT INTO documents (doc_name, file_data) VALUES ('dummy', @FilePayload)
               /// </summary>
               /// <param name="query">Запрос в БД. 
               /// !!! ВАЖНО !!! В MySQL место вставки файла записывается как @FilePayload
               /// Пример: INSERT INTO documents (doc_name, file_data) VALUES ('dummy', @FilePayload)</param>
               /// <param name="byteData">Данные файла</param>
               /// <returns>Возвращает статус запроса. True - успех, false - неудача</returns>
               bool ExecuteActionQuery(string query, byte[] byteData);

               /// <summary>
               /// Получить скалярное значение из БД
               /// </summary>
               /// <typeparam name="T">Тип данных</typeparam>
               /// <param name="query">Запрос к БД</param>
               /// <returns>Возвращает скалярное значение типа T</returns>
               T GetScalarQuery<T>(string query);

               /// <summary>
               /// Получить DataTable из БД
               /// </summary>
               /// <param name="query">Запрос к БД</param>
               /// <returns>Возвращает DataTable, если не удалось выполнить запрос - возвращает null</returns>
               DataTable GetDataTableQuery(string query); */
        }
    }
}
