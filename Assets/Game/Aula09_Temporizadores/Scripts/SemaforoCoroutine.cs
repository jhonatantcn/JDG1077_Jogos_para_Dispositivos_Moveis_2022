using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoCoroutine : MonoBehaviour
{
    [SerializeField] private SpriteRenderer CircleRed;
    [SerializeField] private SpriteRenderer CircleYellow;
    [SerializeField] private SpriteRenderer CircleGreen;

    [SerializeField] private Color OnRed;
    [SerializeField] private Color OnYellow;
    [SerializeField] private Color OnGreen;

    [SerializeField] private Color OffRed;
    [SerializeField] private Color OffYellow;
    [SerializeField] private Color OffGreen;

    void Start()
    {
        CircleRed.color = OffRed;
        CircleYellow.color = OffYellow;
        CircleGreen.color = OffGreen;

        StartCoroutine(MeuMetodo());
    }

    IEnumerator MeuMetodo()
    {
        while (true)
        {
            CircleGreen.color = OnGreen;
            CircleYellow.color = OffYellow;
            CircleRed.color = OffRed;
            yield return new WaitForSeconds(3f);

            CircleGreen.color = OffGreen;
            CircleYellow.color = OnYellow;
            CircleRed.color = OffRed;
            yield return new WaitForSeconds(2f);

            CircleGreen.color = OffGreen;
            CircleYellow.color = OffYellow;
            CircleRed.color = OnRed;
            yield return new WaitForSeconds(5f);
        }
    }
}
