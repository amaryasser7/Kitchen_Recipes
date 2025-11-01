using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    private bool isWalking;
    [SerializeField] private float speed = 7f;
    [SerializeField] private Animator animator;
    private void Update() {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }


        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }


        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }


        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        transform.position += moveDir * speed * Time.deltaTime;

        isWalking = moveDir != Vector3.zero;
        if (isWalking)
        { animator.SetBool("IsWalking", true); }
        else
        { animator.SetBool("IsWalking", false); }

        float RotationSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, RotationSpeed * Time.deltaTime);   
        }





    public bool IsWalking()
    {
        return isWalking;
    }






}