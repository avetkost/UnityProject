using UnityEngine;
namespace task1

//The Value must be a Vector3 type and you must be able to change rotation arrount each axies individually.


{
    public class Rotation : MonoBehaviour
    {
        [SerializeField] private Vector3 targetRotation;
        private void Start()
        {
            Debug.Log("Here we go");
        }

        void Update()
        {
            transform.rotation = Quaternion.Euler(targetRotation);
        }
    }
}