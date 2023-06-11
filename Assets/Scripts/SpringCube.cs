using System;
using UnityEngine;

public class SpringCube : MonoBehaviour
{
    private Animator anim;

    private float time = 2;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time -= Time.deltaTime;
        Debug.Log(time);
        if (time <= 0)
        {
            anim.SetBool("goSpring", true);
            time = 2;
        }
        else
        {
            anim.SetBool("goSpring", false);
        }
    }

}
