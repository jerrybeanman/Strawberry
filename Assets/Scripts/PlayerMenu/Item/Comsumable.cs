﻿using UnityEngine;
using System.Collections;
using System;

[System.Serializable]
public class Comsumable : Item {

	public int comHp;
	public int comMp;

	public override string Type
	{
		get { return "Comsumable"; }
	}
	public Comsumable()
	{}
	public Comsumable(int id, string name, string desc, int gold, int hp, int mp) : base(id, name, desc, gold)
	{
		comHp = hp;
		comMp = mp;
	}
	
	public override string ToString()
	{
		string s;
		s = base.ToString ();
		s += "<b><color=#4DA4BF>" +  "+HP:" + "</color></b>" + comHp.ToString() + "\n";
		s += "<b><color=#4DA4BF>" +  "+MP:" + "</color></b>" + comMp.ToString() + "\n";
		return s;
	}

    public override void AddStat()
    {
       
    }
    public override void RemoveStat()
    {
        
    }
}
