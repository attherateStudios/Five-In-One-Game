using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpBehavior : MonoBehaviour
{
    Rigidbody2D rb2D;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();    
    }

    public void OnButtonClicked()
    {
        Vector2 jumpVelocityToAdd = new Vector2(0f, 7f);
        rb2D.velocity += jumpVelocityToAdd;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.transform.name == "GlassOne")
        {
            this.transform.parent = other.transform;
        }
    }
}
