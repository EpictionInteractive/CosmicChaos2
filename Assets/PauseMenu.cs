using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Reference to the GameObject you want to enable/disable
    public GameObject objectToToggle;

    // Function to toggle the visibility of the object
    public void ToggleObject()
    {
        objectToToggle.SetActive(true);
    }

    // Function to handle going back to the main menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("menu");
    }

    // Method to disable the object at initialization
    private void Start()
    {
        objectToToggle.SetActive(false);
    }
}