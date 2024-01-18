using UnityEngine;
using UnityEngine.UI;
using System;


namespace Lesson4
{
    // Класс для логирования в UI Text
    public class UITextLogger : AbstractLogger
    {
        [SerializeField]
        private Text textLogger;

        private void Awake()
        {
            LogsSender.Instance.Register(this);
        }

        public override void Print(string log)
        {
            textLogger.text = $"{log} \n {DateTime.Now} \n Logger class: {GetType().Name} \n Additional Info: {additionalInfo}";
        }
    }
}

