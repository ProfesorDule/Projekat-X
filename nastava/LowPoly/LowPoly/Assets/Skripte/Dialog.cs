using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour {

    public static Dialog Instance { get; set; }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddNewDialog(string[] lines)
    {
        List<string> dialogLines = new List<string>();
        foreach (string line in lines)
        {
            dialogLines.Add(line);
        }
        Debug.Log(dialogLines.Count);
    }
}
