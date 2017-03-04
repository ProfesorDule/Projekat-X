using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interackija : MonoBehaviour {

    public UnityEngine.AI.NavMeshAgent playerAgent;

    public virtual void PomerajDoInterakcije(UnityEngine.AI.NavMeshAgent playerAgent)
    {
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 1.5f;
        playerAgent.destination = this.transform.position;

        Interakt();
    }

    public virtual void Interakt()
    {
        Debug.Log("Interakcija sa baznom klasom");
    }

}
