using System;
using UnityEngine;

namespace Lesson4
{
    public class ConsoleLogger : AbstractLogger
    {
        private void Awake()
        {
            LogsSender.Instance.Register(this);
        }

        public override void Print(string log)
        {
            Debug.Log($"{log} \n {DateTime.Now} \n Logger class: {GetType().Name}");
        }
    }
}
