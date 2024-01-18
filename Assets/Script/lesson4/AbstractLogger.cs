using UnityEngine;

namespace Lesson4
{
    // Абстрактный класс для логгеров
    public abstract class AbstractLogger : MonoBehaviour
    {
        [SerializeField]
        protected string additionalInfo; // Строковое поле для дополнительной информации из инспектора

        // Метод для вывода лога
        public abstract void Print(string log);
    }
}
