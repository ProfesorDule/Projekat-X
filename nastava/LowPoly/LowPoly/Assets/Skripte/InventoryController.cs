using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour {

    public Item mac;

    void Start()
    {
        List<BazniStatovi> StatMaca = new List<BazniStatovi>();
        StatMaca.Add(new BazniStatovi(6, "Snaga", "Nivo Snage"));
        mac = new Item(StatMaca, "sipka");
    }
}
