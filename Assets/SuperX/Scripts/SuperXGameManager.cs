using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperXGameManager : MonoBehaviour
{
    int[] Super7Member = { 4, 5, 6, 7 };
    int[] Super7Roulette = { 0, 1, 2, 3 };
    int[] Super8Member = { 4, 5, 6, 7, 8 };
    int[] Super8Roulette = { 0, 1, 2, 3, 4 };
    int[] Super9Member = { 5, 6, 7, 8, 9 };
    int[] Super9Roulette = { 0, 1, 2, 3, 4 };
    int[] Super10Member = { 0, 1, 2, 3, 4 };
    int[] Super10Roulette = { 6, 7, 8, 9, 10 };

    public static SuperXGameManager Instance;
    public List<ButtonInGrid> buttonInGrids = new List<ButtonInGrid>();

    [Header("Testing Parameter")]
    public int textInitX = 7;
    private void Awake()
    {
        if (!Instance) Instance = this;
        else if (Instance != this) Destroy(gameObject);
    }


    private void Start()
    {
        InitiateGrid(textInitX);
    }

    void InitiateGrid(int x)
    {
        int[] gridMember;
        int[] rouletteMember;
        switch (x)
        {
            default:
            case 7:
                gridMember = Super7Member;
                rouletteMember = Super7Member;
                break;
            case 8:
                gridMember = Super8Member;
                rouletteMember = Super8Member;
                break;
            case 9:
                gridMember = Super9Member;
                rouletteMember = Super9Member;
                break;
            case 10:
                gridMember = Super10Member;
                rouletteMember = Super10Member;
                break;
        }
        List<int> memberForInit = new List<int>();
        for (int i = 0; i < 40 / gridMember.Length; i++)
        {
            for (int j = 0; j < gridMember.Length; j++)
            {
                memberForInit.Add(gridMember[j]);
            }
        }

        for (int i = 0; i < buttonInGrids.Count; i++)
        {
            int index =  Random.Range(0, memberForInit.Count);
            buttonInGrids[i].initiateButton(memberForInit[index]);
            memberForInit.RemoveAt(index);
        }
    }
}
