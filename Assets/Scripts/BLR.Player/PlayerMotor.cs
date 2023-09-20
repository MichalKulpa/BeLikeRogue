using System.Collections;
using UnityEngine;

namespace BLR.Player
{
    public class PlayerMotor : MonoBehaviour
    {

        [SerializeField]
        private CharacterController characterController;

        //private Vector3 playerVelocity;
        [Header("Speed")]
        [SerializeField]
        private float speed = 5f;
        [Header("Dodge")]
        [SerializeField]
        private float dashSpeed = 15f;
        [SerializeField]
        private float dashTime = 0.25f;

        private Vector3 moveDirection = Vector3.zero;


        public void ProcessMove(Vector2 input)
        {

            moveDirection.x = input.x;
            moveDirection.z = input.y;
            characterController.Move(transform.TransformDirection(moveDirection) * speed * Time.deltaTime);
        }
        public void ProcessDodge()
        {
            StartCoroutine(Dodge());
        }
        IEnumerator Dodge()
        {
            float startTime = Time.time;


            while (Time.time < startTime + dashTime)
            {
                characterController.Move(transform.TransformDirection(moveDirection) * dashSpeed * Time.deltaTime);
                yield return null;
            }
        }
    }
}

