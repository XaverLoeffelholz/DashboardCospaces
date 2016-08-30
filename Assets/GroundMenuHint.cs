using UnityEngine;
using System.Collections;

public class GroundMenuHint : MonoBehaviour {

	public GroundMenu menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag("groundMenuCollider")) {
			if (!other.gameObject.GetComponent<MenuColliderObject> ().ShowingGroundMenu) {
				menu.ShowHint ();
			} else {
				other.gameObject.GetComponent<MenuColliderObject> ().ShowingGroundMenu = false;
			}

		}

	}

	void OnTriggerExit(Collider other) {

		if (other.gameObject.CompareTag("groundMenuCollider")) {
			menu.HideHint ();
		}

	}
}
