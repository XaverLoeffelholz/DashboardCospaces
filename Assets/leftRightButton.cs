using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class leftRightButton : MonoBehaviour {

	public Image button;
	public Sprite Standard;
	public Sprite Hover;
	public Sprite Clicked;

	private RectTransform rect;
	private Vector3 initialScale;

	// Use this for initialization
	void Start () {
		rect = button.gameObject.GetComponent<RectTransform> ();
		initialScale = rect.localScale;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.scale (rect, initialScale * 1.3f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		button.sprite = Hover;
	}

	public void UnFocus(){
		LeanTween.scale (rect, initialScale, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		button.sprite = Standard;
	}
}
