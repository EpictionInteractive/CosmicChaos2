using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneToLoad; // Name of the scene to load
    public TMP_Text pressFText; // Reference to the UI Text component to display "Press F to start"

    private bool canLoadScene = false; // Flag to check if the player can load the scene

    void Start()
    {
        pressFText.gameObject.SetActive(false); // Deactivate the text at the start of the game
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressFText.gameObject.SetActive(true); // Display the "Press F to start" text
            canLoadScene = true; // Set flag to allow loading the scene
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressFText.gameObject.SetActive(false); // Hide the text when the player exits the collider
            canLoadScene = false; // Reset the flag
        }
    }

    void Update()
    {
        if (canLoadScene && Input.GetKeyDown(KeyCode.F))
        {
            LoadScene(); // Load the scene when F key is pressed and player is in the collider
        }
    }

    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad); // Load the specified scene
    }
}
