using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Login : MonoBehaviour {

	public RectTransform keyboard;
	public RectTransform keyboardBG;
	public RectTransform LoginMenu;
	public CanvasGroup thumbnails;
	public CanvasGroup textInside;

	public Manager manager;

	public TopMenu topMenu;
	public CanvasGroup topMenuCanvGroup;

	private Vector3 posMenu;
	private Vector3 posKeyboard;
	private float localZ;
	private float localY;

	public GameObject galerie;
	public GameObject menu;

	private Vector3 initialPosGalierie;
	private Vector3 initialPosMenu;

	public GameObject EmailInput;
	public GameObject PWInput;

	public int currentStep;

	// Use this for initialization
	void Start () {
		currentStep = 0;
		posMenu = transform.position;
		posKeyboard = keyboard.transform.position;
		localZ = transform.localPosition.z;
		localY = transform.localPosition.y;

		transform.position = new Vector3 (0f, -20f, 0f);
		keyboard.transform.position = new Vector3 (0f, -20f, 0f);

		initialPosGalierie = galerie.transform.position;
		initialPosMenu = menu.transform.position;

		keyboard.gameObject.SetActive (false);
	}
		

	// Update is called once per frame
	void Update () {
	
	}

	public void ShowLoginMenu(){

		currentStep = 0;

		transform.position  = posMenu;
		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, localZ+20f);
		keyboard.transform.position = posKeyboard;

		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, localZ+20f);
	
		LeanTween.moveLocalZ (this.gameObject, localZ, 0.5f).setEase (LeanTweenType.easeInOutExpo);

	//	LeanTween.alpha (LoginMenu, 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (textInside, 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);

		LeanTween.moveZ (galerie, initialPosGalierie.z + 10f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveZ (menu, initialPosGalierie.z + 10f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		LeanTween.alphaCanvas (galerie.GetComponent<CanvasGroup>(), 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (topMenuCanvGroup, 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
	}

	public void HideLoginMenu(){
		Invoke ("HideLoginMenuAfterDelay", 0.1f);

	}

	public void HideLoginMenuAfterDelay(){
		
		LeanTween.moveLocalZ (this.gameObject, localZ-20f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

	//	LeanTween.alpha (LoginMenu, 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (textInside, 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);

		LeanTween.alpha (keyboard, 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (keyboardBG, 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);

		LeanTween.moveZ (galerie, initialPosGalierie.z, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveZ (menu, initialPosMenu.z, 0.5f).setEase (LeanTweenType.easeInOutExpo).setOnComplete(MoveOutOftheWay);

		LeanTween.alphaCanvas (galerie.GetComponent<CanvasGroup>(), 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alphaCanvas (topMenuCanvGroup, 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);

		topMenu.SwitchLoggedInOut ();

	}

	private void MoveOutOftheWay(){
		transform.position = new Vector3 (0f, -20f, 0f);
		keyboard.transform.position = new Vector3 (0f, -20f, 0f);
	}

	private void TurnOffGalery(){
		thumbnails.gameObject.SetActive (false);
	}

	private void TurnOnGalery(){
		thumbnails.gameObject.SetActive (true);
	}


	public void ShowKeyboard(){
	keyboard.gameObject.SetActive (true);
	   LeanTween.alpha (keyboard, 1f, 0.2f).setEase (LeanTweenType.easeInCubic);
	   LeanTween.alpha (keyboardBG, 1f, 0.2f).setEase (LeanTweenType.easeInCubic);
	}


	public void HideKeyboard(){
		LeanTween.alpha (keyboard, 0.0f, 0.2f).setEase (LeanTweenType.easeInCubic);
		LeanTween.alpha (keyboardBG, 0f, 0.2f).setEase (LeanTweenType.easeInCubic).setOnComplete(turnOffKeyboard);
	}

	private void turnOffKeyboard(){
		keyboard.gameObject.SetActive (false);
	}

	public void FocusInputLine1(){
		EmailInput.transform.GetChild(0).GetComponent<Text>().text  = "|";

		ShowKeyboard ();
		LeanTween.moveLocalZ (EmailInput, -39f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (EmailInput.GetComponent<RectTransform>(), 1f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalY (gameObject, -9.3f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		currentStep = 1;
	}

	public void FocusInputLine2(){
		PWInput.transform.GetChild(0).GetComponent<Text>().text  = "|";

		LeanTween.moveLocalZ (EmailInput, 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (EmailInput.GetComponent<RectTransform>(), 0.7f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		ShowKeyboard ();
		LeanTween.moveLocalZ (PWInput, -39f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (PWInput.GetComponent<RectTransform>(), 1f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalY (gameObject, 8.5f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		currentStep = 2;
	}

	public void LoginNoFocus(){
		HideKeyboard ();
		LeanTween.alpha (EmailInput.GetComponent<RectTransform>(), 0.7f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.alpha (PWInput.GetComponent<RectTransform>(), 0.7f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		LeanTween.moveLocalZ (PWInput, 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalZ (EmailInput, 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		//LeanTween.moveLocalZ (gameObject, localZ, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalY (gameObject, localY, 0.5f).setEase (LeanTweenType.easeInOutExpo);

	}

	public void KeyboardNextStep(){
		if (currentStep == 1) {
			// display text in field 1
			EmailInput.transform.GetChild(0).GetComponent<Text>().text  = "xaver@delightex.com";
			EmailInput.transform.GetChild (0).GetComponent<Text> ().color = new Color (0.2f, 0.2f, 0.2f, 1f);

			FocusInputLine2 ();
		} else if (currentStep == 2) {
			// display text in field 2
			PWInput.transform.GetChild(0).GetComponent<Text>().text  = "******";
			PWInput.transform.GetChild (0).GetComponent<Text> ().color = new Color (0.2f, 0.2f, 0.2f, 1f);

			LoginNoFocus();
		}

	}
}
