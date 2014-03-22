using UnityEngine;
using System.Collections;

public class gameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		BoxCollider2D bc = GetComponent<BoxCollider2D>(); 
		Vector2 v2 = new Vector2 (Camera.main.orthographicSize * 3, 
		                          Camera.main.orthographicSize * 3);
		bc.size = v2;
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		Destroy(other.gameObject);
	}
}
