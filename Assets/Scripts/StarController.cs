using UnityEngine;
using System.Collections;

public class StarController : MonoBehaviour {

	private Direction direction;
	public int xMax;
	public int yMax;
	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		direction = Direction.Left;
		GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, 6)];
		rigidbody2D.velocity = RandomVector();
		rigidbody2D.angularVelocity = Random.Range (-360, 361);
	}
	
	// Update is called once per frame
	void Update () {

	}

	private Vector2 RandomVector(){
		return new Vector2(Random.Range(0, (int)this.direction * this.xMax), 
		                   Random.Range(0, this.yMax));
	}
}
