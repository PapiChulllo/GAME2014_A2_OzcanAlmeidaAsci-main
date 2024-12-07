using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField]
    float _horizontalForce;
    [SerializeField]
    float _horizontalSpeedLimit;
    [SerializeField]
    float _verticalForce;
    [SerializeField]
    [Range(0f, 1f)]
    float _airFactor;

    Rigidbody2D _rigidbody;

    bool _isGrounded = false;

    [SerializeField]
    Transform _groundingPoint;

    [SerializeField]
    float _groundingRadius;

    [SerializeField]
    LayerMask _groundLayerMask;
   

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        
        GameObject gameObject = GameObject.Find("GameController");
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIsGrounded();
        ReadInput();       
    }

    void ReadInput()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float xInput = UnityEngine.Input.GetAxisRaw("Horizontal");        

        if (xInput != 0.0f)
        {
            Vector2 force = Vector2.right * xInput * _horizontalForce;
            if (!_isGrounded)
            {
                force = new Vector2(force.x * _airFactor, force.y);
            }            
            _rigidbody.AddForce(force);
            GetComponent<SpriteRenderer>().flipX = (force.x < 0.0f);
            if (Mathf.Abs(_rigidbody.velocity.x) > _horizontalSpeedLimit)
            {
                float xVel = Mathf.Clamp(_rigidbody.velocity.x, -_horizontalSpeedLimit, _horizontalSpeedLimit);
                _rigidbody.velocity = new Vector2(xVel, _rigidbody.velocity.y);
            }
        }
    }

    void Jump()
    {
        bool jumpPressed = UnityEngine.Input.GetButtonDown("Jump");        

        if (_isGrounded && jumpPressed)
        {
            //_rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _verticalForce);                        
            _rigidbody.AddForce(Vector2.up * _verticalForce, ForceMode2D.Impulse);
        }
    }

    void CheckIsGrounded()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundingPoint.position, _groundingRadius, _groundLayerMask);        
    }



    public void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(_groundingPoint.position, _groundingRadius);
    }
}
