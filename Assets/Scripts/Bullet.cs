using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;
    public float velocity = 2f;
    public Vector2 direction;

    public float livingTime = 2f;
    public Color initialColor = Color.white;
    public Color finalColor;

    private SpriteRenderer _renderer;
    private float _startingTime;
    private Rigidbody2D _rigidbody;

    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Guarda el tiempo inicial
        _startingTime = Time.time;

        //Destroy the bullet after some time
        Destroy(this.gameObject, livingTime);
    }

    // Update is called once per frame
    void Update()
    {
        
        // Cambiar color de bala
        float _timeSinceStarted = Time.time - _startingTime;
        float _percentageCompleted = _timeSinceStarted / livingTime;

        _renderer.color = Color.Lerp(initialColor, finalColor, _percentageCompleted);
    }

    private void FixedUpdate()   
    {
        //Move Object
        Vector2 movement = direction.normalized * speed;
        _rigidbody.velocity = movement;
    }
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.CompareTag("Player")) {
            Debug.Log("Encontre al player");
        }
    }
}
