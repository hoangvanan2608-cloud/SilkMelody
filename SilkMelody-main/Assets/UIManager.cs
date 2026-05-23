using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void MoveLeftDown()
    {
        Player.instance.MobileMoveLeftDown();
    }

    public void MoveRightDown()
    {
        Player.instance.MobileMoveRightDown();
    }

    public void MoveUpDown()
    {
        Player.instance.MobileMoveUpDown();
    }

    public void MoveDownDown()
    {
        Player.instance.MobileMoveDownDown();
    }

    public void MoveHorizontalUp()
    {
        Player.instance.MobileMoveHorizontalUp();
    }

    public void MoveVerticalUp()
    {
        Player.instance.MobileMoveVerticalUp();
    }
    public void AttackButton()
    {
        Player.instance.MobileAttack();
    }

    public void JumpDown()
    {
        Player.instance.MobileJumpDown();
    }

    public void JumpUp()
    {
        Player.instance.MobileJumpUp();
    }

    public void DashButton()
    {
        Player.instance.MobileDash();
    }

    public void HealButton()
    {
        Player.instance.MobileHeal();
    }

    public void ParryButton()
    {
        Player.instance.MobileParry();
    }
    public void ShootButton()
    {
        Player.instance.MobileShoot();
    }
}