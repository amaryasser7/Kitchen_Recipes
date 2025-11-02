using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    private bool isWalking;
    [SerializeField] private float move_speed = 7f;
    [SerializeField] private Animator animator;
    [SerializeField ] private GameInput gameInput;
    private void Update() {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();  
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
 
        transform.position += moveDir * move_speed * Time.deltaTime;


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