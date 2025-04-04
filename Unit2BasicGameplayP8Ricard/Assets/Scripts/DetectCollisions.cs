using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public int playerHealth = 3;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (playerHealth > 0)
            {
                HealthDecrementer();
            }
            else
            {
                Destroy(gameObject);
                Debug.Log("Game Over!!!");
            }
        }
    }

    void HealthDecrementer()
    {
        playerHealth = playerHealth - 1;
        Debug.Log("Lol");
        Debug.Log("Health = " + playerHealth);
    }
}
