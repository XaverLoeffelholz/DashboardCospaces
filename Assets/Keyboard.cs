using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Keyboard : MonoBehaviour {

	public Sprite Standard;
	public Sprite Hover;
	public Sprite Clicked;

	public Image keyboardSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Focus(){
		keyboardSprite.sprite = Hover;
	}

	public void UnFocus(){
		keyboardSprite.sprite = Standard;
	}

	public void Click(){
		keyboardSprite.sprite = Clicked;
	}


}
