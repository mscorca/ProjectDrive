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
	
	// Update is called once per frame
	void Update () {
		if(t.position.z > (startPos.z + 100)){
			t.position = new Vector3(t.position.x, t.position.y, startPos.z - 100);
			totalChunksTraveled++;
		} else if (t.position.z < (startPos.z - 100)){
			t.position = new Vector3(t.position.x, t.position.y, startPos.z + 100);
			totalChunksTraveled--;
		}

	}
}
