using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceCollider2 : MonoBehaviour
{
    [SerializeField]
    private BreathController Breathe;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Breathe.IncreaseBREATH(1);
        }

    }

}
