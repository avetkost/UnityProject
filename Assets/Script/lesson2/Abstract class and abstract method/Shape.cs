using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
namespace Lesson2
{
    public abstract class AbstractShape : MonoBehaviour
    {
        [SerializeField] protected Vector3 targetRotation;

        protected abstract void RotateShape();
        void Update()
        {
            RotateShape();
        }

        
    }

}



