using UnityEngine;
using System.Collections;

public class GroundMenu : MonoBehaviour {

	CanvasGroup canvGroup;
	public CanvasGroup Hint;
	public GameObject rock;


	// Use this for initialization
	void Start () {
		canvGroup = this.GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ShowGroundMenu(){
		LeanTween.alpha (rock, 0.3f, 0.8f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (canvGroup, 1f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
	}

	public void HideGroundMenu(){
		LeanTween.alphaCanvas (canvGroup, 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (rock, 1.0f, 0.8f).setEase (LeanTweenType.easeInOutExpo);
	}

	public void ShowHint () {
		LeanTween.alpha (rock, 0.3f, 0.8f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (Hint, 1f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
	}

	public void HideHint(){
		LeanTween.alphaCanvas (Hint, 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
	}
}
