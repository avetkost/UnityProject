using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Capsule2 : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation; 
        public void Rotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation.x, transform.eulerAngles.y, transform.eulerAngles.z);
        }    
    }
}  