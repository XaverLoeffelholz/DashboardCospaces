using UnityEngine;
using System.Collections;

public class laodingBar : MonoBehaviour {

	public whiteCanvas white;

	// Use this for initialization
	void Start () {
		white.FadeOut ();
		LeanTween.scaleX (this.gameObject, 1f, 3f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
