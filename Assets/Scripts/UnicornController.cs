using UnityEngine;
using System.Collections;

public class UnicornController : MonoBehaviour {
	
	private Direction direction;
	public GameObject theStar;	
	public int speed;

	private float xMax, xMin, yMax, yMin;

	// Use this for initialization
	void Start () {
		direction = Direction.Right;
		GameController gc = GameObject.FindWithTag ("GameController").GetComponent<GameController>();
		xMax = gc.bounds.x/2;
		xMin = xMax * -1;
		yMax = gc.bounds.y/2;
		yMin = yMax * -1;
	}
	
	// Update is called once per frame
	void Update () {

		// Den besværlige måde
		if (Input.GetKey (KeyCode.LeftArrow)) {
			//Debug.Log("left");
			direction = Direction.Left;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			//Debug.Log("rigth");
			direction = Direction.Right;
		} else {
			//Debug.Log ("none");
			direction = Direction.None;		
		}
		this.rigidbody2D.velocity = makeVector ();

		// Hold unicorn på skærmen
		float resetX = Mathf.Clamp (this.transform.position.x, xMin, xMax);
		float resetY = Mathf.Clamp (this.transform.position.y, yMin, yMax);
		this.transform.position = new Vector3 (resetX, resetY, 1);
	}

	// Kaldes hver gang objektets collider bliver left-klikket på
	void OnMouseDown (){
		Instantiate (theStar);
	}

	private Vector2 makeVector(){
		return new Vector2((int)direction * speed, speed * Input.GetAxis ("Vertical"));
	}
}
