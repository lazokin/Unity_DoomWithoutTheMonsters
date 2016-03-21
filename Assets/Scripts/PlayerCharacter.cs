using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {

    private int _health;

	void Start () {
        _health = 5;
	}
	
	public void hurt (int damage) {
        _health -= damage;
        Debug.Log("Health: " + _health);
	}
}
