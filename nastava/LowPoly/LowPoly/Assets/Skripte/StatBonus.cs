using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatBonus {

    public int VrednostBonusa { get; set; }

    public StatBonus(int bonusVrednost)
    {
        this.VrednostBonusa = bonusVrednost;
        Debug.Log("Iniciran novi stat bonus");
    }
}
