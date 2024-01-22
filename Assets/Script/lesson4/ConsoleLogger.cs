using UnityEngine;

namespace Lesson4
{
    public class ConsoleLogger : AbstractLogger
    {
        [SerializeField] private LogsSender _logsSender;

        public override void Print (string log)
        {
            Debug.Log(log);
        }

        private void Awake ()
        {
            _logsSender.Register(this);
        }
    }
}