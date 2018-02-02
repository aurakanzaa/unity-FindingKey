using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour {

    public GameObject Panel;
   // public Button bsetting;

	// Use this for initialization
	void Start () {
     //   Button btn = bsetting.GetComponent<Button>();
        //btn.onClick.AddListener(TaskOnClick);
        Panel.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Input.GetKeyDown(KeyCode.Escape);
        

    }

    public void show()
    {
        Panel.SetActive(true);
    }
}
