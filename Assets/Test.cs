using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100; //体力
    private int power = 25; //攻撃力
    //応用課題
    private int mp = 53;

    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        //残りのhpを減らす
        this.hp -= damage;
    }
    //応用課題
    public void Magic(int magic)
    {
        if (mp >= 5)
        {
            Debug.Log(magic + "魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
        for (int mp = 0;  mp < 10; mp++)
        {
            Debug.Log(mp);
        }

        this.mp -= mp;
    }
}

public class Test : MonoBehaviour
{
    int Add(int a, int b, int c)
    {
        int d = a + b + c;

        return d;
    }

    void Hello()
    {
        Debug.Log("Goodbye,UnityChan");
    }

    // Start is called before the first frame update
    void Start()
    {
        //課題
        //各要素を順番に表示
        int[] array = new int[5];

        array[0] = 30;
        array[1] = 20;
        array[2] = 40;
        array[3] = 10;
        array[4] = 50;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        //各要素を逆順に表示
        array[0] = 30;
        array[1] = 20;
        array[2] = 40;
        array[3] = 10;
        array[4] = 50;

        for (int i = 0; i > 5; i++)
        {
            Debug.Log(array[i]);
        }

        //bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //攻撃用の関数を呼び出す
        lastboss.Attack();
        //防御用の関数を呼び出す
        lastboss.Defence(3);
        //応用課題
        lastboss.Magic(5);


        int red = Add(3, 6, 3);

        Debug.Log(red);

        Hello();

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100, };
        for (int i = 0; i < points.Length; i++){

            if( points[i] >= 50)
            {
                Debug.Log(points[i]);
            }
        }

        //numを1で初期化する
        int num = 1;
        //三項演算子によって代入する値を条件によって変更する
        int val = (num == 1) ? -100 : 100;
        //valを表示する
        Debug.Log(val);


        //moneyを100で初期化する
        int money = 100;
        if (money <= 50)
        {
            //moneyが50以下だった場合の処理
            Debug.Log("武器を売る");
        }
        else if( money >= 200)
        {
            //moneyが200以上だった場合の処理
            Debug.Log("武器を買う");
        }
        else
        {
            //それ以外の場合の処理
            Debug.Log("ポーションを買う");
        }

        //変数の宣言
        int score;
       //変数の代入
       score = 150;
        //コンソールに変数の中身を表示
        Debug.Log(score);

        //変数の計算
        int a = 3;
        int b = 4;

        int c = a + b;

        Debug.Log (c);


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
