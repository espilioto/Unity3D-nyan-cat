using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	public AudioClip intro;
	public Sprite mute, unmute;
	bool muted = false;

	void Start(){
		StartCoroutine(wait());								//no idea what this is
		GetComponent<SpriteRenderer>().sprite = unmute;		//load default sprite
	}

	void OnMouseDown(){
		if(! muted){
			GetComponent<SpriteRenderer>().sprite = mute;
			GetComponent<AudioSource>().mute = true;
			muted = !muted;
		}
		else{
			GetComponent<SpriteRenderer>().sprite = unmute;
			GetComponent<AudioSource>().mute = false;
			muted = !muted;
		}
	}

	IEnumerator wait(){
		GetComponent<AudioSource>().PlayOneShot(intro);			
		yield return new WaitForSeconds(3.842f);
		GetComponent<AudioSource>().Play();
		yield break;		
	}
}
