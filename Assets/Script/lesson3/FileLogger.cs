using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Logger
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
            File.WriteAllText(filePath, string.Empty);

            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.Write(log + $"\n {System.DateTime.Now} \n {this}");
            }

        }

        public override string ToString()
        {
            return $"FileLogger at {gameObject.name}";
        }
    }
}
