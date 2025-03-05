using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // starting health for player
  public int startingHealth;

    //players current health
    int currentHealth;

    void Awake()
    {
        //make current health equal to starting health
        currentHealth = startingHealth;
    }

    public void ChangeHealth(int changeAmount)
    {
        //taking the current health and changing it 
        currentHealth = currentHealth + changeAmount;

        // keep our current health between 0 and starting
        currentHealth = Mathf.Clamp(currentHealth, 0, startingHealth);

        // if our health goes to 0, you die
        if (currentHealth == 0)
        {
            // call kill to kill player
            Kill();
        }
    }


    // Start is called before the first frame update
    public void Kill()
    {
        
        Destroy(gameObject);
    }

}
