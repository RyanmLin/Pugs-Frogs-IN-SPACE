using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject spawnArea;

    // Start is called before the first frame update
    void Start()
    {
        spawnObjects();
    }

    // Update is called once per frame
    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        BoxCollider2D area = spawnArea.GetComponent<BoxCollider2D>();
        Vector2 pos;
        float screenX, screenY;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(area.bounds.min.x, area.bounds.max.x);
            screenY = Random.Range(area.bounds.min.y, area.bounds.max.y);
            pos = new Vector2(screenX, screenY);
            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }

      



    }
}
