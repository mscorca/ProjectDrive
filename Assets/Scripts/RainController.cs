using UnityEngine;
using System.Collections;

public class RainController : MonoBehaviour {

	public GameObject player;
	private Transform t;
	private Transform otherT;
	private ParticleSystem ps;
	
	public float activateDist = 200f;
	private float dist;
	private int emissionMultiplier;

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

		if(ps.emissionRate > 12000){
			emissionMultiplier = -200;
		} else if (ps.emissionRate < 8000){
			emissionMultiplier = 200;
		}

		ps.emissionRate += Time.deltaTime * emissionMultiplier;

	}
}
