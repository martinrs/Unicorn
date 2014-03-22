using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public Vector2 bounds {
		get;
		private set;
	}

	// Use this for initialization
	void Start () {
		BoxCollider2D bc = GetComponent<BoxCollider2D>(); 
		bounds = new Vector2 (Camera.main.orthographicSize * 2 * Camera.main.aspect, 
		                          Camera.main.orthographicSize * 2);

		bc.size = bounds;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
