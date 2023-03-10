using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] Transform cam;
    [SerializeField] float speed = 1f;
    private float running;
    [SerializeField] float turnSmoothTime = 0.1f;
    float turnSmoothVel;

    Animator playerAnimator;
    
    void Start()
    {
        playerAnimator = GetComponentInChildren<Animator>();
    }

    void Update()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;

        bool isRunning = Input.GetButton("Run");

        if (isRunning == false)
        {
            running = 1f;
            playerAnimator.SetBool("isRunning",false);
        }else{
            running = 2.2f;
            playerAnimator.SetBool("isRunning",true);
            
        }

        if(direction.magnitude >= 0.1f)
        {
            
            float targetAngle = Mathf.Atan2(direction.x,direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float turnAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y,targetAngle,ref turnSmoothVel,turnSmoothTime);
            transform.rotation= Quaternion.Euler(0f,turnAngle,0f);

            Vector3 moveDirection = Quaternion.Euler(0f,turnAngle,0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * running *  speed * Time.deltaTime);
            playerAnimator.SetBool("isWalking",true);
        }else{
            playerAnimator.SetBool("isWalking",false);
        }



    }



}
