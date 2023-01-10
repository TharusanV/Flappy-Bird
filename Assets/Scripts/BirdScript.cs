using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapSpeed;
    public LogicScript logic;
    public bool birdAlive = true;
    public AudioSource hitSFX;
    public AudioSource tapSFX;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            //Vector2 refers to (X,Y) and .up means (0,1)
            tapSFX.Play();
            myRigidbody.velocity = Vector2.up * flapSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != 6 && collision.gameObject.tag != "MiddlePipe")
        {
            logic.gameOver();
            hitSFX.Play();
            birdAlive = false;
        }

    }
}
