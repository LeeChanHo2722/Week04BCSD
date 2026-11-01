using System.Collections.Generic;
using UnityEngine;

public class Lesson04 : MonoBehaviour
{
    int level = 5;
    float strength = 15.5f;
    string playerName = "나검사";
    bool isFullLevel = false;
    int health = 30;
    int mana = 25;

    void Start()
    {
        Debug.Log(level);
        Debug.Log(strength);
        Debug.Log(playerName);
        Debug.Log(isFullLevel);

        string[] monsters = { "슬라임", "사막뱀", "악마" };
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("마나물약30");
        Debug.Log(items[0]);
        Debug.Log(items[1]);
        items.RemoveAt(0);
        Debug.Log(items[0]);

        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;
        Debug.Log(exp);
        Debug.Log(level);
        Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        Debug.Log(nextExp);

        string title = "전설의";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log("만렙입니까? " + isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼을 끝냈습니까? " + isEndTutorial);

        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log(isBadCondition);
        isBadCondition = health <= 50 || mana <= 20;
        Debug.Log(isBadCondition);

        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log(condition);

        if (condition == "나쁨")
        {
            Debug.Log("플레이어의 상태가 나쁘니 아이템을 사용하세요.");
        }
        else
        {
            Debug.Log("플레이어의 상태가 좋습니다.");
        }

        if (isBadCondition && items.Count > 0 && items[0] == "생명물약30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명물약30을 사용하였습니다.");
        }
        else if (isBadCondition && items.Count > 0 && items[0] == "마나물약30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나물약30을 사용하였습니다.");
        }

        string monsterAlarm;
        switch (monsters[1])
        {
            case "슬라임":
            case "사막뱀":
                monsterAlarm = "소형 몬스터가 출현!";
                break;
            case "악마":
                monsterAlarm = "중형 몬스터가 출현!";
                break;
            case "골렘":
                monsterAlarm = "대형 몬스터가 출현!";
                break;
            default:
                monsterAlarm = "??? 몬스터가 출현!";
                break;
        }
        Debug.Log(monsterAlarm);

        while (health > 0)
        {
            health--;
            if (health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망하였습니다.");

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료 중... " + health);
        }

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터: " + monsters[index]);
        }

        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터: " + monster);
        }

        health = Heal(health);
        Heal();

        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게 " + Battle(monsterLevel[index]));
        }

        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());
        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        player.Move();
    }

    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다. " + currentHealth);
        return currentHealth;
    }

    void Heal()
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";
        return result;
    }

    public class Actor
    {
        public int id;
        public string name;
        public string title;
        public string weapon;
        public float strength;
        public int level;

        public string Talk()
        {
            return "대화를 걸었습니다.";
        }

        public string HasWeapon()
        {
            return weapon;
        }

        public void LevelUp()
        {
            level = level + 1;
        }
    }

    public class Player : Actor
    {
        public void Move()
        {
            Debug.Log("움직입니다.");
        }
    }
}
