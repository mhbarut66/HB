using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class SmallStick : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameObject admin;
    [SerializeField] private float speed;
    private bool cantMove;
    private BoxCollider2D col;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        admin = GameObject.FindGameObjectWithTag("Admin");
        col = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        if (!cantMove)
        {
            rb.MovePosition(rb.position + UnityEngine.Vector2.up * speed * Time.fixedDeltaTime);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("RollingCircle"))
        {
            transform.SetParent(other.transform);
            cantMove = true;
            col.enabled = false;
        }
        if (other.gameObject.CompareTag("SmallCircle"))
        {
            admin.GetComponent<GameAdmin>().FinishGame();
        }
    }

    
}
