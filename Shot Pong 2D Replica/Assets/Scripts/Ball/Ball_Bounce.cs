using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Bounce : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Vector3 _lastVelocity;
    void Update()
    {
        _lastVelocity = rb.velocity;        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        var _moveSpeed = _lastVelocity.magnitude; // Vector3 uzunluğunu bize float olarak döndürüyor.
        var _direction = Vector3.Reflect(_lastVelocity.normalized, other.contacts[0].normal);
        // Bir Vector3 değişkenin, aynı herhangi bir nesnenin bir aynada sahip olduğu yansıması gibi,
        //bir normal ekseni kullanılarak yansıması elde edilmesini sağlayan fonksiyondur. 
        //İlk değişkeni yanstılacak orijinal obje, diğer değişken de yansıtma için kullanılacak 
        //Vektor3 tipindeki değişkendir.
        rb.velocity = _direction * Mathf.Max(_moveSpeed, 0f); 
    }
}
