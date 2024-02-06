using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 5.0f;
    public float turnSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;
    private Vector3 initialPos;
    private Quaternion initialRot;
    public SpawnManager SpawnManager;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
        initialRot = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * Speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ParkedCars")
        {
            Debug.Log("GameOver");
            Destroy(gameObject);
        }
        if (other.tag == "SuccessCollision") 
        {
            Debug.Log("Success");
            transform.position = initialPos;
            transform.rotation = initialRot;
            SpawnManager.OpenSpot();
        }
    }
}
