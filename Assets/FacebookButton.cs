using UnityEngine;
using System.Collections;

public class FacebookButton : MonoBehaviour {

	public Color standardColor;
	public Color highlightColor;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.color (this.GetComponent<RectTransform> (), highlightColor, 0.2f);
	}

	public void UnFocus(){
		LeanTween.color (this.GetComponent<RectTransform> (), standardColor, 0.2f);
	}
}
