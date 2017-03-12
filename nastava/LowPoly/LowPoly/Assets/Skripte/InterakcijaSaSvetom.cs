using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterakcijaSaSvetom : MonoBehaviour {

    public static InterakcijaSaSvetom Instance { get; set; }

    UnityEngine.AI.NavMeshAgent playerAgent;
    public int Inter = 0;

	// Use this for initialization
	void Start () {
        playerAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
        {
            Kretanje();
        }
	}

    void Kretanje()
    {
        Ray InteractionCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionInfo;
        if (Physics.Raycast(InteractionCamera, out interactionInfo, Mathf.Infinity))
        {
            GameObject interactionObject = interactionInfo.collider.gameObject;
            if (interactionObject.tag == "Interaktabilno")
            {
                interactionObject.GetComponent<Interackija>().PomerajDoInterakcije(playerAgent);
                Inter = 1;
            }
            else if (Inter == 0)
            {
                playerAgent.destination = interactionInfo.point;
            }
        }

    }

    public void Zavrsi()
    {
        Inter = 0;
    }
}


