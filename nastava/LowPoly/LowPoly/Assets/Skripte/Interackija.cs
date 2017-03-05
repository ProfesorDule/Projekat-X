using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interackija : MonoBehaviour {

    public UnityEngine.AI.NavMeshAgent playerAgent;
    private bool hasInteracted;

    public virtual void PomerajDoInterakcije(UnityEngine.AI.NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 1.5f;
        playerAgent.destination = this.transform.position;
        hasInteracted = false;

    }

    void Update()
    {
        if (playerAgent != null && !playerAgent.pathPending)
        {
            if (!hasInteracted && playerAgent.remainingDistance <= playerAgent.stoppingDistance)
            {
                Interakt();
                hasInteracted = true;
            }
        }
    }

    public virtual void Interakt()
    {
        Debug.Log("Interakcija sa baznom klasom");
    }

}
