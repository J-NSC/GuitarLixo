using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public Rigidbody2D rb;
    public float vel; 
    // Start is called before the first frame update

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        rb.velocity = new Vector2(0,-vel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
