using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoutFin : MonoBehaviour
{
    // for aplpha
    private Graphic graphic;
    private float alpha = 0.0f;
    private float dist = 0.01f;
    // fpr position
    private RectTransform rectTransform;
    private int aposy = -300;
    private int posDis = 3;

    // Use this for initialization
    void Start ()
    {
        graphic = GetComponent<Graphic>();
        rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update ()
    {
        // controlle alpha
        alpha += dist;
        graphic.color = new Color(0, 0, 0, alpha);
        if (alpha >= 1.0 || alpha <= 0.0)
        {
            dist *= -1.0f;
        }

        // controlle position
        aposy += posDis;
        rectTransform.anchoredPosition = new Vector2(0, aposy);
        if (aposy >= 300 || aposy <= -300)
        {
            posDis *= -1;
        }
    }
}
