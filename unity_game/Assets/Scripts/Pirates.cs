using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pirates : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Dragon>() != null)
        {
            GameControl.instance.DragonScored();
        }
    }
}
