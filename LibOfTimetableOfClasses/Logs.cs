using System;
using System.IO;

namespace LibOfTimetableOfClasses
{
    static public class Logs
    {
        /// <summary>
        /// Поле info класса Logs
        /// </summary>
        static string info;
        /// <summary>
        /// Поле error класса Logs
        /// </summary>
        static string error;

        /// <summary>
        /// Метод получает ошибку
        /// </summary>
        static public void GetError(Exception ex)
        {
            string time = string.Format("{0:dd.MM.yyy HH:mm:ss.fff}", DateTime.Now); //Получаем текущее время в формате день, год  часы, минуты, секунды.
            error = string.Format("DEBUG | {0} | [HResult: {1}]  [Message: {2}]  [TargetSite.DeclaringType: {3}]  [TargetSite.Name: {4}]  [Data: {5}]",
                time, ex.HResult, ex.Message, ex.TargetSite.DeclaringType, ex.TargetSite.Name, ex.Data);//Создаём строку с данными об ошибке 
            Write(error);//Выводим сообщение об ошибке
        }

        /// <summary>
        /// Метод получает информацию о дествии пользователя
        /// </summary>
        static public void GetInfo(string _info)
        {
            string time = string.Format("{0:dd.MM.yyy HH:mm:ss.fff}", DateTime.Now); //Получаем текущее время в формате день, год  часы, минуты, секунды.
            info = string.Format("INFO  | {0} | {1}", time, _info); //Получаем строку с датой и действием пользователя
            Write(info);//Выводим на экран
        }

        /// <summary>
        /// <para>Метод получает INFO или ERROR и записывает в файл Logs.txt</para>
        /// Путь к файлу: TimetableOfClasses\bin\Debug\Logs.txt
        /// </summary>
        static private void Write(string msg)
        {
            string path = @"Logs.txt"; //Создаём путь файла с логами
            using (FileStream file = new FileStream(path, FileMode.Append)) //Создаём объект, считывающий файл
            using (StreamWriter writeInfo = new StreamWriter(file)) //Создаём объект, записывающий данный файл
                writeInfo.WriteLine(msg);//Записываем полученную ошибку в файл
        }
    }
}
