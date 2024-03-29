using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StatBarCanvas : MonoBehaviour
{
    public StatPoints statPoints;
    public Image meterImage;
    public TextMeshProUGUI hpText;

    void Update()
    {
        meterImage.fillAmount = (float)statPoints.currentValue / statPoints.maxValue;
        hpText.text = statPoints.currentValue.ToString() + "/" + statPoints.maxValue;
    }
}
