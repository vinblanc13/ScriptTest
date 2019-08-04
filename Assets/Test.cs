using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        int exh = 5;
        this.mp -= exh;
        if (mp >= 0)
        {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        //順番
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        //逆順
        for (int x = array.Length; x > 0; x--)
        {
            Debug.Log(array[x - 1]);
        }

        //Boss
        Boss boss = new Boss();
        for (int num = 1; num <= 11; num++)
        {
            boss.Magic();
        }
    }
	
	// Update is called once per frame
	void Update()
    {
		
	}
}
