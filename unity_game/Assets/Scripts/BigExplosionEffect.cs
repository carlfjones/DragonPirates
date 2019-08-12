using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigExplosionEffect : MonoBehaviour
{

    // Start is called before the first frame update
    void Explode() {
       var exp = GetComponent<ParticleSystem>();
       exp.Play();
   }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D coll) {
        Explode();
        var exp = GetComponent<ParticleSystem>();
        Destroy(gameObject, exp.duration);
    }
}
