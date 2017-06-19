using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		StartCoroutine ("move");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		transform.Translate (Vector3.forward * 3f * Time.deltaTime);

	}


	IEnumerator move(){
		while (true) {
			yield return new WaitForSeconds (3f);
			transform.eulerAngles -= new Vector3 (0, 180f, 0);

		}


	}

}

