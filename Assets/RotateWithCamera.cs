using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RotateWithCamera : MonoBehaviour {

	private GameObject vrHead;
	private float xRotation;
	private CanvasGroup canvGroup;

	// Use this for initialization
	void Start () {
		vrHead = GameObject.Find ("GvrHead");
		xRotation = this.transform.localRotation.eulerAngles.x;
		canvGroup = GameObject.Find("GroundMenu").GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (canvGroup.alpha <= 0.01f) {
			float newYRotation = vrHead.transform.localRotation.eulerAngles.y - this.transform.localRotation.eulerAngles.y;
			Vector3 newRotation = new Vector3 (0f, newYRotation , 0f);
			this.transform.RotateAround(new Vector3(0,0,0), new Vector3(0f,1f,0f), newYRotation);
		}
	}
}
