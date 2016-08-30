using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuPage : MonoBehaviour {

	float stateBefore;
	private RectTransform obj;
	public bool selected = false;
	private Color hoverColor;
	private RectTransform child;

	// Use this for initialization
	void Start () {
		stateBefore = this.transform.GetChild (0).GetComponent<RectTransform> ().transform.localScale.x;
		obj = this.transform.GetChild (0).GetComponent<RectTransform> ();
		hoverColor = GameObject.Find ("Manager").GetComponent<Manager> ().hoverColor;
		child = this.transform.GetChild (0).GetComponent<RectTransform> ();
	}

	// Update is called once per frame
	void Update () {

	}

	public void Focus(){
		if (!selected) {
			
			stateBefore = this.transform.localScale.x;
			GameObject.Find ("AlphabetMenu").GetComponent<AlphabetMenu> ().DefocusAll ();
			LeanTween.scale (obj, new Vector3(2.4f,2.4f,2.4f), 0.1f);

			LeanTween.textColor (child, hoverColor , 0.3f);
		}

	}

	public void UnFocus(){	
		if (!selected) {
			LeanTween.scale (obj, new Vector3 (1.6f, 1.6f, 1.6f), 0.05f);
			LeanTween.textColor (child, Color.white, 0.3f);
		}
	}
}
