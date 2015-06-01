using UnityEngine;
using System.Collections;

public class starSpawn : MonoBehaviour {

	public GameObject star;
	public float spawnFreq;
	public float TTL;
	public float upperSpawnLocation, lowerSpawnLocation;

	Vector2 spawnPos;
	float nextSpawn;


	void Update (){

		if(Time.time > nextSpawn)
		{
			nextSpawn = Time.time + spawnFreq;
			spawnStars();
		}
	}

	void spawnStars ()
	{
		spawnPos = new Vector2 (transform.position.x, Random.Range (lowerSpawnLocation, upperSpawnLocation)); //generate a random y value
		GameObject starClone = (GameObject)Instantiate (star, spawnPos, Quaternion.identity);
		Destroy(starClone, TTL);
	}
}