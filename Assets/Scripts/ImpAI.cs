using UnityEngine;

public class ImpAI : MonoBehaviour
{
    public enum AIType
    {
        Observer,
        Walker
    }

    public AIType currentType;
    public ImpWalker impWalker;
    public ImpLook impLook;

    private void Update()
    {
        switch (currentType)
        {
            case AIType.Observer:
                impWalker.enabled = false;
                impLook.enabled = true;
                break;
            case AIType.Walker:
                impWalker.enabled = true;
                impLook.enabled = false;
                break;
        }
    }
}
