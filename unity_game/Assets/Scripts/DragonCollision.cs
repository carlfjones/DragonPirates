using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonCollision : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
      GameObject death = GameObject.FindWithTag("Dragon");
        if (other.GetComponent<Dragon>() != null)
        {
            GameControl.instance.DragonDied();
            Destroy(death);
        }
    }
}
