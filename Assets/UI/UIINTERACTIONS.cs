using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;


public class UIINTERACTIONS : Stats
{
    public Texture2D buttonImage;
    public Vector2 position;
    public Vector2 size;
    private string PlayerLabel = "Players rizzemble!";
    private string CompanionLabel = "Let's defeat the Rizzler";
    private string DemonKingLabel = "Rizzler";
    private string ATTACK = "Attack";
    private Stats  PlayerStats;

    private void OnGUI()
    {
        GUI.Box(new Rect(10, 5, 1450, 700  ),"");
        GUI.Label(new Rect(900, 350, 200, 30), DemonKingLabel);
        GUI.Label(new Rect(265 , 575, 600, 600), PlayerLabel);
        GUI.Label(new Rect(905, 505, 200, 30), CompanionLabel);
        GUI.Label(new Rect(700, 450, 200, 30), ATTACK);
            
        if (GUI.Button(new Rect(250, 600, 250, 50), "Mage"))
        {
            PlayerStats = mage;
            PlayerLabel = $"Mage Stats \n\r Health : {Health} \n\r Attack : {Attack} \n\r Defense : {Defense}";
        }

        if (GUI.Button(new Rect(600, 600, 250, 50), "Archer"))
        {
            


        }

        if (GUI.Button(new Rect(950, 600, 250, 50), "Swordsman"))
        {
            PlayerStats = swordsman;
            PlayerLabel = "Player: " + "\nHealth: " + swordsman.Health + "\nAttack: " + swordsman.Attack + "\nDefences: " + swordsman.Defense;
        }
        if (GUI.Button(new Rect(600, 475, 250, 100), "ATTACK"))
        {

        }   
        if (GUI.Button(new Rect(600, 100, 245  , 250), buttonImage))
        {

        }
        if (GUI.Button(new Rect(600, 350, 245, 50), "Demon King"))
        {

        }
        if (GUI.Button(new Rect(900, 525, 250, 50), "Companion Knight"))
        {

        }




        GUI.Box(new Rect(position, size), buttonImage);
    }

    [SerializeField] Mage mage;
    [SerializeField] Archer archer;
    [SerializeField] Swordsman swordsman;
    [SerializeField] CompanionKnight companionknight;
    [SerializeField] DemonKing demonking;
       
    

}
