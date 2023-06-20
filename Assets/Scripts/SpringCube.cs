using System;
using UnityEngine;

public class SpringCube : MonoBehaviour
{
    private Animator _anim;
    private int _count;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _count = 0;
    }

    private void FixedUpdate()
    {
        if (_count >= 2)
        {
            _anim.SetBool("GoSpring", true);
            Debug.Log(_count);
        }
        else
        {
            _anim.SetBool("GoSpring", false);
        }
    }

    public int CounterBeforeSpring => _count++;

    public int CounterAfterSpring => _count = 0;
}
