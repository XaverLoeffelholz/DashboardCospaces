using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeftRightButtonSpace : MonoBehaviour {

	public Sprite Standard;
	public Sprite Hover;
	public Sprite Clicked;

	public Image button;
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

	public void NextLevel(){
		button.sprite = Clicked;
		GameObject.Find ("White").GetComponent<whiteCanvas> ().LoadLevel2 ();
	}

	public void PreviousLevel(){
		button.sprite = Clicked;
		GameObject.Find ("White").GetComponent<whiteCanvas> ().LoadLevel1 ();
	}

	public void MainMenu(){
		button.sprite = Clicked;
		GameObject.Find ("White").GetComponent<whiteCanvas> ().LoadLevelMenu ();
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
