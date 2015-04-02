using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RoadController : MonoBehaviour {

	public Transform[] roads;
	public int roadCount;
	private Transform t;

	// Use this for initialization
	void Start () {
		t = GetComponent<Transform>();

		roads = gameObject.GetComponentsInChildren<Transform>();
		Transform prevRoad = roads[0];
		Debug.Log(prevRoad.position);


		foreach(Transform road in roads){
			if(road != roads[0]){
				Debug.Log("Road i: " + road.position.x + " " + prevRoad.position.z);
				road.position = (new Vector3(0, 0.1f, prevRoad.position.z + 16.0f));
				prevRoad = road;
			}
		}
	}
}