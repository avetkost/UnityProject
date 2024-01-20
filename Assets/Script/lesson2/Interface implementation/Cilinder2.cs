using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Cylinder2 : MonoBehaviour, IRotatable
    {
        [SerializeField] private Vector3 targetRotation;
        public void Rotate()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);
        }
    }
}