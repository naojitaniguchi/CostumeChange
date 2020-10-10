using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveSelect : MonoBehaviour
{
    public GameObject[] selectTarget;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPushed()
    {
        for ( int i = 0; i < selectTarget.Length; i ++)
        {
            if ( selectTarget[i].name == target.name)
            {
                target.SetActive(true);
            }
            else
            {
                selectTarget[i].SetActive(false);
            }
        }
    }
}
