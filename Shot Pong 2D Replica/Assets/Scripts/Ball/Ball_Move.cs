using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Move : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Game_Manager game_Manager;

    [Header("Gameplay")]
    [SerializeField] private float _moveSpeed;
    void Start()
    {
        rb.AddForce(new Vector2(
            -2 * _moveSpeed,
            -1 * _moveSpeed
        ));
    }

    private void Update() {
        if(transform.position.y <= -6f) {
            game_Manager.GameOver();
        }    
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.CompareTag("Wall")) {
            transform.position = new Vector3(0f, 4f, 0f);
            game_Manager._score++;
            _moveSpeed += 0.1f;
        }
    }
}
