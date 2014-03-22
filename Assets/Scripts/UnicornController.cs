using UnityEngine;
using System.Collections;

public class UnicornController : MonoBehaviour {
	
	private Direction direction;
	public GameObject theStar;	
	public int speed;

	// Use this for initialization
	void Start () {
		direction = Direction.Right;
	}
	
	// Update is called once per frame
	void Update () {
				/*"Den lette måde"
				 * rigidbody2D.velocity = new Vector2 (speed * Input.GetAxis ("Horizontal"), 
		                                speed * Input.GetAxis ("Vertical"));
*/

		// Den besværlige måde
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log("left");
			direction = Direction.Left;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log("rigth");
			direction = Direction.Right;
		} else {
			Debug.Log ("none");
			direction = Direction.None;		
		}
		this.rigidbody2D.velocity = lateralVector ();
	}

	// Kaldes hver gang objektets collider bliver left-klikket på
	void OnMouseDown (){
		Instantiate (theStar);
	}

	private Vector2 lateralVector(){
		return new Vector2((int)direction * speed,0);
	}
}
