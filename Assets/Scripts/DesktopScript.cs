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
}
