using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float updrift;
    private bool isAlive = true;

    public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            myRigidBody.velocity = Vector2.up * updrift;
        }

        if (transform.position.y > 10 || transform.position.y < -10)
        {
            Destroy(gameObject.GetComponent<Rigidbody2D>());
            logic.gameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject.GetComponent<Rigidbody2D>());
        logic.gameOver();
        isAlive = false;
    }
}
