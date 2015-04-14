using UnityEngine;
using System.Collections;

public class RainController : MonoBehaviour {

	public GameObject player;
	private Transform t;
	private Transform otherT;
	private ParticleSystem ps;
	
	public float activateDist = 200f;
	private float dist;

	void Start () {
		t = GetComponent<Transform>();
		ps = GetComponent<ParticleSystem>();
		otherT = player.transform;
	}
	
	void Update () {
		dist = Vector3.Distance(t.position, otherT.position);

		if(dist <= activateDist && !ps.isPlaying){
			ps.Play();
		} else if (dist >= activateDist) {
			ps.Stop();
		}
	}
}
