using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    public int score;

    float speedAmount = 5f;
    float jumpAmount = 3f; 
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;
        
        if(Input.GetButtonDown("Jump"))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }

        //if (Input.GetAxisRaw("Horizontal") == -1)
        //{
        //    transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        //}
        //else if (Input.GetAxisRaw("Horizontal") == 1)
        //{
        //    transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        //}


    }
}
