using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType { Attack, Defend }
public class Card : MonoBehaviour
{
    [SerializeField] private CardType _cardType;

    [SerializeField] private List<GameObject> _cardBehaviours;

    [SerializeField] private Material _attackMat;
    [SerializeField] private Material _defenseMat;

    private MeshRenderer _mr;

    private void Awake()
    {
        _mr = GetComponent<MeshRenderer>();

        _mr.sharedMaterial = _cardType == CardType.Attack ? _attackMat : _defenseMat;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Use();
        }
    }

    public void Use()
    {
        foreach (GameObject gameObject in _cardBehaviours)
        {
            CardBehaviour cb = (CardBehaviour)gameObject.GetComponent(typeof(CardBehaviour));
            cb.Use();
        }
    }

    public CardType GetCardType() { return _cardType; }
}
