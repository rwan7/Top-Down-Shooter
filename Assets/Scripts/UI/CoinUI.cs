using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinUI : MonoBehaviour
{
	public TextMeshProUGUI coinText;
	public ScriptableInteger coinScriptable;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinScriptable.value.ToString();
    }
}
