using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 5.0f;

    private float horizontalInput;
    private float forwardInput;

    private float yVelocity = 0.0f;
    private float smooth = 0.3f;

    public bool isOnGround = true;

    [SerializeField]
    private Transform RespawnPoint;

    private Transform CameraTransform;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        CameraTransform = Camera.main.transform;
    }

    void Update()
    {
        // Get Input

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Makin moves

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        // JUMP

        if(Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

        // Respawn condition

        if (transform.position.y <= -10)
        {
            Respawn();
        }

        // Rotating the player with the camera

        transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, CameraTransform.eulerAngles.y, ref yVelocity, smooth);
    }

    // Checking whether the player is On Ground to Prevent Double Jump

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

    //Repawn
    private void Respawn()
    {
        transform.position = RespawnPoint.transform.position;
        Physics.SyncTransforms();
    }
}
