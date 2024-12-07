using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField]
    float _horizontalForce = 5.0f;

    [SerializeField]
    float _verticalForce = 5.0f;

    Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float yInput = Input.GetAxisRaw("Vertical");

        if (xInput != 0.0f)
        {
            Vector2 force = Vector2.right * xInput * _horizontalForce;
            _rigidbody2D.AddForce(force);
        }
        else if (yInput != 0.0f)
        {
            Vector2 force = Vector2.up * yInput * _verticalForce;
            _rigidbody2D.AddForce(force);
        }

    }
}
