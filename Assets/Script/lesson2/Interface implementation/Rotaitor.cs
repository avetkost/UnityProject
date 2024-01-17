using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson2
{
    public class Rotaitor : MonoBehaviour
    {
        [SerializeField]  private List<GameObject> rotatableGameObjects;
        private List<IRotatable> _rotatables = new();
            private void Awake()
            {
                foreach (GameObject obj in rotatableGameObjects)
                {
                    IRotatable rotatable = obj.GetComponent<IRotatable>();
                    _rotatables.Add(rotatable);
                }
            }
            void Update()
            {   
                foreach (IRotatable rotatable in _rotatables)
                {
                    rotatable.Rotate();
                }
            }
        
    }
}