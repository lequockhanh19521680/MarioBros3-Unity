using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventKeySample : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Awake()
    {
        player = Player.Instance;   
    }

    // Update is called once per frame
    void Update()
    {
        // Kiểm tra nút trái
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.SetState(Player.iStateWalkingLeft);

        }
        // Kiểm tra nút phải
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            player.SetState(Player.iStateWalkingRight);
        }
        // Nếu không nhấn nút nào, dừng di chuyển
        else
        {
            player.SetState(Player.iStateIdle);
        }

        // Kiểm tra nút nhảy
        if (Input.GetKeyDown(KeyCode.S) && player.GetIsGround())
        {
            player.SetState(Player.iStateJump);
        }
    }
}
