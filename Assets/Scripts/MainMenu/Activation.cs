using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using FeTo.SOArchitecture;

public class Activation : MonoBehaviour
{
    [SerializeField] Button startButton;
    [SerializeField] FloatReference InteractableWaitTime;
    [SerializeField] GameObject gameOverPanel;

    public void ShowGameOverMenu() {
        startButton.interactable = false;
        gameOverPanel.SetActive(true);
        StartCoroutine(EnableStartButton());
    }

    private IEnumerator EnableStartButton() {
        yield return new WaitForSeconds(InteractableWaitTime);
        startButton.interactable = true;
    }

}
