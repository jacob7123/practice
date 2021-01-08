using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    //public Transform player;
    /*
     * Because we use FindGameObjectWithTag, we do not use public for player
     */
    private Transform player;
    private NavMeshAgent nav;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; //去查FindGameObjectsWithTag
        nav    = GetComponent<NavMeshAgent>();
    }
    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */

    // Update is called once per frame
    void Update()
    {
        nav.destination = player.position;
    }
}
