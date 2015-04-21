using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

[RequireComponent(typeof(ParticleSystem))]
public class RainControl : MonoBehaviour
{
	ParticleSystem m_System;
	ParticleSystem.Particle[] m_Particles;
	private float carSpeed = 0.01f;
	public CarController carScript;

	void Start() { 
		//carScript = car.GetComponent<CarController>();
	}

	private void LateUpdate()
	{
		InitializeIfNeeded();

		carSpeed = carScript.CurrentSpeed * -0.02f;

		// GetParticles is allocation free because we reuse the m_Particles buffer between updates
		int numParticlesAlive = m_System.GetParticles(m_Particles);

		// Change only the particles that are alive
		for (int i = 0; i < numParticlesAlive; i++)
		{
			m_Particles[i].velocity += Vector3.up * carSpeed;
		}

		// Apply the particle changes to the particle system
		m_System.SetParticles(m_Particles, numParticlesAlive);
	}

	void InitializeIfNeeded()
	{
		if (m_System == null)
			m_System = GetComponent<ParticleSystem>();

		if (m_Particles == null || m_Particles.Length < m_System.maxParticles)
			m_Particles = new ParticleSystem.Particle[m_System.maxParticles]; 
	}
}