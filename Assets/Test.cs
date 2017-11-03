using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 500;
    private int attack = 25;
    private int mp = 53;
    public void Attack()
    {
        Debug.Log(this.attack + "のダメージを与えた!");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        this.hp -= damage;
    }
    public void Magic(int magp)
    {
        if (mp < magp)
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        else
        {
            mp -= magp;
            Debug.Log("魔法攻撃をした。残りMPは"+mp+"。");
        }
    }
}

public class Test : MonoBehaviour {
    void GoodBye()
    {
        Debug.Log("GoodBye UnityChan");
    }
    void HelloName(int num)
    {
        Debug.Log("Hello" + num + "Girls");
    }
   int Add(int a,int b,int c)
    {
        int d = a + b + c;

        return d;
    }
    
	// Use this for initialization
	void Start () {

        //Debug.Log("Hello,World");
        /*
        int score;
        score = 150;
        Debug.Log(score);
        */
        /*
        int a = 2, b = 3;
        int c = a + b;
        Debug.Log(c);
        */
        /*
        int money = 150;
        if (money <= 50)
        {
            Debug.Log("武器を売る");
        }else if (money >= 200)
        {
            Debug.Log("武器を買う");
        }
        else
        {
            Debug.Log("ポーションを買う");
        }
        */
        /*
        int num = 1;
        int val = (num == 1) ? 100 : -100;
        Debug.Log(val);
        */
        /*
        int a = 3;
        if (a == 3)
        {
            int b = 5;
            Debug.Log(b);
        }
        */
        /*
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }
        */
        /*
        int sum = 0;
        for(int i = 0; i <= 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);
        */
        /*
        int[] points = { 10, 30, 20, 50, 15, 80, 72 };
        for(int i = 0; i < points.Length; i++)
        {
            if (points[i] >= 50)
            {
                Debug.Log(points[i]);
            }
        }
        */
        //GoodBye();
        //HelloName(3);
        /*
        int a = 3, b = 5, c = 2;

       int num= Add(a, b, c);
        Debug.Log(num);
      */
        int[] array = { 2, 6, 17, 35, 9 };
        for(int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for(int i = array.Length-1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        Boss lastboss = new Boss();
        //lastboss.Attack();
        //lastboss.Defence(3);
        for (int i = 0; i <11; i++)
        {
            lastboss.Magic(5);
        }
        //Boss midboss = new Boss();
        //midboss.Attack();
        //midboss.Defence(5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
