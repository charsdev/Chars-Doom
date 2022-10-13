using UnityEngine;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
