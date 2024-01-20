using System;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson4
{
    public class LogsSender : MonoBehaviour
    {
        public static LogsSender Instance;

        private List<AbstractLogger> _loggers = new List<AbstractLogger>();

        private float currentTime;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Update()
        {
            currentTime += Time.deltaTime;
            if (currentTime > 1)
            {
                currentTime = 0;

                foreach (var logger in _loggers)
                {
                    logger.Print("hi");
                }
            }
        }
        public void Register(AbstractLogger logger)
        {
            _loggers.Add(logger);
        }
    }
}
