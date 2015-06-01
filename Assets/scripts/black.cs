using UnityEngine;
using System.Collections;

public class black : MonoBehaviour {

	// Use this for initialization
	void Start () {	
		StartCoroutine(wait());

	}
	
	// Update is called once per frame
	void Update () {



	}

	IEnumerator wait(){
		yield return new WaitForSeconds(3.88f);
		GetComponent<Renderer>().enabled = false;
		yield break;
	}
	
}
