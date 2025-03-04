using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    // public TextMeshProUGUI healthText;
    // public Image Healthbar;
    
    public float maxHealth = 100f;
    public float currentHealth;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

    }
    public void takeDamage(float damage){
        currentHealth -= damage;

        if(currentHealth <= 0){
            currentHealth = 0;
            GameObject.Destroy(gameObject);
        }

    }
    // Update is called once per frame
    void Update()
    {
        // healthText.text = currentHealth.ToString();
        // Healthbar.fillAmount = currentHealth/maxHealth;

    }
}
