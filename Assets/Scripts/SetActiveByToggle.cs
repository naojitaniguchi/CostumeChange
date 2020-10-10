using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActiveByToggle : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Toggle>().isOn = target.activeSelf;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleValueChanged(bool value)
    {
        target.SetActive(value);
    }
}
