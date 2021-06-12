using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEffect
{
    public string itemName; // �������� �̸� (Ű��)
    [Tooltip("HP,FIX�� �����մϴ�")]
    public string[] part; // ����
    public int[] num; // ��ġ
}

public class ItemEffectDatabase : MonoBehaviour
{

    [SerializeField]
    private ItemEffect[] itemEffects;

    //�ʿ��� ������Ʈ
    [SerializeField]
    private HpController thePlayerHP;
    [SerializeField]
    private FixController theFix;
    [SerializeField]
    private SlotToolTip theSlotToolTip;

    private const string HP = "HP", FIX = "FIX";

    public void ShowToolTop(Item _item, Vector3 _pos)
    {
        theSlotToolTip.ShowToolTip(_item, _pos);
    }

    public void HideToolTip()
    {
        theSlotToolTip.HideToolTip();
    }

    public void UseItem(Item _item)
    {
            for (int x = 0; x < itemEffects.Length; x++)
            {

                if (itemEffects[x].itemName == _item.itemName)
                {

                    for (int y = 0; y < itemEffects[x].part.Length; y++)
                    {

                        switch (itemEffects[x].part[y])
                        {
                            case HP:
                                thePlayerHP.IncreaseHP(itemEffects[x].num[y]);
                                break;
                            case FIX:
                                theFix.IncreaseFIX(itemEffects[x].num[y]);
                                break;
                            default:
                                Debug.Log("HP, FIX�� �����մϴ�");
                                break;
                        }
                        Debug.Log(_item.itemName + "��/�� ����߽��ϴ�");

                    }
                    return;
                }


            }

            Debug.Log("ItemEffectDatabase�� ��ġ�ϴ� itemName �����ϴ�");
    }
}
