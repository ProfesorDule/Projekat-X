using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Navigacija : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject izabraniGameObject;

	private bool izabranoDugme;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetAxisRaw ("Vertical") != 0 && izabranoDugme == false)
		{
			eventSystem.SetSelectedGameObject(izabraniGameObject);
			izabranoDugme = true;
		}
	
	}
	
	private void OnDisable()
	{
		izabranoDugme = false;
	}
}
