using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDestination : MonoBehaviour
{
    // Couldn't find proper animal models so i've put guards that roaming randomly in the village.
    public int xPos;
    public int zPos;

    void OnTriggerEnter(Collider other) //Generates random destination for guards.
    {
        if(other.tag == "Guard")
        {
            zPos = Random.Range(712, 739);
            xPos = Random.Range(527, 548);
            this.gameObject.transform.position = new Vector3(xPos, 1, zPos);
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
