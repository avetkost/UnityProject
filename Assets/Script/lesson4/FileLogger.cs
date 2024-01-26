using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

namespace Lesson4
{
    public class FileLogger : AbstractLogger
    {
        [SerializeField] private LogsSender logsSender;

        private float MyTimer;

        private string path = Application.dataPath + "@Script\\lesson4\\AbsLog.txt";
        private void Awake()
        {
            Debug.Log(path);
            if(!File.Exists(path)) 
            {
                File.Create(path);
            }
            File.WriteAllText(path, "");
            logsSender.Register(this);
        }
        public override void Print(string log)
        {
            MyTimer += Time.deltaTime; 
            if (MyTimer >= 1f)
            {
            MyTimer %= 1f;
            log = log + "\n";
            }
            File.AppendAllText(path, log);
        }
    }
}