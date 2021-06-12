using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
    [SerializeField]
    private Text Doortxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Doortxt.gameObject.SetActive(true);
            Doortxt.text = " OPEN DOOR/CLOSE " + "<color=yellow>" + "(Q)" + "</color>";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Doortxt.gameObject.SetActive(false);
        }
    }
}
