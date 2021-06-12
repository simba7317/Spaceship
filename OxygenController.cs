using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenController : MonoBehaviour
{

    // ���
    [SerializeField]
    private int oxygen;
    private int currentOxygen;
    private float temp;

    // ��Ұ� �پ��� �ӵ�
    [SerializeField]
    private int oxygenDecreaseTime;
    private int currentOxygenDecreaseTime;

    // �ʿ��� �̹���
    [SerializeField]
    private Image[] images_Gauge;

    private const int OXYGEN = 0;

    //HP ��Ʈ�ѷ� ��ũ��Ʈ �ҷ�����
    [SerializeField]
    private HpController thePlayerStatus;

    // Use this for initialization
    void Start()
    {
        
        currentOxygen = oxygen;
    }

    //public SpaceshipCollider SpaceshipC;

    // Update is called once per frame
    void Update()
    {
        Oxygen();
        GaugeUpdate();
    }

    public void Oxygen()
    {
        if (currentOxygen > 0)
        {
            if (currentOxygenDecreaseTime <= oxygenDecreaseTime)
                currentOxygenDecreaseTime++;
            else
            {
                currentOxygen--;
                currentOxygenDecreaseTime = 0;
            }
        }

        // ��� 0�� �� HP ��� �ϱ�
        if (currentOxygen <= 0)
        {
            temp += Time.deltaTime;
            if (temp >= 1)
            {
                thePlayerStatus.DecreaseHP(2);
                temp = 0;
            }
        }
    }

    public void GaugeUpdate()
    {
        images_Gauge[OXYGEN].fillAmount = (float)currentOxygen / oxygen;
    }

    public void IncreaseOxygen(int _count)
    {
        if (currentOxygen + _count < oxygen)
            currentOxygen += _count;
        else
            currentOxygen = oxygen;
    }

    public void DecreaseOxygen(int _count)
    {
        currentOxygen -= _count;
    }

}
