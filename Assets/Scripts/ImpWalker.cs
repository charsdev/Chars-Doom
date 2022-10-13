using UnityEngine;

public class ImpWalker : MonoBehaviour
{
    public Transform target;
    public float speed;
    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        var direction = target.position - transform.position;

        if (Vector3.Distance(target.position, transform.position) > 2)
        {
            transform.position += direction.normalized * speed * Time.deltaTime;
            anim.SetTrigger("Walk");
        }
        else
        {
            anim.SetTrigger("Idle");
        }
    }
}
