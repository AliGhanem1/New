using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 10.0f;
    private Rigidbody rb;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(Vector3.forward * -speed );
        OutOfBound();
    }
    void OutOfBound()
    {
        if(transform.position.z < -8.0f)
        {
            Destroy(gameObject);
        }
    }
}
