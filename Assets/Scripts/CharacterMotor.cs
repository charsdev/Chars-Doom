using UnityEngine;

public class CharacterMotor : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody characterRigidBody;

    private void Start()
    {
        characterRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        characterRigidBody.position += transform.TransformDirection(input) * speed * Time.deltaTime;
    }
}
