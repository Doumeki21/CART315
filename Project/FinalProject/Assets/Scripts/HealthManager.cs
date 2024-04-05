using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Image HealthFill;
    public float currentHealth = 100f;
    public int maxHealth = 100;

    public static HealthManager instance; //this is a singleton!
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // float displayHealth = currentHealth / 100f;
        // Debug.Log(displayHealth);
        HealthFill.fillAmount = currentHealth / 100f;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        gameManager.instance.GameOver();
    }
}
