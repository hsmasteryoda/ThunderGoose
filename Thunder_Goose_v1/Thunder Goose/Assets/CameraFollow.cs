using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform playerTransform;
 


    // Start is called before the first frame update
    void Start()
    {
        
        playerTransform = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // stores current camera pos
        Vector3 temp = transform.position;

        //camera pos set to player pos
        temp.x = (playerTransform.position.x + 6);
        temp.y = playerTransform.position.y;

        //sets camera temp pos to current pos
        transform.position = temp;

    }
} //class













