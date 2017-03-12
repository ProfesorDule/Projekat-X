using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{

    public static Dialog Instance { get; set; }


    public string npcName;
    public GameObject DialougePanel;
    public List<string> dialogLines = new List<string>();


    Button continueButton;
    Text dialougeText, nameText;
    int dialougeIndex;
    void Awake()
    {
        continueButton = DialougePanel.transform.FindChild("Continue").GetComponent<Button>();
        dialougeText = DialougePanel.transform.FindChild("Text").GetComponent<Text>();
        nameText = DialougePanel.transform.FindChild("Name").GetChild(0).GetComponent<Text>();
        continueButton.onClick.AddListener(delegate { ContinueDialog(); });
        DialougePanel.SetActive(false);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddNewDialog(string[] lines, string npcName)
    {
        dialougeIndex = 0;
        dialogLines = new List<string>();
        foreach (string line in lines)
        {
            dialogLines.Add(line);
        }
        this.npcName = npcName;
        Debug.Log(dialogLines.Count);
        dialougeText.text = "";
        CreateDialog();
    }

    public void CreateDialog()
    {
        StartCoroutine(Cekaj(dialougeIndex));
        nameText.text = npcName;
        DialougePanel.SetActive(true);
        continueButton.enabled = false;
    }

    public void ContinueDialog()
    {
        dialougeText.text = "";
        continueButton.enabled = false;
        if (dialougeIndex < dialogLines.Count - 1)
        {
            dialougeIndex++;
            StartCoroutine(Cekaj(dialougeIndex));
        }
        else
        {
            DialougePanel.SetActive(false);
            Instance.GetComponent<InterakcijaSaSvetom>().Zavrsi();
        }
    }

    IEnumerator Cekaj(int dialogIndex)
    {
        Debug.Log("Uso je u Cekaj");
        dialougeText = DialougePanel.transform.FindChild("Text").GetComponent<Text>();
        int i;
        for (i = 0; i < dialogLines[dialougeIndex].Length; i++)
        {
            dialougeText.text = dialougeText.text + "" + dialogLines[dialougeIndex][i];
            yield return new WaitForSeconds(0.05F);
        }
        continueButton.enabled = true;
    }
}
