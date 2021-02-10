using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NavMeshGuard : MonoBehaviour
{
    public GameObject characterDestination;
    NavMeshAgent NPC;
    // Start is called before the first frame update
    void Start()
    {
        NPC = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        NPC.SetDestination(characterDestination.transform.position); //finds path for guards
    }
}
