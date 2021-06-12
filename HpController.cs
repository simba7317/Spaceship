using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpController : MonoBehaviour
{
    // ü��
    [SerializeField]
    private int hp;
    private int currentHp;

    // ü�� �پ��� �ӵ�
    [SerializeField]
    private int hpDecreaseTime;
    private int currentHpDecreaseTime;


    // �ʿ��� �̹���
    [SerializeField]
    private Image[] images_Gauge;

    private const int HP = 0;

    // Use this for initialization
    void Start()
    {
        currentHp = hp;
    }

    // Update is called once per frame
    void Update()
    {
        HpDown();
        GaugeUpdate();
    }

    public void HpDown()
    {
        if (currentHp > 0)
        {
            if (currentHpDecreaseTime <= hpDecreaseTime)
                currentHpDecreaseTime++;
            else
            {
                currentHp--;
                currentHpDecreaseTime = 0;
            }
        }
        else
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void GaugeUpdate()
    {
        images_Gauge[HP].fillAmount = (float)currentHp / hp;
    }

    public void IncreaseHP(int _count)
    {
        if (currentHp + _count < hp)
            currentHp += _count;
        else
            currentHp = hp;
    }

    public void DecreaseHP(int _count)
    {
        currentHp -= _count;
    }
}