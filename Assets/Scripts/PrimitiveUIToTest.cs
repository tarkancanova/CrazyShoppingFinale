using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PrimitiveUIToTest : MonoBehaviour
{
    [SerializeField] private TMP_Text _moneyOwnedText;
    [SerializeField] private PlayerData _playerData;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _moneyOwnedText.text = "Money: " + _playerData.Money;
    }
}
