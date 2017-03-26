using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BazniStatovi{

    public List<StatBonus> Bonus { get; set; }
    public int BaznaVrednost { get; set; }
    public string  ImeStata { get; set; }
    public string OpisStata { get; set; }
    public int FinalValue { get; set; }

    public BazniStatovi(int baznaVrednost, string ImeStata, string OpisStata)
    {
        this.Bonus = new List<StatBonus>();
        this.BaznaVrednost = baznaVrednost;
        this.ImeStata = ImeStata;
        this.OpisStata = OpisStata;
    }

    public void DodajBonus(StatBonus statBonus)
    {
        this.Bonus.Add(statBonus);
    }

    public void OduzmiBonus(StatBonus statBonus)
    {
        this.Bonus.Remove(statBonus);
    }

    public int GetStat()
    {
        this.FinalValue = 0;
        this.Bonus.ForEach(x => this.FinalValue += x.VrednostBonusa);
        FinalValue += BaznaVrednost;
        return FinalValue;
    }

}
