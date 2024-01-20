using UnityEngine;
using UnityEngine.UI;
using System;


namespace Lesson4
{
    public class UITextLogger : AbstractLogger
    {
        [SerializeField] private Text textLogger;

        private void Awake()
        {
            LogsSender.Instance.Register(this);
        }

        public override void Print(string log)
        {
            textLogger.text = $"{log} \n {DateTime.Now}";
        }
    }
}

