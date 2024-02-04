using UnityEngine;
using System.IO;
using System;
using System.Text;

namespace Lesson5
{
    public class FileLogger : MonoBehaviour
    {
        [SerializeField] private LogType logType;
        private string path = Path.Combine(Application.dataPath, "Script", "lesson5", "RLog.txt");
        [SerializeField] private ReactiveLogger reactiveLogger;
        private StringBuilder logBuffer = new StringBuilder();

        private void Start ()
        {
            reactiveLogger.OnLog += Print;
        }

        private void Awake ()
        {
            if(!File.Exists(path)) 
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
        }

        public void Print (LogType logsType, string log)
        {
            if (logsType != LogType.Error) return;
            logBuffer.AppendLine(log);
            File.AppendAllText(path,log);
            
        }

        // private void Update()
        // {
        //     if (logBuffer.Length > 0)
        //     {
        //         File.AppendAllText(path, logBuffer.ToString());
        //         logBuffer.Clear();
        //     }
        // }
    }
}