using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : Interackija {

    public string[] dialog;
    public string name;


    public override void Interakt()
    {
        Dialog.Instance.AddNewDialog(dialog);
        Debug.Log("Interakcija sa NPC-om");
    }
}
