using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RETOPalabraCoin : MonoBehaviour
{

    public GameObject coinPrefab;  // Prefab de la moneda a instanciar
    public Vector2 startPosition = new Vector2(-3, 3); // Posición inicial de la palabra
    public float coinSpacing = 1.0f; // Espaciado entre monedas

    private int[,] loveMatrix = new int[,]
    {
        { 1, 0, 0, 0, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1 },
        { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
        { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
        { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 1, 1 },
        { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
        { 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0 },
        { 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 1, 1 },
    };

    void Start()
    {
        GenerateWord();
    }

    void GenerateWord()
    {
        for (int row = 0; row < loveMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < loveMatrix.GetLength(1); col++)
            {
                if (loveMatrix[row, col] == 1)
                {
                    Vector2 position = new Vector2(
                        startPosition.x + col * coinSpacing,
                        startPosition.y - row * coinSpacing
                    );

                    Instantiate(coinPrefab, position, Quaternion.identity);
                }
            }
        }
    }

}
