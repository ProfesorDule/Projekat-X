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

        UzetoOruzije = (GameObject)Instantiate(Resources.Load<GameObject>("Oruzija/" + novoOruzije.ObjectSlug),rukaIgraca.transform.position,rukaIgraca.transform.rotation);
        UzetoOruzije.GetComponent<IOruzija>().Stat = novoOruzije.stats;
        UzetoOruzije.transform.SetParent(rukaIgraca.transform);
        characterStats.DodajStatBonus(novoOruzije.stats);
    }

    public void UradiNapad()
    {
        UzetoOruzije.GetComponent<IOruzija>().Napadni();
    }
}
