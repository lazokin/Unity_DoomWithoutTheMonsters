using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {

    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingsPopup settingsPopup;

    void Start() {
        settingsPopup.Close();
    }

	void Update () {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
	}

    public void OnOpenSettings() {
        settingsPopup.Open();
    }
}
