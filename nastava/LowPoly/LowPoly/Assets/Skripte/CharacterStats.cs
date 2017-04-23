using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStats : MonoBehaviour {

    public List<BazniStatovi> stat = new List<BazniStatovi>();
    Button plus,minus;
    Text StatVr;

   // public GameObject StatPanel;

	void Start () {
        stat.Add(new BazniStatovi(4, "Snaga", "Nivo snage"));
        Debug.Log("Snaga: " + stat[0].GetStat());

       // plus = StatPanel.transform.FindChild("BtPlus").GetComponent<Button>();
       // minus = StatPanel.transform.FindChild("BtMinus").GetComponent<Button>();
       // StatVr = StatPanel.transform.FindChild("Tekst").GetComponent<Text>();
      //  plus.onClick.AddListener(delegate { PovecajStat(); });
       // minus.onClick.AddListener(delegate { SmanjiStat(); });
    }

  /*  public void PovecajStat()
    {
        stat[0].BaznaVrednost++;
        StatVr.text = "" + stat[0].GetStat();
    }

    public void SmanjiStat()
    {
        stat[0].BaznaVrednost--;
        StatVr.text = "" + stat[0].GetStat();
    }*/

    public void DodajStatBonus(List<BazniStatovi> statBonusi)
    {
        foreach (BazniStatovi statBonus in statBonusi)
        {
            stat.Find(x => x.ImeStata == statBonus.ImeStata).DodajBonus(new StatBonus(statBonus.BaznaVrednost));
        }
    }

    public void IzbrisiStatBonus(List<BazniStatovi> statBonusi)
    {
        foreach (BazniStatovi statBonus in statBonusi)
        {
            stat.Find(x => x.ImeStata == statBonus.ImeStata).OduzmiBonus(new StatBonus(statBonus.BaznaVrednost));
        }
    }
}
