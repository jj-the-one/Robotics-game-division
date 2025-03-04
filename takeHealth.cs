using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class takeHealth : MonoBehaviour
{
    // Start is called before the first frame update
    Health a;
    [SerializeField] private Transform b;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if()
        //     b.Translate(10*Time.deltaTime, 0, 0);
        // else
        //     b.Translate(-10*Time.deltaTime, 0, 0);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        a = collision.gameObject.GetComponent<Health>();
        if(a != null)
            a.takeDamage(10);
        Destroy(gameObject);
    }
}
