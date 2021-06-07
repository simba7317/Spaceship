using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{

public float totalOxygen;
public float currentOxygen;

public Text text_total;
public Text text_current;
public Image image_gauge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentOxygen -= Time.deltaTime;
        text_current.text = Mathf.RoundToInt(currentOxygen).ToString();
        image_gauge.fillAmount = currentOxygen / totalOxygen;
        text_total.text = totalOxygen.ToString();

    }
}
