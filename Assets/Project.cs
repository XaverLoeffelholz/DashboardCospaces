using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Project : MonoBehaviour {

	public int x;
	public int y;

	private float standardZ;
	private float standardScale;
	public CanvasGroup frame;
	public RectTransform whiteOverlay;

	private Color currentColor; 


	// Use this for initialization
	void Start () {
		currentColor = new Color (1f, 1f, 1f, 0.0f);
		standardZ = transform.localPosition.z;
		standardScale = transform.localScale.z;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus() {


		//pageManager.DarkenAllExcept (this);
		//LeanTween.cancel( this.gameObject );
		//pageManager.FocusSurroundingObjects (this);

	//	pageManager.UnFocusAllExcept (this);

		transform.SetAsLastSibling ();
		//float newZ = standardZ - 40f;
	//	LeanTween.moveLocalZ (this.gameObject, newZ , 0.6f).setEase(LeanTweenType.easeInOutExpo);
		//LeanTween.scale(this.gameObject, new Vector3(1.2f,1.2f,1.2f) , 0.6f).setEase(LeanTweenType.easeInOutExpo);


		//LeanTween.color(this.GetComponent<RectTransform>(), new Color (1f, 1f, 1f, 1f), 0.4f).setEase(LeanTweenType.easeInOutExpo);


		LeanTween.color(whiteOverlay, new Color(1f,1f,1f,0.15f),0.2f).setEase(LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (frame, 1f, 0.2f).setEase(LeanTweenType.easeOutExpo);

	}


	public void UnFocus() {

		//pageManager.UnDarkenAll ();

		//pageManager.UnFocusSurroundingObjects (this);

	//	LeanTween.moveLocalZ (this.gameObject, standardZ, 0.4f).setEase(LeanTweenType.easeInOutExpo); 
	//	LeanTween.scale(this.gameObject, new Vector3(standardScale,standardScale,standardScale) , 0.4f).setEase(LeanTweenType.easeInOutExpo);

		//LeanTween.color(this, new Color (1f, 1f, 1f, 0.5f), 0.4f).setEase(LeanTweenType.easeInOutExpo);


		LeanTween.color(whiteOverlay, currentColor, 0.4f).setEase(LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (frame, 0f, 0.4f).setEase(LeanTweenType.easeOutExpo);

	}

	public void OpenWorld() {		
		GameObject.Find ("White").GetComponent<whiteCanvas> ().LoadLevel1 ();
		LeanTween.move (this.gameObject, new Vector3 (0f, 0f, 1f), 0.6f).setEase(LeanTweenType.easeInCubic);
	}



}
