using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
   
{
    [SerializeField] private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)){
            rb.AddForce(Vector3.up * 10f);
        }

        if (Input.GetKey(KeyCode.D)){
            rb.AddForce(Vector3.right*10f);
        }

        if (Input.GetKey(KeyCode.A)){
            rb.AddForce(Vector3.left * 10f);
        }

        if (Input.GetKey(KeyCode.S)){
            rb.AddForce(Vector3.back * 10f);
        }

        if (Input.GetKey(KeyCode.W)){
            rb.AddForce(-Vector3.forward * 10f);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Sphere")
        Destroy(collision.gameObject);
    }
}
