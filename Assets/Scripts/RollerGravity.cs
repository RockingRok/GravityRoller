using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerGravity : MonoBehaviour
{
    enum GravityDirection { Down, Up };
    GravityDirection gravityDirection;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.gravityScale = -1;
        gravityDirection = GravityDirection.Down;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravityDirection == GravityDirection.Down)
        {
            rb.gravityScale = 1;
            //Physics2D.gravity = new Vector2(0, -9.8f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravityDirection = GravityDirection.Up;
                Debug.Log("UP");
            }
        }
        else
        {
            rb.gravityScale = -1;
            //Physics2D.gravity = new Vector2(0, 9.8f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravityDirection = GravityDirection.Down;
                Debug.Log("DOWN");
            }
        }
    }
}
