using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject {

	public string cardName;
	public string description;

	public Sprite artCharacter;

	public int manaCost;
	public int attack;
	public int health;



	private int initialManaCost;
	private int initialAttack;
	private int initialHealth;

	public void InitialValues()
    {
		initialManaCost = manaCost;
		initialAttack = attack;
		initialHealth = health;
	}

	public void ResetValues()
	{
		manaCost = initialManaCost;
		attack = initialAttack;
		health = initialHealth;
	}
}
