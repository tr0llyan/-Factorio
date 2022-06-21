using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class isInputEmpty : MonoBehaviour
{
    [SerializeField] public InputField inputField;

    [SerializeField] public GameObject calculatedPanel;

    public  void OnBtnClick()
    {
        if (string.IsNullOrEmpty(inputField.text) 
            || inputField.text == "0" 
            || inputField.text == "00") calculatedPanel.SetActive(false);

        if (!calculatedPanel.activeSelf) inputField.text = null;
    }
}
