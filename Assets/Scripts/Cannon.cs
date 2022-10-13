using UnityEngine;

class Cannon : MonoBehaviour
{
    public GameObject prefab;
    public Transform firepoint;
    public AudioSource audioSource;
    public AudioClip clip;
    public int ammo = 25;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ammo <= 1)
            {
                ammo = 25;
            }
            else
            {
                ammo = Mathf.Clamp(--ammo, 0, 25);
                var bullet = Instantiate(prefab, firepoint.position, firepoint.rotation).GetComponent<Bullet>();
                bullet.direction = firepoint.forward;
                audioSource.PlayOneShot(clip);
                HUDManager.instance.SetAmmoText(ammo.ToString());
            }
        }
    }
}
