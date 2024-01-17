using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Lesson2
{
    public class BaseRotate : MonoBehaviour
    {
        [SerializeField] protected Vector3 targetRotation;
        
        void Update()
        {
            ShapeRotate();
        }

        protected virtual void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }

}