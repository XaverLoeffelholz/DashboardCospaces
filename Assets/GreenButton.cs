using UnityEngine;
using System.Collections;

public class GreenButton : MonoBehaviour {

	public Color normal;
	public Color hover;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		LeanTween.color (this.GetComponent<RectTransform>(), hover, 0.2f);
	}

	public void UnFocus(){
		LeanTween.color (this.GetComponent<RectTransform>(), normal, 0.2f);
	}

	public void MovePos1(){
		transform.localPosition = new Vector3 (515f, transform.localPosition.y, transform.localPosition.z);
	}

	public void MovePos2(){
		transform.localPosition = new Vector3 (805f, transform.localPosition.y, transform.localPosition.z);
	}
}
