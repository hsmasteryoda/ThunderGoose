// CB MJ
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    //public float speed = 1;
    //public float force = 300;

    public float maxSpeed = 9f;
    public float maxupSpeed = 8f;
    bool facingRight = true;

    float gooseLowerBounds = -9f;
    float gooseUpperBounds = 10f;
    float gooseLeftBounds = -25.5f;
    public float gooseRightBounds = 130f;



    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the goose as we flip
        //

        //Quaternion rot = transform.rotation;

        if ((Input.GetAxis("Horizontal") < 0))
        {
            facingRight = false;
            transform.localRotation = Quaternion.Euler(180, 0, 180);
        }

        else
        {
            facingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }


        // This Moves our Honking Hero
        Vector3 pos = transform.position;
        
        pos.y += Input.GetAxis("Vertical") * maxupSpeed * Time.deltaTime;

        pos.x += Input.GetAxis("Horizontal") * maxSpeed * Time.deltaTime;

        // BELOW IS A BLOCK OF IF STATEMENTS
        // This controls the bounds of the goose
        #region declares the bounds
        if (pos.y > gooseUpperBounds)
        {
            if (pos.x < gooseLeftBounds)
            {
                pos = new Vector3(gooseLeftBounds, gooseUpperBounds, -4.66f);
            }
            else if (pos.x > gooseRightBounds)
            {
                pos = new Vector3(gooseRightBounds, gooseUpperBounds, -4.66f);
            }

            else
            {
                pos = new Vector3(pos.x, gooseUpperBounds, -4.66f);
            }
        }

        else if (pos.y < gooseLowerBounds)
        {
            if (pos.x < gooseLeftBounds)
            {
                pos = new Vector3(gooseLeftBounds, gooseLowerBounds, -4.66f);
            }
            else if (pos.x > gooseRightBounds)
            {
                pos = new Vector3(gooseRightBounds, gooseLowerBounds, -4.66f);
            }

            else
            {
                pos = new Vector3(pos.x, gooseLowerBounds, -4.66f);
            }
        }

        else if (pos.x < gooseLeftBounds)
        {
            if (pos.y > gooseUpperBounds)
            {
                pos = new Vector3(gooseLeftBounds, gooseUpperBounds, -4f);
            }
            else if (pos.y < gooseLowerBounds)
            {
                pos = new Vector3(gooseLeftBounds, gooseLowerBounds, -4f);
            }
            else
            {
                pos = new Vector3(gooseLeftBounds, pos.y, -4f);
            }
        }

        else if (pos.x > gooseRightBounds)
        {
            if (pos.y > gooseUpperBounds)
            {
                pos = new Vector3(gooseRightBounds, gooseUpperBounds, -4f);
            }
            else if (pos.y < gooseLowerBounds)
            {
                pos = new Vector3(gooseRightBounds, gooseLowerBounds, -4f);
            }
            else
            {
                pos = new Vector3(gooseRightBounds, pos.y, -4f);
            }
        }


        else 
        {
            pos = new Vector3(pos.x, pos.y, -4.66f);
        }
        #endregion

        transform.position = pos;
      
        




        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    GetComponent<Rigidbody2D>().transform.Translate(Vector2.up * Time.deltaTime);
        //}

        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    GetComponent<Rigidbody2D>().AddForce(Vector2.down * force);
        //}

        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        //}


    }
}
