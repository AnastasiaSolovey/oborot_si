using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerNetFramework
{
    /// <summary>
    /// Обеспечивает одновременную запись в лог и вывод сообщения в консоль
    /// </summary>
    public class ConsoleFileLogger:FileLogger
    {
        /// <summary>
        /// Записать сообщение в лог-файл. Файл создаётся в файле проекта по следующему пути Log\Log.txt. 
        /// Также сообщение будет выведено в консоли.
        /// </summary>
        /// <param name="message">Сообщение, которое будет записано и выведено</param>
        public static void WriteLine(string message)
        {
            try
            {
                string Timestamp = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.ff");

                Console.WriteLine($"@{Timestamp} || {message}");

                if (!Directory.Exists(FileDirectory))
                {
                    Directory.CreateDirectory(FileDirectory);
                }

                using (StreamWriter streamWriter = new StreamWriter($"{FileDirectory}\\{FileName}", true))
                {
                    streamWriter.WriteLine($"@{Timestamp} || {message}");
                    streamWriter.Close();
                }
            }
            catch
            {
                Console.WriteLine($"@Ошибка при записи лога");
            }
            
        }
    }
}
