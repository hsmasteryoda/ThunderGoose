//CB Mike Johnson
// @Mikeyj125
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform gooseTransform;
 


    // Start is called before the first frame update
    void Start()
    {
        
        gooseTransform = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // stores current camera pos
        Vector3 temp = transform.position;
        temp = gooseTransform.position;
        float cameraLowerBounds = -4.7f;
        float cameraUpperBounds = 4.6f;
        float cameraLeftBounds = -22.0f;
        float cameraRightBounds = 107f;

        //camera pos set to player pos
        temp.z = temp.z - 20;
        temp.x = (gooseTransform.position.x + 6);
        temp.y = gooseTransform.position.y;

        //sets camera temp pos to current pos
        // this was a bitch to corilate and order these don't mess up plz

        if ((temp.y < cameraLowerBounds) && (temp.x < (cameraLeftBounds + 6)))
        {
            transform.position = new Vector3(cameraLeftBounds + 6, cameraLowerBounds, -23);
        }

        else if ((temp.y > cameraUpperBounds) && (temp.x < (cameraLeftBounds + 6)))
        {
            transform.position = new Vector3(cameraLeftBounds + 6, cameraUpperBounds, -23);
        }

        else if ((temp.y > cameraUpperBounds) && (temp.x > (cameraRightBounds +6)))
        {
            transform.position = new Vector3(cameraRightBounds + 6, cameraUpperBounds, -23);
        }

        else if ((temp.y < cameraLowerBounds) && (temp.x > (cameraRightBounds +6)))
        {
            transform.position = new Vector3(cameraRightBounds + 6, cameraLowerBounds, -23);
        }

        else if (temp.y < cameraLowerBounds)
        {
            transform.position = new Vector3(temp.x, cameraLowerBounds, -23);
        }

        else if (temp.y > cameraUpperBounds)
        {
            transform.position = new Vector3(temp.x, cameraUpperBounds, -23);
        }

        else if (temp.x < (cameraLeftBounds + 6))
        {
            transform.position = new Vector3(cameraLeftBounds + 6, temp.y, -23);
        }

        else if (temp.x > (cameraRightBounds +6))
        {
            transform.position = new Vector3(cameraRightBounds + 6, temp.y, -23);
        }


        else
        {
            transform.position = temp;

        }

        //transform.position = temp;
        //Debug.Log(temp);

    }
} //class













