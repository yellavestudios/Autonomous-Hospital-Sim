using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GAction : MonoBehaviour
{

    public string actionName = "Action";
    public float cost = 1.0f;
    public GameObject target;
    public GameObject targetTag;
    public float duration = 0; // How long the agent will wait at a station
    public WorldState[] preCondition;
    public WorldState[] afterEffects;
    public NavMeshAgent agent;

    public Dictionary<string, int> precondition;
    public Dictionary<string, int> aftereffects;

    public Worldstate agentBeliefs;

    public bool running = false;

    public GAction()
    {
        precondition = new Dictionary<string, int>();
        aftereffects = new Dictionary<string, int>();
    }

    public void Awake()
    {
             // Add values to dictionary from Inspector 
            // Grab Navmeshagent

        agent = this.gameObject.AddComponent<NavMeshAgent>();


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
