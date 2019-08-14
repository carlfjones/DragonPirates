using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem explosion;
    [SerializeField]
    GameObject arrow;



    float fireRate;
    float nextFire;

    void Start () {
      fireRate = 40f;
      nextFire = Time.time + 30;
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
