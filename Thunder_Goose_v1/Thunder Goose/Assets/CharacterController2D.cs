using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets;
public class CharacterController2D : MonoBehaviour
{
    public float speed = 2;
    public float force = 200;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        player = Player.ThePlayer;

    }

    // Update is called once per frame
    //maybe redo this part with an adapter pattern??
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.MoveUp();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.MoveDown();
        }
    }
}
