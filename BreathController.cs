using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BreathController : MonoBehaviour
{
    // ��
    [SerializeField]
    private int breath;
    private int currentBreath;

    // �� �پ��� �ӵ�
    [SerializeField]
    private int breathDecreaseTime;
    private int currentBreathDecreaseTime;

    // �� �̹���
    [SerializeField]
    private Image[] images_Gauge;

    private const int BREATH = 0;

    // Use this for initialization
    void Start()
    {
        currentBreath = breath;
    }

    // Update is called once per frame
    void Update()
    {
        Breath();
        GaugeUpdate();
    }

    public void Breath()
    {
        if (currentBreath > 0)
        {
            if (currentBreathDecreaseTime <= breathDecreaseTime)
                currentBreathDecreaseTime++;
            else
            {
                currentBreath--;
                currentBreathDecreaseTime = 0;
            }
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void GaugeUpdate()
    {
        images_Gauge[BREATH].fillAmount = (float)currentBreath / breath;
    }

    public void IncreaseBREATH(int _count)
    {
        if (currentBreath + _count < breath)
            currentBreath += _count;
        else
            currentBreath = breath;
    }

    public void DecreaseBREATH(int _count)
    {
        currentBreath -= _count;

    }
}
