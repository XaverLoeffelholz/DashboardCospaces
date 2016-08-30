using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuBottomElement : MonoBehaviour {

	public GameObject bottomMenu;
	public GameObject canvasObject;
	public MenuBottomElement[] otherElements; 

	public Color standardColor;
	public Color highlightColor;

	private float zPosition;

	public Font bold;
	private Font regular;

	public bool selected;

	public Transform box;
	public Color boxNormal;
	public Color boxHover;
	public Color boxSelected;

	public RectTransform boxRect; 
	public RectTransform icon; 

	public Text currentPage;

	// Use this for initialization
	void Start () {
		zPosition = transform.localPosition.z;
		regular = this.GetComponent<Text> ().font;

		if (box != null) {
			boxRect = box.gameObject.GetComponent<RectTransform> ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		//float newZ = zPosition - 40f;

		//this.GetComponent<Text> ().font = bold;

		//LeanTween.moveLocalZ (this.gameObject, (zPosition - 1f), 0.2f);
		//transform.GetChild(0).gameObject.SetActive(true);

		LeanTween.colorText (this.GetComponent<RectTransform> (), highlightColor, 0.2f);

		if (icon != null) {
			LeanTween.color (icon, highlightColor, 0.2f);
		}

		if (box != null) {
			if (!selected) {
				LeanTween.color (boxRect, boxHover, 0.2f);
			}
		}
	}


	public void UnFocus(){

		if (!selected) {

			//	LeanTween.moveLocalZ (this.gameObject, zPosition, 0.2f);
			LeanTween.colorText (this.GetComponent<RectTransform> (), standardColor, 0.2f);

		/*	if (transform.GetChild (0) != null) {
				transform.GetChild(0).gameObject.SetActive(false);
			} */

			this.GetComponent<Text> ().font = regular;

			if (icon != null) {
				LeanTween.color (icon, standardColor, 0.2f);
			}

			if (box != null) {
				LeanTween.color (boxRect, boxNormal, 0.2f);
			}
		}

	}

	public void Select(){
		selected = true;
		//LeanTween.colorText (this.GetComponent<RectTransform> (), highlightColor, 0.2f);
		//standardColor = highlightColor;

		this.GetComponent<Text> ().font = bold;
		// transform.GetChild(0).gameObject.SetActive(true);

		LeanTween.colorText (this.GetComponent<RectTransform> (), highlightColor, 0.2f);


		if (box != null) {
			LeanTween.color (boxRect, boxSelected, 0.2f);
		}

		foreach (MenuBottomElement button in otherElements) {
			button.DeSelect ();
		}
	}

	public void DeSelect(){
		selected = false;

		LeanTween.colorText (this.GetComponent<RectTransform> (), standardColor, 0.2f);

		if (icon != null) {
			LeanTween.color (icon, standardColor, 0.2f);
		}

		if (box != null) {
			LeanTween.color (boxRect, boxNormal, 0.2f);
		}

	//	standardColor = Color.white;

	 //	this.GetComponent<Text> ().font = regular;
	//	transform.GetChild(0).gameObject.SetActive(false);
	}
}
