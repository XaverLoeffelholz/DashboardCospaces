using UnityEngine;
using System.Collections;

public class AlphabetMenu : MonoBehaviour {

	private MenuPage[] letters;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DefocusAll(){
		letters = GetComponentsInChildren<MenuPage>();
		foreach (MenuPage letter in letters) {
			letter.UnFocus ();
		}
	}
}
