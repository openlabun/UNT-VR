using UnityEngine;

public class ToggleInfoPanel : MonoBehaviour
{
    public GameObject panel;  // Asigna aquí el Panel desde el editor

    public void TogglePanel()
    {
        if (panel != null)
        {
            panel.SetActive(!panel.activeSelf);
        }
    }
}
