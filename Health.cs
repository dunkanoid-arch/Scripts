using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currenthealth = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        if (currenthealth > 0)
        {
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
    }

    // Update is called once per frame
    
}
