using UnityEngine;
using System.Collections;

public class Settings : MonoBehaviour {

	public Color standardColor;
	public Color highlightColor;
	public CanvasGroup bubble;

	private bool bubbleVisible;

	// Use this for initialization
	void Start () {
		bubbleVisible = false;
		HideBubble ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.color (transform.GetChild(0).GetComponent<RectTransform> (), highlightColor, 0.2f);
		LeanTween.scale (transform.GetChild(0).GetComponent<RectTransform> (), new Vector3(1.2f,1.2f,1.2f), 0.2f);
	}

	public void UnFocus(){
		LeanTween.color (transform.GetChild(0).GetComponent<RectTransform> (), standardColor, 0.2f);
		LeanTween.scale (transform.GetChild(0).GetComponent<RectTransform> (), new Vector3(1.0f,1.0f,1.0f), 0.2f);
	}

	public void Click(){
		if (bubbleVisible) {
			bubbleVisible = false;
			HideBubble ();
		} else {
			bubbleVisible = true;
			ShowBubble ();
		}
	}

	private void ShowBubble(){
		LeanTween.alphaCanvas (bubble, 1f, 0.3f).setEase(LeanTweenType.easeInOutExpo);
		bubble.interactable = true;
		bubble.blocksRaycasts = true;
	}

	private void HideBubble(){
		LeanTween.alphaCanvas (bubble, 0f, 0.3f).setEase(LeanTweenType.easeInOutExpo);
		bubble.interactable = false;
		bubble.blocksRaycasts = false;
	}
}
