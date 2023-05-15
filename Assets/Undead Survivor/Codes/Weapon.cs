using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int id;
    public int prefabId;
    public float damage;
    public int count;
    public float speed;

    float timer;
    Player player;

    void Awake() {
        // Awake �Լ������� �÷��̾� �ʱ�ȭ�� ���� �Ŵ��� Ȱ������ ����
        player = GameManager.instance.player;
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.isLive)
            return;

        switch (id) {
            case 0:
                transform.Rotate(Vector3.back * speed * Time.deltaTime);
                break;
            default:
                timer += Time.deltaTime;

                if (timer > speed) {
                    timer = 0f;
                    Fire();
                }
                break;
        }
        // .. Test Code
        if (Input.GetButtonDown("Jump")) {
            LevelUp(10, 1);
        }
    }

    public void LevelUp(float damage, int count) {
        this.damage = damage;
        this.count += count;

        if (id == 0)
            Batch();

        player.BroadcastMessage("ApplyGear", SendMessageOptions.DontRequireReceiver);
    }

    public void Init(ItemData data) {
        // ��ũ��Ʈ�� ������Ʈ�� �������� ���ؼ� �ε����� �ƴ� ���������� ����

        //basic Set
        name = "Weapon " + data.itemId;
        transform.parent = player.transform;
        transform.localPosition = Vector3.zero;


        //Property Set
        id = data.itemId;
        damage = data.baseDamage;
        count = data.baseCount;

        for (int index = 0; index < GameManager.instance.pool.prefabs.Length; index++)
        {
            if ( data.projectile == GameManager.instance.pool.prefabs[index])
            {
                prefabId = index;
                break;
            }
        }


        switch (id) {
            case 0:
                speed = 150;
                Batch();
                break;
            default:
                speed = 0.4f;
                break;
        }

        // Hand Set
        Hand hand = player.hands[(int)data.itemType];
        hand.spriter.sprite = data.hand;
        hand.gameObject.SetActive(true);



        //BroadcastMessage : Ư�� �Լ� ȣ���� ��� �ڽĿ��� ����ϴ� �Լ�
        player.BroadcastMessage("ApplyGear", SendMessageOptions.DontRequireReceiver);
    }

    void Batch() {
        for (int index = 0; index < count; index++) {
            Transform bullet;
            
            if (index < transform.childCount) {
                bullet = transform.GetChild(index);
            } else {
                bullet = GameManager.instance.pool.Get(prefabId).transform;
                bullet.parent = transform;
            }

            bullet.localPosition = Vector3.zero;
            bullet.localRotation = Quaternion.identity;

            Vector3 rotVec = Vector3.forward * 360 * index / count;
            bullet.Rotate(rotVec);
            bullet.Translate(bullet.up * 1.5f, Space.World);

            bullet.GetComponent<Bullet>().Init(damage, -1, Vector3.zero); // -1 �� ���� ����
        }
    }
    void Fire() {
        if (!player.scanner.nearestTarget)
            return;
        // �Ѿ��� ���ư����� �ϴ� ���� ����
        Vector3 targetPos = player.scanner.nearestTarget.position;
        Vector3 dir = targetPos - transform.position;
        dir = dir.normalized;

        // ��ġ�� ȸ�� ����
        Transform bullet = GameManager.instance.pool.Get(prefabId).transform;
        bullet.position = transform.position;
        bullet.rotation = Quaternion.FromToRotation(Vector3.up, dir); // FromToRotation: ������ ���� �߽����� ��ǥ�� ���� ȸ���ϴ� �Լ�
        bullet.GetComponent<Bullet>().Init(damage, count, dir);

    }
}