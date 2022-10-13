using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    private int damage = 10;

    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject);

        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<HealthEnemy>().TakeDamage(damage);
        }
        
    }
}
