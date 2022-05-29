using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInZoomOut : MonoBehaviour
{
	public Camera mainCamera; // Camera do jogo

	float touchesPrevPosDifference, touchesCurPosDifference, zoomModifier;
	// espaço entre toques anteriores, espaço entre toques atuais, modificador do tamanho da camera

	Vector2 firstTouchPrevPos, secondTouchPrevPos; // Posições anteriores de toque

	public float zoomModifierSpeed = 0.1f; // velocidade de zoom

	void Update()
	{
		if (Input.touchCount == 2) // Se existem dois toques na tela
		{
			Touch firstTouch = Input.GetTouch(0); // captura o primeiro toque
			Touch secondTouch = Input.GetTouch(1); // captura o segundo toque

			firstTouchPrevPos = firstTouch.position - firstTouch.deltaPosition;
			// Calcula a posição anterior do primeiro toque

			secondTouchPrevPos = secondTouch.position - secondTouch.deltaPosition;
			// Calcula a posição anterior do segundo toque

			touchesPrevPosDifference = (firstTouchPrevPos - secondTouchPrevPos).magnitude;
			// Calcula o espaço entre os toques anteriores

			touchesCurPosDifference = (firstTouch.position - secondTouch.position).magnitude;
			// Calcula o espaço entre os toques atuais

			zoomModifier = (firstTouch.deltaPosition - secondTouch.deltaPosition).magnitude * zoomModifierSpeed;
			// Recebe o deslocamento progressivo entre os toques atuais * a velocidade de zoom
			// Quanto maior a distância de deslocamento, maior será o modificador de zoom

			if (touchesPrevPosDifference > touchesCurPosDifference) // Se o espaço anterior era maior
				mainCamera.orthographicSize += zoomModifier; // Aumenta o tamanho da camera (ZoomIn)
			if (touchesPrevPosDifference < touchesCurPosDifference) // Se o espaço anterior era menor
				mainCamera.orthographicSize -= zoomModifier; // Diminui o tamanho da camera (ZoomOut)
		}

		mainCamera.orthographicSize = Mathf.Clamp(mainCamera.orthographicSize, 2f, 10f);
		// Mathf.Clamp dá limtes para o tamanho da camera, mínimo 2 e máximo 10 (zoom mínimo e zoom máximo)
	}
}