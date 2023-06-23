using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    [SerializeField] float speed; //скорость персонажа
    Rigidbody rb; //ссылка на Rigidbody
    Vector3 direction; //Ќаправление движени€
    Animator anim;
    [SerializeField] float jumpSpeed; //высота прыжка
    bool isGrounded; //переменна€, котора€ будет указывать на земле мы или нет
    bool slide;
    Vector3 startPosition;
    void Start()

    {
        startPosition = transform.position;
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (transform.position.y < -25)
        {
            transform.position = startPosition;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        direction = transform.TransformDirection(x, 0, z);

        if (direction.magnitude > 0)

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(new Vector3(0, jumpSpeed, 0), ForceMode.Impulse);
            }
        }
        if (slide)
        {
            rb.AddForce(direction * 1.1f, ForceMode.VelocityChange);
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(transform.position + direction * speed * Time.fixedDeltaTime);
    }




    private void OnCollisionExit(Collision other)

    {
        isGrounded = false;
    }





}