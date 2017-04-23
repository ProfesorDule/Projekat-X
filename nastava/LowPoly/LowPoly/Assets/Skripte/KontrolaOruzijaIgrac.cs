using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KontrolaOruzijaIgrac : MonoBehaviour {

    public GameObject rukaIgraca;
    public GameObject UzetoOruzije{ get; set; }

    IOruzija uzetoOruzije;
    CharacterStats characterStats;

    void Start()
    {
        characterStats = GetComponent<CharacterStats>();
    }


    public void UzmiOruzije(Item novoOruzije)
    {
        if (UzetoOruzije != null)
        {
            characterStats.IzbrisiStatBonus(UzetoOruzije.GetComponent<IOruzija>().Stat);
            Destroy(rukaIgraca.transform.GetChild(0).gameObject);
        }

        UzetoOruzije = (GameObject)Instantiate(Resources.Load<GameObject>("Oruzija/" + novoOruzije.ObjectSlug),
            rukaIgraca.transform.position,rukaIgraca.transform.rotation);
        uzetoOruzije = UzetoOruzije.GetComponent<IOruzija>();
        UzetoOruzije.transform.SetParent(rukaIgraca.transform);
        uzetoOruzije.Stat = novoOruzije.stats;       
        characterStats.DodajStatBonus(novoOruzije.stats);
        Debug.Log(uzetoOruzije.Stat[0].FinalValue);
    }

    public void UradiNapad()
    {
        uzetoOruzije.Napadni();
    }
}
