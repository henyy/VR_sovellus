using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImHome : MonoBehaviour
{
    //private AudioSource sound;
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        //sound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        //sound.Play(0);
        AudioSource.PlayClipAtPoint(clip, transform.position);
        Destroy(gameObject);
    }
}
