using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

using UnityEngine;

using UnityEngine;

public class DialogRunner : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    private int currentPanelIndex = -1;
    private bool canRunDialog = false;

    private void Start()
    {
        //SetAllPanelsInactive();
    }

    private void Update()
    {
        if (canRunDialog && Input.GetKeyDown(KeyCode.Space))
        {
            ShowNextPanel();
        }
    }

    public void StartDialog()
    {
        canRunDialog = true;
        currentPanelIndex = -1;
        ShowNextPanel();
    }

    private void ShowNextPanel()
    {
        SetAllPanelsInactive();

        currentPanelIndex++;
        if (currentPanelIndex < panels.Length)
        {
            panels[currentPanelIndex].SetActive(true);
        }
        else
        {
            canRunDialog = false; // end of dialog
        }
    }

    private void SetAllPanelsInactive()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }
    }
}


