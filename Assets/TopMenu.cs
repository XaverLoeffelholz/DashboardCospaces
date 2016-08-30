using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TopMenu : MonoBehaviour {

	private CanvasGroup canv;
	public CanvasGroup thumbnails;

	public GameObject galerie;
	public GameObject meineProjekte;
	public GameObject angesehene;
	public GameObject loginout;

	public GameObject MenuLeft;
	public GameObject MenuRight;

	public bool loggedin = false;

	public GreenButton createButton;

	// Use this for initialization
	void Start () {
		canv = this.GetComponent<CanvasGroup> ();

		if (!loggedin) {
			Logout ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus() {
		//	LeanTween.moveLocalZ (this.gameObject, -300f, 0.3f);
		//	LeanTween.alphaCanvas (canv, 1f, 0.3f);
	}

	public void DeFocus(){
	//	LeanTween.moveLocalZ (this.gameObject, -260f, 0.3f);
		//	LeanTween.alphaCanvas (canv, 0.7f, 0.3f);
	}

	public void SwitchLoggedInOut(){
		if (loggedin) {
			Logout ();
		} else {
			Login ();
		}
	}

	public void Login(){
		loginout.SetActive (false);
		meineProjekte.SetActive (true);

		if (meineProjekte.GetComponent<MenuBottomElement> ().box != null) {
			meineProjekte.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (true);
		}

		angesehene.SetActive (true);
		galerie.SetActive (true);

		if (angesehene.GetComponent<MenuBottomElement> ().box != null) {
			angesehene.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (true);
		}

		if (galerie.GetComponent<MenuBottomElement> ().box != null) {
			galerie.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (true);
		}

		createButton.MovePos2 ();

		MenuLeft.SetActive (true);
		MenuRight.SetActive (true);
	}

	public void Logout(){
		loginout.SetActive (true);
		meineProjekte.SetActive (false);

		if (meineProjekte.GetComponent<MenuBottomElement> ().box != null) {
			meineProjekte.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (false);
		}

		galerie.SetActive (false);
		angesehene.SetActive (false);

		if (galerie.GetComponent<MenuBottomElement> ().box != null) {
			galerie.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (false);
		}

		if (angesehene.GetComponent<MenuBottomElement> ().box != null) {
			angesehene.GetComponent<MenuBottomElement> ().box.gameObject.SetActive (false);
		}

		createButton.MovePos1 ();

		MenuLeft.SetActive (false);
		MenuRight.SetActive (false);
	}
}
