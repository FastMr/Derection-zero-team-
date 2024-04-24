using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOpenScript : MonoBehaviour
{
    private GameObject InventoryRef;

    public bool InventoryOpened = false;

    void Start()
    {
        InventoryRef = GameObject.Find("Inventory");
        InventoryRef.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (!InventoryOpened)
            {
                OpenInventory();
            }
            else
            {
                CloseInventory();
            }
        }
    }

    public void OpenInventory()
    {
        InventoryRef.SetActive(true);
        InventoryOpened = true;
    }

    public void CloseInventory()
    {
        InventoryRef.SetActive(false);
        InventoryOpened = false;
    }
}