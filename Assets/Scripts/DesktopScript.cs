using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesktopScript : MonoBehaviour
{
    public GameObject GMO_Screen;
    public GameObject Desktop_View;

    public void openDesktop()
    {
        Desktop_View.SetActive(true);
    }
    public void closeDesktop()
    {
        Desktop_View.SetActive(false);
    }
    public void purchaseNonGMO()
    {

    }
    public void readMoreGMO()
    {
        GMO_Screen.SetActive(true);
    }
    public void purchaseGMO()
    {

    }
    public void goBackScreen()
    {
        GMO_Screen.SetActive(false);
    }
}
