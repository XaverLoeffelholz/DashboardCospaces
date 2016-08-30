using UnityEngine;
using System.Collections;

public class GroundMenuCollision : MonoBehaviour {

	public GroundMenu menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other) {
		
		if (other.gameObject.CompareTag("groundMenuCollider")) {
			menu.ShowGroundMenu ();
			other.gameObject.GetComponent<MenuColliderObject> ().ShowingGroundMenu = true;
		}

	}

	void OnTriggerExit(Collider other) {

		if (other.gameObject.CompareTag("groundMenuCollider")) {
			menu.HideGroundMenu ();
		}

	}
}
