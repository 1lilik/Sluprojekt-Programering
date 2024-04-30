using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update

    float PlayerSpeed = 10;
    Rigidbody Jump;


    
    
    void Start()
    {
        transform.position = new Vector3(0, 2, 0);

        Jump = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(1,0,0) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(0, 0, -1) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0, 0, 1) * Time.deltaTime * PlayerSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cylinder")
        {
            transform.position = transform.position + new Vector3 (-2,0,20);
  
        }
        if (collision.gameObject.CompareTag("Capsule"))
        {
            transform.position = transform.position + new Vector3 (-2,0,-20);
           
        }
        // gameoObject.tag == __ and gameObject.CompareTag(__) works the same. The second one just gives a warning if object is not taged

    }

}
