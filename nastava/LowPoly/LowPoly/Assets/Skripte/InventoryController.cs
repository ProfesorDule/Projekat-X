using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {
    public KontrolaOruzijaIgrac kontrolaOruzija;
    public Item mac;

    void Start()
    {
        kontrolaOruzija = GetComponent<KontrolaOruzijaIgrac>();
        List<BazniStatovi> StatMaca = new List<BazniStatovi>();
        StatMaca.Add(new BazniStatovi(6, "Snaga", "Nivo Snage"));
        mac = new Item(StatMaca, "sipka");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            kontrolaOruzija.UzmiOruzije(mac);
        }
    }
}
