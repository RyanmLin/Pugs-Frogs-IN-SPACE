using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PugWoof : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public int wait = 10;
    bool keepPlaying = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SoundOut());
    }

    IEnumerator SoundOut()
    {
        while (keepPlaying)
        {
            source.PlayOneShot(clip);
            Debug.Log("Pugs");
            yield return new WaitForSeconds(wait);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
