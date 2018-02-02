using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour {

    public static int stage = 3;
   // public int lv=stage;
    public void MENU_ACTION_GotoPage()
    {
        Debug.Log("asdsadsadasd");
        Application.LoadLevel(stage+1);
        stage += 1;
        if (stage == 3)
        {
            Application.LoadLevel(stage + 1);
            stage += 1;
        }
    }

    public void Menu_Awal(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
