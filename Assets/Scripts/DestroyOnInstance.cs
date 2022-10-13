using UnityEngine;

public class DestroyOnInstance : MonoBehaviour
{
    public float lifeTime;

    private void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
