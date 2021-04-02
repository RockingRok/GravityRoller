using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    //probably want something like this: https://pressstart.vip/tutorials/2018/09/25/58/spawning-obstacles.html

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.velocity.x = -5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
