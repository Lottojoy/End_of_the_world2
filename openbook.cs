using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openbook : MonoBehaviour
{
    public GameObject Panel;

    private void Openpanel()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;

            Panel.SetActive(!isActive);
        }
    }
}
