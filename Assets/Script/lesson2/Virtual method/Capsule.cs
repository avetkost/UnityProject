using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Capsule : VirtualRotate
    {
        protected override void ShapeRotate()
        {
            transform.rotation = Quaternion.Euler(transform.eulerAngles.x, targetRotation.y, transform.eulerAngles.z);            
        }
    }
}