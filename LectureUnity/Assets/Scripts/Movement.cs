using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour{

    public float speed, moveVertical;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetAxis("Vertical") < 0)
        {
            moveVertical = 0.0f;
        }
        else
        {
            moveVertical = Input.GetAxis("Vertical");
        }
        moveVertical = Input.GetAxis("Vertical");*/
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.velocity = new Vector3(moveHorizontal + moveHorizontal, 0.0f, moveVertical);

        //rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
