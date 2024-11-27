using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using UnityEngine;


public class UIINTERACTIONS : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;
    private string PlayerLabel = "Players rizzemble!";
    private string CompanionLabel = "Let's defeat the Rizzler";
    private string DemonKingLabel = "Rizzler";
    private string ATTACK = "Attack";
    private Stats Player;

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 5, 1450, 700  ),"");
        GUI.Label(new Rect(900, 250, 200, 30), DemonKingLabel);
        GUI.Label(new Rect(100 , 450, 600, 600), PlayerLabel);
        GUI.Label(new Rect(905, 395, 200, 30), CompanionLabel);
        GUI.Label(new Rect(700, 450, 200, 30), ATTACK);
            
        if (GUI.Button(new Rect(250, 600, 250, 50), "Mage"))
        {
            Player = mage;
            PlayerLabel = "Player: " + "\nHealth: " + mage.Health + "\nAttack: " + mage.Attack + "\nDefense: " + mage.Defense;
        }

        if (GUI.Button(new Rect(600, 600, 250, 50), "Archer"))
        {
            Player = archer;
            PlayerLabel = "Player: " + "\nHealth: " + archer.Health + "\nAttack: " + archer.Attack + "\nDefense: " + archer.Defense;
        }

        if (GUI.Button(new Rect(950, 600, 250, 50), "Swordsman"))
        {
            Player = swordsman;
            PlayerLabel = "Player: " + "\nHealth: " + swordsman.Health + "\nAttack: " + swordsman.Attack + "\nDefense: " + swordsman.Defense;
        }
        if (GUI.Button(new Rect(600, 475, 250, 100), "ATTACK"))
        {
            if (Player != null)
            {
                Player.Health = demonking.NPCAttack;
            }
            if (companionknight != null)
            {
                companionknight.NPCHealth -= demonking.NPCAttack;
            }
            if (demonking != null)
            {
                demonking.NPCHealth -= Player.Attack;
            }
            AttackDamage();

            if (Player.Health <= 0)
            {
                PlayerLabel = "";
                CompanionLabel = "";
                DemonKingLabel = "";
                ATTACK = "You Lose";
            }
            if(demonking.NPCHealth <= 0)
            {
                PlayerLabel = "";
                CompanionLabel = "";
                DemonKingLabel = "";
                ATTACK = "You Win";
            }
            if (companionknight.NPCHealth <= 0)
            {
                companionknight.NPCHealth = 0;

            }

        }   
        if (GUI.Button(new Rect(600, 100, 245  , 250), buttonImage))
        {

        }
        if (GUI.Button(new Rect(600, 350, 245, 50), "Demon King"))
        {
            DemonKingLabel = "Demon King : " + "\nHealth: " + demonking.NPCHealth + "\nAttack: " + demonking.NPCAttack + "\nDefense: " + demonking.NPCDefense;
        }
        if (GUI.Button(new Rect(900, 525, 250, 50), "Companion Knight"))
        {
            CompanionLabel = "Companion Knight: " + "\nHealth: " + companionknight.NPCHealth + "\nAttack: " + companionknight.NPCAttack + "\nDefense: " + companionknight.NPCDefense;
        }




        GUI.Box(new Rect(position, size), buttonImage);
    }

    private void AttackDamage()
    {
        DemonKingLabel = "Demon King: " + "\nHealth: " + demonking.NPCHealth + "\nAttack: " + demonking.NPCAttack + "\nDefense: " + demonking.NPCDefense;
        PlayerLabel = "Player: " + "\nHealth: " + Player.Health + "\nAttack: " + Player.Attack + "\nDefense: " + Player.Defense;
        CompanionLabel = "Companion Knight: " + "\nHealth: " + companionknight.NPCHealth + "\nAttack: " + companionknight.NPCAttack + "\nDefense: " + companionknight.NPCDefense;
    }
    

    [SerializeField] Mage mage;
    [SerializeField] Archer archer;
    [SerializeField] Swordsman swordsman;
    [SerializeField] CompanionKnight companionknight;
    [SerializeField] DemonKing demonking;
       
    

}
