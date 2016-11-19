using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Promena : MonoBehaviour {

	public void IzaberiScenu(int Index)
	{
		SceneManager.LoadScene(Index);
	}
}
