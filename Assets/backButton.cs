using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class backButton : MonoBehaviour {

	public Color standardColor;
	public Color highlightColor;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.colorText (this.GetComponent<RectTransform> (), highlightColor, 0.2f);
		LeanTween.color (transform.GetChild(0).GetComponent<RectTransform> (), highlightColor, 0.2f);
	}

	public void UnFocus(){
		LeanTween.colorText (this.GetComponent<RectTransform> (), standardColor, 0.2f);
		LeanTween.color (transform.GetChild(0).GetComponent<RectTransform> (), standardColor, 0.2f);
	}

}
