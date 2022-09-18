using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float delay;
    public GameObject spawn;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnDelay(delay));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnDelay(float duration)
    {
        yield return new WaitForSeconds(duration);
        Instantiate(spawn, transform);
    }
}
