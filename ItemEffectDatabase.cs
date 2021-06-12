using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEffect
{
    public string itemName; // �������� �̸�. (Ű��)
    [Tooltip("HP�� �����մϴ�")]
    public string[] part; // ����.
    public int[] num; // ��ġ.
}

public class ItemEffectDatabase : MonoBehaviour
{

    [SerializeField]
    private ItemEffect[] itemEffects;

    //�ʿ��� ������Ʈ
    [SerializeField]
    private HpController thePlayerStatus;

    private const string HP = "HP";

    public void UseItem(Item _item)
    {

        if (_item.itemType == Item.ItemType.Used)
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
                                thePlayerStatus.IncreaseHP(itemEffects[x].num[y]);
                                break;
                        }
                        Debug.Log(_item.itemName + " �� ����߽��ϴ�");

                    }
                    return;
                }


            }
            Debug.Log("ItemEffectDatabase�� ��ġ�ϴ� itemName �����ϴ�");
        }

    }
}
