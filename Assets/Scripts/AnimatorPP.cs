using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorPP : MonoBehaviour {
    private Animator animator;
    private float v;
	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        v = Input.GetAxis("Vertical");
	}

    private void FixedUpdate()
    {
        animator.SetFloat("Walk", v);
    }
}
