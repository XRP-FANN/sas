using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class priem : MonoBehaviour
{
    int ch = 0;
    [SerializeField] GameObject tep;
    void Update()
    {
        if (ch > 0 )
        {
            tep.SetActive(true);

            ch += -1;
        }
        if (ch < 1)
        {
            tep.SetActive(false);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ob")
        {
            Destroy(other.gameObject);
            ch += 1;

        }

    }

}
