using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Logger
{
    public class LogsSender : MonoBehaviour
    {
        private List<ILogger> _loggers = new List<ILogger>();


        private float currentTime;
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
        public void Register(ILogger logger)
        {
            _loggers.Add(logger);
        }
    }
}