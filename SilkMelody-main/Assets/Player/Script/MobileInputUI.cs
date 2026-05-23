using UnityEngine;

public class MobileInputUI : MonoBehaviour
{
    public void MoveLeftDown()
    {
        Player.instance.MobileMoveLeftDown();
    }

    public void MoveRightDown()
    {
        Player.instance.MobileMoveRightDown();
    }

    public void MoveHorizontalUp()
    {
        Player.instance.MobileMoveHorizontalUp();
    }

    public void JumpDown()
    {
        Player.instance.MobileJumpDown();
    }

    public void JumpUp()
    {
        Player.instance.MobileJumpUp();
    }

    public void Attack()
    {
        Player.instance.MobileAttack();
    }

    public void Dash()
    {
        Player.instance.MobileDash();
    }

    public void Parry()
    {
        Player.instance.MobileParry();
    }

    public void Heal()
    {
        Player.instance.MobileHeal();
    }
}