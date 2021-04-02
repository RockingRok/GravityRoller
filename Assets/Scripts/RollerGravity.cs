using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollerGravity : MonoBehaviour
{
    enum GravityDirection { Down, Up };
    GravityDirection gravityDirection;

    // Start is called before the first frame update
    void Start()
    {
        gravityDirection = GravityDirection.Down;
    }

    // Update is called once per frame
    void Update()
    {
        if (gravityDirection == GravityDirection.Down)
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravityDirection = GravityDirection.Up;
                Debug.Log("UP");
            }
        }
        else
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravityDirection = GravityDirection.Down;
                Debug.Log("DOWN");
            }
        }
    }
}
