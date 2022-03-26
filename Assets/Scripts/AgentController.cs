using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;

    public GameObject purple;
    public GameObject white;
    public GameObject orange;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Sheep").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null && Player != null)
        {
            enemy.SetDestination(Player.position);
        }
    }
}
