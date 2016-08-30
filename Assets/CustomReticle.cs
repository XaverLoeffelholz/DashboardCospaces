using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CustomReticle : MonoBehaviour {

	RectTransform rect;

	private Color standard;
	public Color click;

	public float visibilityHover;
	public float visibilityNormal;

	// Use this for initialization
	void Start () {
		rect = this.gameObject.gameObject.GetComponent<RectTransform> ();
		standard = this.gameObject.GetComponent<Image> ().color;
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Focus(){
		LeanTween.scale(rect, new Vector3(1f,1f,1f),0.5f).setEase(LeanTweenType.easeOutExpo);
		LeanTween.alpha(rect, visibilityHover, 0.5f).setEase(LeanTweenType.easeOutExpo);
	}

	public void UnFocus(){
		LeanTween.scale(rect, new Vector3(0.5f,0.5f,0.5f),0.5f).setEase(LeanTweenType.easeOutExpo);
		LeanTween.alpha(rect, visibilityNormal, 0.5f).setEase(LeanTweenType.easeOutExpo);
	}

	public void Press(){
		this.gameObject.GetComponent<Image> ().color = click;
	}

	public void Release(){
		this.gameObject.GetComponent<Image> ().color = standard;
	}
}
