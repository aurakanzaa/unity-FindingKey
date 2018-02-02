using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menu : MonoBehaviour
{

    public void MENU_ACTION_GotoPage( string candy)
    {
        Application.LoadLevel(candy);
    }
}