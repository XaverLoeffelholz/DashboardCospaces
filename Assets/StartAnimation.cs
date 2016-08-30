using UnityEngine;
using System.Collections;

public class StartAnimation : MonoBehaviour {

	public GameObject sphere1Container;
	public GameObject sphere2Container;

	public GameObject sphere1;
	public GameObject sphere2;

	public CanvasGroup StartButton;

	public GameObject glowPlane;
	public GameObject glowPlane2;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){

	}

	public void UnFocus(){

	}

	public void StartTheAnimation(){
		StartButton.interactable = false;
		StartButton.blocksRaycasts = false;

		LeanTween.alphaCanvas (StartButton, 0f, 0.3f).setEase (LeanTweenType.easeInOutCubic);

		LeanTween.alpha(glowPlane2, 1f, 0.7f).setDelay(0.5f).setEase(LeanTweenType.easeInCubic);
		LeanTween.alpha(glowPlane2, 0f, 2f).setDelay(1f).setEase(LeanTweenType.easeOutCubic);

		LeanTween.rotate(sphere1Container, new Vector3(-90f,0f,0f), 1.4f).setDelay(0.2f).setEase(LeanTweenType.easeInExpo).setOnComplete(DeactiveateSphere);
		LeanTween.rotate(sphere2Container, new Vector3(90f,0f,0f), 1.4f).setDelay(0.2f).setEase(LeanTweenType.easeInExpo);

		LeanTween.alpha(glowPlane, 0f, 0.8f).setDelay(0.7f).setEase(LeanTweenType.easeInCubic);
	}

	public void DeactiveateSphere(){
		sphere1.SetActive (false);
		sphere2.SetActive (false);

		StartButton.interactable = false;
		StartButton.blocksRaycasts = false;
	}

	public void EndAnimation(){
		sphere1.SetActive (true);
		sphere2.SetActive (true);

		StartButton.interactable = true;
		StartButton.blocksRaycasts = true;

		LeanTween.rotate(sphere1Container, new Vector3(0f,0f,0f), 0.9f).setEase(LeanTweenType.easeOutExpo).setOnComplete(ActivateGlow);
		LeanTween.rotate(sphere2Container, new Vector3(0f,0f,0f), 0.9f).setEase(LeanTweenType.easeOutExpo);

		LeanTween.alphaCanvas (StartButton, 1f, 0.3f).setDelay(0.4f).setEase (LeanTweenType.easeInOutCubic);
	}

	public void ActivateGlow(){
		LeanTween.alpha(glowPlane, 1f, 0.1f);
	}
}
