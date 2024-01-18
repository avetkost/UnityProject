using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Lesson3
{
    public class FileLogger : MonoBehaviour, ILogger
    {
        private string fileName = "Log.txt";
        private string filePath;

        [SerializeField] LogsSender logsSender;

        private void Awake()
        {
            filePath = Path.Combine(Application.dataPath, fileName);
            logsSender.Register(this);
        }   
        public void Print(string log)
        {
            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                // Если файл не существует, создаем его
                File.Create(filePath).Close();
            }
            // Открываем файл для записи с использованием StreamWriter
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{System.DateTime.Now} - {filePath}: {log}");
            }
        }
    }
}
