using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCount : MonoBehaviour
{
    // Start is called before the first frame update
    private Text bulletCount;
    [Header("Values")]
    [Tooltip("Value to consider full")]
    public float fullValue = 1f;
    [Tooltip("Value to consider empty")]
    public float emptyValue = 0f;
    [Tooltip("Sharpness for the color change")]
    public float colorChangeSharpness = 5f;
    float m_PreviousValue;
    public void Initialize(float fullValueRatio, float emptyValueRatio)
    {
        fullValue = fullValueRatio;
        emptyValue = emptyValueRatio;
        m_PreviousValue = fullValueRatio;
        bulletCount = this.GetComponent<Text>();
    }

    // Update is called once per frame
    public void UpdateVisual(float currentRatio)
    {
        if (currentRatio == fullValue && currentRatio != m_PreviousValue)
        {
            int amount = (int)fullValue * 16 / 1;
            bulletCount.text = "" + amount;
        }
        else if (currentRatio < emptyValue)
        {
            int amount = (int)fullValue * 16 / 1;
            int currentamount = (int)(currentRatio * 16);
            bulletCount.text = currentamount + "/" + amount;
        }
        else
        {
            int amount = (int)fullValue * 16 / 1;
            int currentamount = (int)(currentRatio * 16);
            bulletCount.text = currentamount + "/" + amount;
        }

        m_PreviousValue = currentRatio;
    }
}
