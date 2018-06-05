using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTheFutureChanges : MonoBehaviour {
    public GameObject familyFutureCircle;
    public GameObject friendFutureCircle;
    public GameObject girlFutureCircle;
    public GameObject classFutureCircle;
    // Use this for initialization
    void Start () {
        familyFutureCircle.transform.localScale += new Vector3(2F, 2F, 2F);
    }

    public void familyFuture()
    {
        familyFutureCircle.transform.localScale += new Vector3(2F, 2F, 2F);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
