using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    //upper and lower platform to figure out where to spawn obstacles
    public GameObject lowerPlatform;
    public GameObject upperPlatform;

    //obstacle prefabs
    public GameObject rectangle;
    public GameObject circle;
    public GameObject hexagon;

    public float respawnTime = 1.0f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(spawnObstacles());
    }

    private void spawnObstacle()
    {
        GameObject a = Instantiate(rectangle) as GameObject;
        a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
    }

    IEnumerator spawnObstacles()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnObstacle();
        }
    }
}
