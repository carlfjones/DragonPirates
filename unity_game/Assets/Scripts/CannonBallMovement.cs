using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallMovement : MonoBehaviour
{
  float moveSpeed = 7f;

    Rigidbody2D rb2d;

    Dragon target;
    Vector2 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        target = GameObject.FindObjectOfType<Dragon>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb2d.velocity = new Vector2 (moveDirection.x, moveDirection.y);
        Destroy (gameObject, 100f);
    }

    // Update is called once per frame
    void OnTriggerEnter2d (Collider2D col)
    {
      if (col.gameObject.name.Equals ("Dragon")) {
        Destroy (gameObject);
      }
    }
}
