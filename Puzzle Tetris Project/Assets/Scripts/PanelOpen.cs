using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpen : MonoBehaviour
{

    public GameObject TutorialPanel;

    public void OpenPanel()
    {
        if(TutorialPanel != null)
        {
            TutorialPanel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (TutorialPanel != null)
        {
            TutorialPanel.SetActive(false);
        }
    }
}
