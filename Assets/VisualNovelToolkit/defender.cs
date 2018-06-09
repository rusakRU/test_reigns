using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class defender : MonoBehaviour {

    public GameObject guiTextLink; //Ссылка на объект, если скрипт не на нем
    public TextButton tb;
    public void changeColor()
    {
        guiTextLink.GetComponent<Text>().color = new Color(0, 0, 1, 1);
        Debug.Log("1111");
    }
}
