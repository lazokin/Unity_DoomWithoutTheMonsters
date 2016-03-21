using UnityEngine;
using System.Collections;
using System;

public class ReactiveTarget : MonoBehaviour {

	void Start () {
	
	}
	
	void Update () {
	
	}

    public void ReactToHit() {
        StartCoroutine(Die());
    }

    private IEnumerator Die() {
        this.transform.Rotate(-75, 0, 0);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
    }
}
