using UnityEngine;
using System.Collections;

public class blockController2 : MonoBehaviour {

	int speed;
	public int direct;
	// Use this for initialization
	void Start () {
		speed = Random.Range (3, 5);
	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector2.right * speed * Time.deltaTime);
	}
}