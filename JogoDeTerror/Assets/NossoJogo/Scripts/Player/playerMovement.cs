using System;
using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public float groundDrag;
    
    [Header("Ground Check")]
    public float playerHeight;
    public LayerMask whatIsGround;
    bool grounded;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    public Transform RespawnPosition;
    public returnPoint RespawnPoint;

     Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
        {
            StartCoroutine(ScreenFader.Instance.FadeIn(1f));
            rb.freezeRotation = true;
            rb.linearVelocity = Vector3.zero;

            RespawnPoint = FindFirstObjectByType<returnPoint>();
            RespawnPosition = RespawnPoint.transform;
            if (returnPoint.Instance != null && returnPoint.Instance.ReturningToLevel)
            {
                print("This is how we do it in the streets of Muskeegee! " + RespawnPosition.position + " " + RespawnPosition.rotation);
            rb.MovePosition(RespawnPosition.position);
                transform.rotation = RespawnPosition.rotation;
                rb.linearVelocity = Vector3.zero;
                print(transform.position + " " + transform.rotation);

                returnPoint.Instance.ReturningToLevel = false;
            }
        }

    // Update is called once per frame
    private void Update()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whatIsGround);
        
        MyInput();

        SpeedControl();

        if (grounded)
        {
            rb.linearDamping = groundDrag;
        }
        else
        {
            rb.linearDamping = 0;
        }
    }

    private void FixedUpdate()
    {
        MovePlayer();
        Sprint();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        rb.AddForce(moveDirection.normalized * moveSpeed * 10, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
        if(flatVel.magnitude > moveSpeed)
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.linearVelocity = new Vector3(limitedVel.x, rb.linearVelocity.y, limitedVel.z);
        }
    }

    private void Sprint()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 9;
        }
        else
        {
            moveSpeed = 6;
        }
    }

    public void RespawnPlayer()
    {
        RespawnPoint.ReturningToLevel = true;
        SceneManager.LoadScene("Necroterio");
    }
}
