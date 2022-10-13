using UnityEngine;

public class ImpLook : MonoBehaviour
{
    public Transform target;
    public float speed = 1.25f;

    private void Update()
    {
        var targetPos = new Vector3(target.position.x, transform.position.y, target.position.z);
        var direction = targetPos - transform.position;
        var finalRotation = Quaternion.LookRotation(direction.normalized);
        transform.rotation = finalRotation;
    }
}
