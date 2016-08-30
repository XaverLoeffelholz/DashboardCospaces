using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class whiteCanvas : MonoBehaviour {

	public RectTransform white;
	public GameObject loadingPrefab;

	private int levelNumber;

	// Use this for initialization
	void Start () {

		if (white.gameObject.GetComponent<Image> ().color.a == 1f) {
			FadeOut ();
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void FadeInFirstTime() {
		LeanTween.alpha (white, 1f, 0.6f).setOnComplete (FadeOutFirst).setEase(LeanTweenType.easeInCubic);
	}

	public void FadeIn() {
		
		if (levelNumber == 0) {
			//menu:
			LeanTween.alpha (white, 1f, 0.6f).setOnComplete (LoadLevelMenuScene).setDelay(1.6f);
		} else if (levelNumber == 1) {
			//level 1:
			LeanTween.alpha (white, 1f, 0.6f).setOnComplete (LoadLevel1Scene).setDelay(1.6f);
		} else if (levelNumber == 2) {
			//level2:
			LeanTween.alpha (white, 1f, 0.6f).setOnComplete(LoadLevel2Scene).setDelay(1.6f);
		}

	}


	public void FadeOutFirst(){
		GameObject galery = GameObject.Find ("Galerie");
		if (galery != null) {
			galery.GetComponent<CanvasGroup> ().alpha = 0f;
		}

		GameObject objects = GameObject.Find ("Low poly stuff");
		if (objects != null) {
			objects.SetActive (false);
		}

		GameObject groundMenu = GameObject.Find ("GroundMenu");
		if (groundMenu != null) {
			groundMenu.SetActive (false);
		}

		Instantiate (loadingPrefab);
		LeanTween.alpha (white, 0f, 0.3f).setOnComplete(FadeIn);

	}


	public void FadeOut(){
		LeanTween.alpha (white, 0f, 0.5f);
	}

	public void StartLoadingScene(){
		Application.LoadLevel("Loading Scene");
	}

	public void StartMainScene(){
		Application.LoadLevel("MainSceneAlternative");
	}

	public void Back() {
		Debug.Log ("back!");
		LeanTween.alpha (white, 1f, 0.6f).setOnComplete(StartMainScene);

	}

	public void LoadLevel1(){
		levelNumber = 1;
		FadeInFirstTime ();
	}

	public void LoadLevel2(){
		levelNumber = 2;
		FadeInFirstTime();
	}

	public void LoadLevelMenu(){
		levelNumber = 0;
		FadeInFirstTime();
	}

	public void LoadLevel1Scene(){		
		Application.LoadLevel("Space1");
	
	}

	public void LoadLevel2Scene(){
		Application.LoadLevel("Space2");
	}

	public void LoadLevelMenuScene(){
		Application.LoadLevel("MainSceneAlternative");
	}
		
}
