using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {

	public Color hoverColor;

	private int currentMenu;

	public CanvasGroup[] menuPages;
	public CanvasGroup menuPage1;
	public CanvasGroup menuPage2;
	public CanvasGroup menuPage3;

	public GameObject[] spheres;
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject sphere3;

	public GameObject meineProjekteSphere;
	public CanvasGroup meineProjekteMenu;

	public GameObject buttonLeft;
	public GameObject buttonRight;

	private GameObject currentSphere;

	public GameObject MenuTop;
	public float yValueStartMenuTop;
	public GameObject Logo;
	public float yValueStartLogo;
	public GameObject bottomMenu;
	public float yValueStartBottomMenu;

	public GameObject login;
	public GameObject keyboard;

	public Text currentPage;


	public GameObject Shadow1;
	public GameObject Shadow2;
	public GameObject Shadow3;

	// Use this for initialization
	void Start () {
		currentMenu = 1;

		spheres = new GameObject[3];
		spheres [0] = sphere1;
		spheres [1] = sphere2;
		spheres [2] = sphere3;
		currentSphere = sphere1; 

		menuPages = new CanvasGroup[3];
		menuPages [0] = menuPage1;
		menuPages [1] = menuPage2;
		menuPages [2] = menuPage3;


		yValueStartMenuTop = MenuTop.transform.localPosition.y;
		yValueStartLogo = Logo.transform.localPosition.y;
		yValueStartBottomMenu = bottomMenu.transform.localPosition.y;

		Page1 ();
		ShowGalerie ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Page1(){
		GoToPage (1);

	}

	public void Page2(){
		GoToPage (2);

	}

	public void Page3(){
		GoToPage (3);

	}

	public void GoToPage(int number){

		currentMenu = number;

		float currentRotation = sphere1.transform.localRotation.eulerAngles.y;
		float goalRotation = ((number - 1) * (-40f)) - currentRotation;

		if (goalRotation < -120f) {
			goalRotation += 360f; 
		}


		RotateSpheres (goalRotation);

		if (number == 1) {
			ActivateSphere (sphere1);
			FadeInCurrentMenu (menuPage1);
			LeanTween.alpha (Shadow1, 0.3f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow2, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow3, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
		} else if (number == 2) {
			ActivateSphere (sphere2);
			FadeInCurrentMenu (menuPage2);
			LeanTween.alpha (Shadow1, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow2, 0.3f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow3, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
		}else if (number == 3) {
			ActivateSphere (sphere3);
			FadeInCurrentMenu (menuPage3);
			LeanTween.alpha (Shadow1, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow2, 0f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
			LeanTween.alpha (Shadow3, 0.3f, 0.3f).setEase (LeanTweenType.easeInOutQuad);
		}

	}

	public void RotateSpheres(float degree){

		for (int i = 0; i < spheres.Length; i++) {
			LeanTween.rotateAroundLocal (spheres[i], Vector3.up, degree, 0.9f).setEase(LeanTweenType.easeInOutQuad);
		}

	}



	public void RotateMenuRight(){

		RotateSpheres (-40f);

		if (currentMenu == 1) {
			ActivateSphere (sphere2);
			FadeInCurrentMenu (menuPage2);
			Page2();

		} else if (currentMenu == 2) {
			ActivateSphere (sphere3);
			FadeInCurrentMenu (menuPage3);
			Page3();

		} 

	}

	public void RotateMenuLeft(){
		
		RotateSpheres (40f);

		if (currentMenu == 2) {
			ActivateSphere (sphere1);
			FadeInCurrentMenu (menuPage1);
			Page1();

		} else if (currentMenu == 3) {
			ActivateSphere (sphere2);
			FadeInCurrentMenu (menuPage2);
			Page2();

		} 

	}

	public void FadeInCurrentMenu(CanvasGroup menuPage){
		
		LeanTween.alphaCanvas (menuPage, 1f, 0.8f).setEase(LeanTweenType.easeInOutQuad).setDelay(0.1f).setOnComplete(DeactivateOtherSpheres);


		for (int i = 0; i < menuPages.Length; i++) {
			if (menuPages [i] != menuPage) {
				LeanTween.alphaCanvas (menuPages [i], 0f, 0.8f).setEase(LeanTweenType.easeInOutQuad);
			}
		}

	}

	public void ActivateSphere(GameObject sphere){
		sphere.transform.GetChild(0).gameObject.SetActive (true);
		currentSphere = sphere;
	}

	public void DeactivateOtherSpheres(){

		for (int i = 0; i < spheres.Length; i++) {
			if (spheres [i] != currentSphere) {
				spheres [i].transform.GetChild(0).gameObject.SetActive(false);
			}
		}
	}

	public void ShowMeineProjekte(){

		currentPage.text = "My Projects";

		//LeanTween.scaleZ (currentSphere, -5f, 0.8f);
		LeanTween.alphaCanvas(currentSphere.transform.GetChild(0).GetComponent<CanvasGroup>(), 0f, 0.4f);

		//LeanTween.scaleZ (meineProjekteSphere, -17.71f, 0.8f);
		LeanTween.alphaCanvas(meineProjekteMenu, 1f, 0.4f);


	}

	public void ShowGalerie(){

		currentPage.text = "Gallery";

		//LeanTween.scaleZ (meineProjekteSphere, -5f, 0.8f);
		LeanTween.alphaCanvas(meineProjekteMenu, 0f, 0.4f);

		//LeanTween.scaleZ (currentSphere, -17.71f, 0.8f);
		LeanTween.alphaCanvas(currentSphere.transform.GetChild(0).GetComponent<CanvasGroup>(),1f, 0.4f);
	}

	public void ShowRecent(){

		currentPage.text = "Recent";

		//LeanTween.scaleZ (currentSphere, -5f, 0.8f);
		LeanTween.alphaCanvas(currentSphere.transform.GetChild(0).GetComponent<CanvasGroup>(), 0f, 0.4f);

		//LeanTween.scaleZ (meineProjekteSphere, -17.71f, 0.8f);
		LeanTween.alphaCanvas(meineProjekteMenu, 1f, 0.4f);
	}

	public void LoginoutMenu(){
		login.GetComponent<Login> ().ShowLoginMenu ();
	}

	public void HideLoginoutMenu(){

	}
}
