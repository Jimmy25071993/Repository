using UnityEngine;
using System.Collections;


public class TestScript : MonoBehaviour
{
    string sa = "";
    string sb = "";

    string ssa = "";
    string ssb = "";

    string Msa = "";
    string Msb = "";

    string Dsa = "";
    string Dsb = "";

    int answer = 0;
    int answerS = 0;
    int answerM = 0;
    int answerD = 0;

    GUIStyle style ;



    int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }
    

    int SubtractTwoNumbers(int a, int b)
    {
        return a - b;
    }


    int MultiTwoNumbers(int a, int b)
    {
        return a * b;
    }

    int DivideTwoNumbers(int a, int b)
    {
        return a / b;
    }

    // Use this for initialization
    void Start () 
    {
        print(AddTwoNumbers(1,3));
    }
    // Update is called once per frame
    void Update () 
    {

    }

    void OnGUI()
    {
        //Sum
        GUI.Label(new Rect(80, 50, 50, 25), "a=");
        GUI.Label(new Rect(180, 50, 50, 25), "b=");
        GUI.Label(new Rect(40, 150, 150, 25), "a + b =");

        sa = GUI.TextArea(new Rect(100, 50, 50, 25), sa );
        sb = GUI.TextArea(new Rect(200, 50, 50, 25), sb);

        GUI.Box(new Rect(100, 100, 50, 25), answer.ToString());

        if (GUI.Button(new Rect(100, 150, 150, 25), "AddTwoNumbers()"))
        {
            answer = AddTwoNumbers(int.Parse(sa), int.Parse(sb));
        }

        //Subtract
        GUI.Label(new Rect(80, 250, 50, 25), "a=");
        GUI.Label(new Rect(180, 250, 50, 25), "b=");
        GUI.Label(new Rect(40, 350, 150, 25), "a - b =");

        ssa = GUI.TextArea(new Rect(100, 250, 50, 25), ssa);
        ssb = GUI.TextArea(new Rect(200, 250, 50, 25), ssb);

        GUI.Box(new Rect(100, 300, 50, 25), answerS.ToString());

        if (GUI.Button(new Rect(100, 350, 150, 25), "SubtractTwoNumbers()"))
        {
            answerS = SubtractTwoNumbers(int.Parse(ssa), int.Parse(ssb));
        }


        //multi
        GUI.Label(new Rect(380, 50, 50, 25), "a=");
        GUI.Label(new Rect(480, 50, 50, 25), "b=");
        GUI.Label(new Rect(340, 150, 150, 25), "a * b =");

        Msa = GUI.TextArea(new Rect(400, 50, 50, 25), Msa);
        Msb = GUI.TextArea(new Rect(500, 50, 50, 25), Msb);

        GUI.Box(new Rect(400, 100, 50, 25), answerM.ToString());

        if (GUI.Button(new Rect(400, 150, 150, 25), "MultiTwoNumbers()"))
        {
            answerM = MultiTwoNumbers(int.Parse(Msa), int.Parse(Msb));
        }


        //Divide
        GUI.Label(new Rect(380, 250, 50, 25), "a=");
        GUI.Label(new Rect(480, 250, 50, 25), "b=");
        GUI.Label(new Rect(340, 350, 150, 25), "a / b =");

        Dsa = GUI.TextArea(new Rect(400, 250, 50, 25), Dsa);
        Dsb = GUI.TextArea(new Rect(500, 250, 50, 25), Dsb);

        GUI.Box(new Rect(400, 300, 50, 25), answerD.ToString());

        if (GUI.Button(new Rect(400, 350, 150, 25), "DivideTwoNumbers()"))
        {
            answerD = DivideTwoNumbers(int.Parse(Dsa), int.Parse(Dsb));
        }
    } 
}
