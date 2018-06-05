using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeParameters : MonoBehaviour {
    public Slider family;
    public Slider friend;
    public Slider girl;
    public Slider classmatess;
    public int family_change;
    public int friend_change;
    public int girl_change;
    public int classmatess_change;
    // Use this for initialization
    void Start () {
		
	}
	public void changeParam()
    {
        family.value += family_change;
        friend.value += friend_change;
        girl.value += family_change;
        classmatess.value += classmatess_change;
    }

    void OnMouseEnter()
    {
        friend.value += 1;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
