using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float Damage = 1.5f;
    public float range = 100F;
    public Camera fpsc;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsc.transform.position, fpsc.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }
    }
}
