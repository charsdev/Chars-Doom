using System.Collections;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public int health;
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }    
    }

    public void TakeDamage(int damage)
    {
        StartCoroutine(Blink());
        health -= damage;
    }

    private IEnumerator Blink() 
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.25f);
        spriteRenderer.color = Color.white;
    }
}
