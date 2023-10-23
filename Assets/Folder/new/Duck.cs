using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Duck : MonoBehaviour
{
    private NavMeshAgent duck;
    private Transform player;
    // Start is called before the first frame update
    void Start()
    {
        duck = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        duck.SetDestination(player.position);
    }
}
