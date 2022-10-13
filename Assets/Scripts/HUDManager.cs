using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public static HUDManager instance;
    public TextMeshProUGUI Ammo;


    private void Awake()
    {
        instance = this;
    }

    public void Update()
    {
    }

    public void SetAmmoText(string value)
    {
        if (Ammo.text != value)
        {
            Ammo.text = value;
        }
    }
}
