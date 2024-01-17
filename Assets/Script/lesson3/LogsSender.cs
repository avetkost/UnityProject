using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson3
{
   public class LogsSender : MonoBehaviour
{
    private List<ILogger> _loggers = new List<ILogger>();

    void Update()
    {
        foreach (var logger in _loggers)
        {
            logger.Print("good");
        }
    }

    public void Register(ILogger logger)
    {
        _loggers.Add(logger);
    }
}

}