using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAdapter
{
    public static class DataConverter
    {
        /// <summary>
        /// Конвертировать поле строки в значение типа T
        /// </summary>
        /// <typeparam name="T">Тип данных</typeparam>
        /// <param name="input">Поле с данными</param>
        /// <returns></returns>
        public static T Convert<T>(object input)
        {
            try
            {
                if (input != DBNull.Value)
                {
                    return (T)System.Convert.ChangeType(input, typeof(T));
                }
                else
                {
                    return default(T);
                }

            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
