using UnityEngine;
using System.Collections;

public class EndlessDrive : MonoBehaviour {

	public int totalChunksTraveled;

	private Vector3 startPos;
	private Transform t;

	// Use this for initialization
	void Start () {
		t = GetComponent<Transform>();
		startPos = t.position;
		totalChunksTraveled = 0;
	}
	
	void Update () {
		// Driving on road
		if(t.position.z > (startPos.z + 100)){
			t.position = new Vector3(t.position.x, t.position.y, startPos.z);
			totalChunksTraveled++;
		} else if (t.position.z < (startPos.z - 100)){
			t.position = new Vector3(t.position.x, t.position.y, startPos.z);
			totalChunksTraveled--;
		// Away from road
		} else if (t.position.x > (startPos.x + 100)){
			t.position = new Vector3(startPos.x, t.position.y, t.position.z);
		} else if (t.position.x < (startPos.x - 100)){
			t.position = new Vector3(startPos.x, t.position.y, t.position.z);
		}

	}
}
