using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSesame : MonoBehaviour
{
    //When player approaches, door opens however it doesn't stay open. Closing animation starts right after.
    public Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other) //If players in the door's collider door opens, until player exits.
    {
        if(other.tag == "Player")
        {
            anim.SetBool("isOpen", true);
        }
    } 
    private void OnTriggerExit(Collider other)
    {
        anim.SetBool("isOpen", false);
    }
}
