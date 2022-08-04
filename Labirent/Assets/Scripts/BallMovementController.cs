using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovementController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        float yatayeksen = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float dikeyeksen = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        Vector3 vec = new Vector3(yatayeksen,0,dikeyeksen);
        rb.AddForce(vec);
    }
}
