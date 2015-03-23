using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	public int UpDown;
	public int LeftRight;
	public int Keyboard;
	public int Road;
	public int Wall;
    public int wtf;
	//WTF
	// Use this for initialization
	void Start () {
	UpDown = 0;
	LeftRight = 0;
	Keyboard = 0;
	Road = 0;
	Wall = 0;
	gameObject.tag = "Player";
	}
	//qqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqqq

	// Update is called once per frame
	void Update () {
		if (Road == 0) {
			if (UpDown != 1 && Input.GetKeyDown (KeyCode.UpArrow)) {
				transform.Translate (0, 1, 0);
				Keyboard = 1;
			}
			if (UpDown != 2 && Input.GetKeyDown (KeyCode.DownArrow)) {
				transform.Translate (0, -1, 0);
				Keyboard = 2;
			}
			if (LeftRight != 3 && Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.Translate (1, 0, 0);
				Keyboard = 3;
			}
			if (LeftRight != 4 && Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.Translate (-1, 0, 0);
				Keyboard = 4;
			}
		}
		//text
		if (Road == 1) {
			if (UpDown != 1 && Input.GetKeyDown (KeyCode.UpArrow)) {
				transform.Translate (0, 1, 0);
				Keyboard = 1;
			}
			//wwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww
			if (UpDown != 2 && Input.GetKeyDown (KeyCode.DownArrow)) {
				transform.Translate (0, -1, 0);
				Keyboard = 2;
			}
		}
		//aaa
		if(Road == 2){
			if (LeftRight != 3 && Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.Translate (1, 0, 0);
				Keyboard = 3;
			}
			if (LeftRight != 4 && Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.Translate (-1, 0, 0);
				Keyboard = 4;
			}
		}
		if (UpDown != 0 || LeftRight != 0) {
			Wall = 1;
		}
		if(this.tag != "Player"){
			gameObject.isTrigger.enabed = true;
		}
		//Debug.Log (UpDown);
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "UPDOWN") {
			if(Keyboard == 1)
			UpDown = 1;
			if(Keyboard == 2)
			UpDown = 2;
		gameObject.tag = "UPDOWN";
		}
		if (other.tag == "LEFTRIGHT") {
			if(Keyboard == 3)
				LeftRight = 3;
			if(Keyboard == 4)
				LeftRight = 4;
		gameObject.tag = "LEFTRIGHT";
		}
	}
	void OnTriggerExit (Collider other) {
	gameObject.tag = "Player";
		if (other.tag == "ROADUPDOWN" || other.tag == "ROADLEFTRIGHT") {
			Road = 0;
		}
		if (other.tag == "UPDOWN" ) {
			UpDown = 0;
			Wall = 0;
		}
		if (other.tag == "LEFTRIGHT" ) {
			LeftRight = 0;
			Wall = 0;
		}
	}
	void OnTriggerStay (Collider other) {
		if (other.tag == "ROADUPDOWN") {
			Road = 1; 
		}
		if (other.tag == "ROADLEFTRIGHT") {
			Road = 2; 
		}
	}
}
