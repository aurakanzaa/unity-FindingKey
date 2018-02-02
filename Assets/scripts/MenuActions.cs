using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace scripts
{
    public class MenuActions : MonoBehaviour
    {

        public static int restart = 3;

        public void MENU_ACTION_GotoPage()
        {

            Application.LoadLevel(restart);

        }


    }
}
