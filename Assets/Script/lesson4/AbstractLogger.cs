using UnityEngine;

namespace Lesson4
{
    public abstract class AbstractLogger : MonoBehaviour
    {
        // Метод для вывода лога
        public abstract void Print(string log);

        // Строковое свойство, добавляющее дополнительную информацию от инспектора в сообщение журнала
        [SerializeField] protected string logInfo;
    }
}