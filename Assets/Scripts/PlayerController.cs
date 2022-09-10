using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Varibales for the game
    public float speed;
    public float Bound;

    //Get The Componnet info
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        ContainPlayerBound();
    }

    //control the move of the player
    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * speed * horizontal);
        playerRb.AddForce(Vector3.forward * speed * vertical);
    }
    void ContainPlayerBound()
    {
        if (transform.position.z > Bound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Bound);
        }
        if (transform.position.z < -Bound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -Bound);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Enteract with enemy");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PowerUp"))
        {
            Debug.Log("Power Up The Speed");
            Destroy(other.gameObject);
        }
    }
}
