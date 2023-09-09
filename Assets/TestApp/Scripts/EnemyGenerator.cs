using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //�G�v���n�u
    public GameObject enemyPrefab;
    //�G�������ԊԊu
    private float interval;
    //�o�ߎ���
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //���ԊԊu�����肷��
        interval = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //���Ԍv��
        time += Time.deltaTime;

        //�o�ߎ��Ԃ��������ԂɂȂ����Ƃ�(�������Ԃ��傫���Ȃ����Ƃ�)
        if (time > interval)
        {
            //enemy���C���X�^���X������(��������)
            GameObject enemy = Instantiate(enemyPrefab);
            //���������G�̍��W�����肷��(����X=0,Y=10,Z=20�̈ʒu�ɏo��)
            enemy.transform.position = new Vector3(Random.Range(-10, 11),1, Random.Range(-10, 11));
            //�o�ߎ��Ԃ����������čēx���Ԍv�����n�߂�
            time = 0f;
        }
    }
}