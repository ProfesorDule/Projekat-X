using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mac : MonoBehaviour, IOruzija 
{

    public List<BazniStatovi> Stat { get; set; }

    public void Napadni()
    {
        Debug.Log("Napad macem");
    }
	
}
