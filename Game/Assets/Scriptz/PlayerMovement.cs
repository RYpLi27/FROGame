using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Transform _transform;
    private Rigidbody _rigidBody;
    private Vector3 _moveVector;
    private void Awake()
    {
        _transform = GetComponent<Transform>();
        _rigidBody = GetComponent<Rigidbody>();

    }
    void Update()
    {
        float verticalMove = Input.GetAxis("Vertical");
        float horizontalMove = Input.GetAxis("Horizontal");


        _moveVector = verticalMove * _transform.forward + horizontalMove * _transform.right;
 //       _transform.position = _transform.position + moveVector * speed * Time.deltaTime;
    }

    private void FixedUpdate()
    {
        _rigidBody.AddForce(_moveVector * speed, ForceMode.Acceleration);
    }
}
