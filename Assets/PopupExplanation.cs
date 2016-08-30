using UnityEngine;
using System.Collections;

public class PopupExplanation : MonoBehaviour {

	float localZ;

	public GameObject galerie;
	public GameObject menu;

	private Vector3 initialPosGalierie;
	private Vector3 initialPosMenu;

	// Use this for initialization
	void Start () {
		localZ = transform.localPosition.z;

		transform.localPosition = new Vector3 (transform.localPosition.x, transform.localPosition.y, localZ+20f);

		if (galerie != null) {
			initialPosGalierie = galerie.transform.position;
			initialPosMenu = menu.transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Show(){
		LeanTween.alphaCanvas (this.GetComponent<CanvasGroup> (), 1f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalZ (this.gameObject, localZ, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		if (galerie != null) {
			LeanTween.moveZ (galerie, initialPosGalierie.z + 10f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
			LeanTween.moveZ (menu, initialPosGalierie.z + 10f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

			LeanTween.alphaCanvas (galerie.GetComponent<CanvasGroup>(), 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
			LeanTween.alphaCanvas (menu.GetComponent<CanvasGroup>(), 0f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		}

		Activate ();
	}

	public void Hide(){		
		LeanTween.alphaCanvas (this.GetComponent<CanvasGroup> (), 0f, 0.5f).setEase (LeanTweenType.easeInOutExpo);
		LeanTween.moveLocalZ (this.gameObject, localZ+20f, 0.5f).setEase (LeanTweenType.easeInOutExpo);

		if (galerie != null) {
			LeanTween.moveZ (galerie, initialPosGalierie.z, 0.5f).setEase (LeanTweenType.easeInOutExpo);
			LeanTween.moveZ (menu, initialPosMenu.z, 0.5f).setEase (LeanTweenType.easeInOutExpo);

			LeanTween.alphaCanvas (galerie.GetComponent<CanvasGroup> (), 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
			LeanTween.alphaCanvas (menu.GetComponent<CanvasGroup> (), 1f, 0.3f).setEase (LeanTweenType.easeInOutExpo);
		}

		DeActivate ();
	}

	private void Activate(){
		this.GetComponent<CanvasGroup> ().interactable = true;
		this.GetComponent<CanvasGroup> ().blocksRaycasts = true;
	}

	private void DeActivate(){
		this.GetComponent<CanvasGroup> ().interactable = false;
		this.GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}
}
