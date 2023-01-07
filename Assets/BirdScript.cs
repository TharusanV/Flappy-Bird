using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapSpeed;
    public MetaScript meta;
    public bool birdAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        meta = GameObject.FindGameObjectWithTag("MetaLogic").GetComponent<MetaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && birdAlive)
        {
            //Vector2 refers to (X,Y) and .up means (0,1) 
            myRigidbody.velocity = Vector2.up * flapSpeed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        meta.gameOver();
        birdAlive = false;
    }
}
