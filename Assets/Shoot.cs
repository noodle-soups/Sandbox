using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    [SerializeField] ParticleSystem shootParticle;

    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            shootParticle.Play();
        }
        
    }

}
