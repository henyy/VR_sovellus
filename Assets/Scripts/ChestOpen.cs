using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestOpen : MonoBehaviour
{
    private Animation anim;

    //Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Mace"))
        {
            anim.Play("ChestAnim");
        }
    }
}
