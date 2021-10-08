using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    [SerializeField] private float _lerpSpeed;
    void Update()
    {
        Vector3 _mousePos = Camera.main.ScreenToWorldPoint(new Vector3(
            Input.mousePosition.x,
            0f,
            0f
        ));

        _mousePos.x = Mathf.Clamp(_mousePos.x, -1.48f, 1.48f);
        

        transform.position = Vector3.Lerp(transform.position, _mousePos, _lerpSpeed * Time.deltaTime);
        transform.position = new Vector3(
            transform.position.x,
            -3.5f,
            0f
        );
    }
}
