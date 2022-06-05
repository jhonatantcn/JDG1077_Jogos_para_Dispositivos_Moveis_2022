using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
	public Card card;

	public Text nameText;
	public Text descriptionText;

	public Image ArtCharacterImage;

	public Text manaText;
	public Text attackText;
	public Text healthText;

	// Use this for initialization
	void Start()
	{
		nameText.text = card.cardName;
		descriptionText.text = card.description;

		ArtCharacterImage.sprite = card.artCharacter;

		manaText.text = card.manaCost.ToString();
		attackText.text = card.attack.ToString();
		healthText.text = card.health.ToString();

		card.InitialValues();
	}

	public void DecreaseHealth()
	{
		card.health--;
		healthText.text = card.health.ToString();
	}

	public void EndGame()
    {
		card.ResetValues();
		healthText.text = card.health.ToString();
    }

}
