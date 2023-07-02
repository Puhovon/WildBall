using System;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private ParticleSystem particles;
    private Animator animator;
    private void Awake()
    {
        particles = GetComponentInChildren<ParticleSystem>();
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("Collect");
    }

    private void StartParticle()
    {
        particles.Play();
    }
}
