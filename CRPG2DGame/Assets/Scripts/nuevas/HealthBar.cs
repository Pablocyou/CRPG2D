using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public StatPoints hitPoints;
    public Image meterImage;
    public TextMeshProUGUI hpText;

    void Update()
    {
        meterImage.fillAmount = (float) hitPoints.currentValue / hitPoints.maxValue;
        hpText.text = hitPoints.currentValue.ToString() + "/" + hitPoints.maxValue;
    }
}
