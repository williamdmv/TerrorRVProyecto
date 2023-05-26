using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TelportManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static TelportManager Instance;
    public GameObject Player;
    private GameObject lastTeleportPoint;
    private void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void DisableTeleportPoint(GameObject teleportPoint)
    {
        if (lastTeleportPoint != null)
        {
            lastTeleportPoint.SetActive(true);

        }

        teleportPoint.SetActive(false);
        lastTeleportPoint = teleportPoint;

#if UNITY_EDITOR
        Player.GetComponent<CardboardSimulator>().UpdatePlayerPositonSimulator();
#endif
    }
}
