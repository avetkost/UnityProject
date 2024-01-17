using Lesson2;
using UnityEngine;

namespace Lesson2
{
    public class Cube : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation
        public void Rotate()
        {
            tramsform.rotation = Quaternion.Euler(targetRotation);
        }

        
    }
}