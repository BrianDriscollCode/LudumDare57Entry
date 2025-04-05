using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;


public class TilemapLayerManager : MonoBehaviour
{
    public TilemapFader[] layers;
    private int currentIndex = 0;

    private void Start()
    {
        TilemapFader Layer1 = GameObject.Find("Layer1")?.GetComponent<TilemapFader>();
        TilemapFader Layer2 = GameObject.Find("Layer2")?.GetComponent<TilemapFader>();
        TilemapFader Layer3 = GameObject.Find("Layer3")?.GetComponent<TilemapFader>();
        TilemapFader Layer4 = GameObject.Find("Layer4")?.GetComponent<TilemapFader>();

        layers = new TilemapFader[] { Layer1, Layer2, Layer3, Layer4 };

        // Set color of Layer0 (Layer1 in GameObject name)
        if (Layer1 != null)
            Layer1.GetComponent<Tilemap>().color = Color.white; // or any color you want

        // Set color of Layer1 (Layer2 in GameObject name)
        if (Layer2 != null)
            Layer2.GetComponent<Tilemap>().color = Color.green;

        HideAllExcept(currentIndex);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SwitchToLayer(0);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            SwitchToLayer(1);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            SwitchToLayer(2);
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            SwitchToLayer(3);
    }

    void SwitchToLayer(int index)
    {
        Debug.Log("passedIndex: " + index + "|| currentIndex: " + currentIndex);

        if (index == currentIndex || layers[index] == null)
        {
            return;
        }

        currentIndex = index;

        if (index < 0 || index >= layers.Length) return;

        for (int i = 0; i < layers.Length; i++)
        {
            if (i == index)
            {
                layers[i].FadeIn();
            }
            else
            {
                layers[i]?.FadeOut();
            }
        }
    }
    void HideAllExcept(int index)
    {
        for (int i = 0; i < layers.Length; i++)
        {
            if (layers[i] == null) continue;

            if (i == index)
            {
                layers[i].gameObject.SetActive(true); // or use your FadeIn() if needed
            }
            else
            {
                layers[i].gameObject.SetActive(false); // or FadeOut() if you're animating
            }
        }
    }


}

