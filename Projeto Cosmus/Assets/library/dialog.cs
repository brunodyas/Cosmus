using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog : MonoBehaviour
{

    
    string[] texto;
    Text UiText;

    // Use this for initialization
    void Start()
    {
		texto = Language.TextFile.text.Split('\n');
        UiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {

		if (cutscene.ato == 1) {

			UiText.text = texto [0];

		} else if (cutscene.ato == 2) {
		
			UiText.text = texto [1];
		
		} else if (cutscene.ato == 3) {

			UiText.text = texto [2];

		}

    }
}
