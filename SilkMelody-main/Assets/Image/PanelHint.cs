using UnityEngine;

public class PanelHint : MonoBehaviour
{
    public GameObject panel;

    // Mở panel
    public void OpenPanel()
    {
        panel.SetActive(true);
    }

    // Tắt panel
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}