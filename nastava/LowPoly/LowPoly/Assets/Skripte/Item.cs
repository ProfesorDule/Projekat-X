using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item {

    public List<BazniStatovi> stats { get; set; }
    public string ObjectSlug { get; set; }

    public Item(List<BazniStatovi> _Stat, string _ObjectSlug)
    {
        this.stats = _Stat;
        this.ObjectSlug = _ObjectSlug;
    }
	
}
