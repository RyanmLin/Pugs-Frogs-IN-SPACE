using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class KnockoutUI : MonoBehaviour
{

    [SerializeField] Text knockOutPercent;
    // Start is called before the first frame update

    [SerializeField] Player player;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        knockOutPercent.text = player.knoknockOutPercent.ToString() + "%";
    }
}
