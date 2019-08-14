using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallTwo : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem explosion;
    [SerializeField]
    GameObject arrow;



    float fireRate;
    float nextFire;

    void Start () {
      fireRate = 3f;
      nextFire = Time.time + 45f;
    }

    // Update is called once per frame
    void Update() {
      CheckIfTimeToFire ();
    }

    void CheckIfTimeToFire(){
      if (Time.time > nextFire) {
        Instantiate(arrow, transform.position, Quaternion.identity);
        nextFire = Time.time + fireRate;
      }
    }


}
