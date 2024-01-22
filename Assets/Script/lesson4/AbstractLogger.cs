using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson4
{
    public abstract class AbstractLogger : MonoBehaviour
    {
        [SerializeField] protected string logInfo;

        public abstract void Print(string log);

    }
}