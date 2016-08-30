using UnityEngine;
using System.Collections;

public class TextInputField : MonoBehaviour {

	public GameObject placeholder;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.alpha (this.GetComponent<RectTransform>(), 1.0f, 0.1f).setEase (LeanTweenType.easeInOutExpo);
	}

	public void UnFocus(){
		LeanTween.alpha (this.GetComponent<RectTransform>(), 0.7f, 0.1f).setEase (LeanTweenType.easeInOutExpo);
	}
		
}
