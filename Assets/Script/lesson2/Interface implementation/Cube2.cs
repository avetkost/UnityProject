using Lesson2;
using UnityEngine;

namespace Lesson2
{
    public class Cube2 : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation;
        public void Rotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }

        
    }
}