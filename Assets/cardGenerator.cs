using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cardGenerator : MonoBehaviour {
    public List<GameObject> cards = new List<GameObject>();
    // Use this for initialization
    void Start () {
	}
	
    public void getNewCard()
    {
        int nextCard = Random.Range(0, cards.Count - 1);
        cards[nextCard].SetActive(true);
    }
	// Update is called once per frame
	void Update () {

    }
}
