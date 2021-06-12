using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FixController : MonoBehaviour
{
    // 완성도
    [SerializeField]
    private int fix;
    private int currentFix;

    // 필요한 이미지
    [SerializeField]
    private Image[] images_Gauge;

    private const int FIX = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentFix = fix;
        ZeroFIX();
    }

    // Update is called once per frame
    void Update()
    {
        GaugeUpdate();
    }

    private void GaugeUpdate()
    {
        images_Gauge[FIX].fillAmount = (float)currentFix / fix;
    }

    public void IncreaseFIX(int _count)
    {
        if (currentFix + _count < fix)
            currentFix += _count;
        else
            currentFix = fix;
    }

    public void ZeroFIX()
    {
        currentFix = 0;
    }

}
