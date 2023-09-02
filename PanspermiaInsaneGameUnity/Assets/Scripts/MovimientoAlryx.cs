using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class MovimientoAlryx : MonoBehaviour {
    
    public float HorizontalMove;
    public float VerticalMove;
    private Vector3 playerInput;
   
    public CharacterController player;

    private float playerSpeed = 10;
    private Vector3 movePlayer;

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    Animator animAlyx;

    void Start()
    {
        player = GetComponent<CharacterController>();
        animAlyx = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMove = Input.GetAxis("Horizontal");
        VerticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(HorizontalMove, 0, VerticalMove);

        //playerInput = new Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;
        player.transform.LookAt(player.transform.position + movePlayer); 
        player.Move(movePlayer * playerSpeed * Time.deltaTime);

        animAlyx.SetFloat("Caminata", 1.0f);


        Debug.Log(player.velocity.magnitude);


    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.forward;

        camForward.y = 0;   
        camRight.y = 0;
       

        camForward = camForward.normalized;
        camRight = camRight.normalized;
        
    } 

}
