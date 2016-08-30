using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArrowAnimation : MonoBehaviour {

	private RectTransform arrow;
	public float delay;

	// Use this for initialization
	void Start () {
		arrow = this.GetComponent<RectTransform> ();
		Invoke ("fadeIn", delay);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void fadeIn(){
		LeanTween.alpha (arrow, 1f, 0.6f).setEase (LeanTweenType.easeInOutQuad).setOnComplete (fadeOut);
	}

	private void fadeOut(){
		LeanTween.alpha (arrow, 0f, 0.6f).setEase (LeanTweenType.easeInOutQuad).setOnComplete (fadeIn);
	}

}
