using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;    //魔力

    // 攻撃用の関数
    public void Attack()
    {
            UnityEngine.Debug.Log( this.power + "のダメージを与えた" );
    }

    // 防御用の関数
    public void Defence(int damage)
    {
            UnityEngine.Debug.Log( damage+"のダメージを受けた" );
            // 残りhpを減らす
            this.hp -= damage;
    }

    // 魔法用の関数
    public void Magic(int num)
    {
            if(mp <= 5)
            {
            UnityEngine.Debug.Log( "MPが足りないため、魔法が使えない。");
            }
            else
            {
            // 残りmpを減らす
            this.mp -= num;
            UnityEngine.Debug.Log( "魔法攻撃をした。残りMPは"+ mp);
            }
}        

}

public class ScriptTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss ();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();

        // 防御用の関数を呼び出す
        lastboss.Defence(3);

        // 魔法用の関数を呼び出す
        lastboss.Magic(10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
