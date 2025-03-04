using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageControler : MonoBehaviour
{

    [SerializeField] private Transform AttackCheck;
    public float damage;
    public bool attack = false;
    public Health health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("leftButton"))
            attack = !attack;

        if (attack)
            health.takeDamage(5 * Time.deltaTime);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && attack)
        {
            Health destructibleObject = collision.gameObject.GetComponent<Health>();
            if (destructibleObject != null)
            {
                destructibleObject.takeDamage(7);
                collision.gameObject.transform.position = collision.gameObject.transform.position + new Vector3(2 * 2 * Time.deltaTime, 1);
            }
        }
    }
}
