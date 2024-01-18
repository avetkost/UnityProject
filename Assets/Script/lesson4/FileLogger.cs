using System;
using System.IO;
using UnityEngine;

namespace Lesson4
{
    // Класс для логирования в файл
    public class FileLogger : AbstractLogger
    {
        private string filePath;

        private void Awake()
        {
            filePath = Path.Combine(Application.dataPath, "Log.txt");
            LogsSender.Instance.Register(this);
        }

        public override void Print(string log)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write($"{log} \n {DateTime.Now} \n Logger class: {GetType().Name} \n Additional Info: {additionalInfo}");
                }
            }
            catch (IOException e)
            {
                Debug.LogError($"Error writing to the file: {e.Message}");
            }
        }
    }
}
