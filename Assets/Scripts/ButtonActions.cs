using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    public GameObject purchaseMenu;

    void Start()
    {
        GameObject objectParent = gameObject.transform.parent.gameObject;
        purchaseMenu = objectParent.transform.GetChild(2).gameObject;
    }

    public void purchaseButtonPressed()
    {
        purchaseMenu.SetActive(true);
    }

    public void planterPurchased()
    {

    }

    public void closePurchaseMenu()
    {
        purchaseMenu.SetActive(false);
    }
}
