using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public MetaScript meta;
    // Start is called before the first frame update
    void Start()
    {
        meta = GameObject.FindGameObjectWithTag("MetaLogic").GetComponent<MetaScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            meta.addScore(1);
        }
    }
}
