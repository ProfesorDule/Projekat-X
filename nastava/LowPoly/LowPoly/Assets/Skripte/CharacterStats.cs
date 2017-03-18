using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    public List<BazniStatovi> stat = new List<BazniStatovi>();

	void Start () {
        stat.Add(new BazniStatovi(4, "Snaga", "Nivo snage"));
        stat[0].DodajBonus(new StatBonus(5));
        Debug.Log("Snaga: " + stat[0].GetStat());
    }
	
}
