using Godot;
using System;

public class custom_label : Label
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";
	[Export] public string Message;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		SetMessage(Message);
	}

	//  // Called every frame. 'delta' is the elapsed time since the previous frame.
	//  public override void _Process(float delta)
	//  {
	//      
	//  }
	public void SetMessage(string Message)
	{

		bool cartouche = false;
		foreach (string word in Message.Split(" "))
		{
			if (word.Equals("("))
			{
				cartouche = true;
				Text += latin_to_sitelen(word);
				continue;
			}
			else if (word.Equals(")"))
			{
				cartouche = false;
			}

			if (cartouche)
			{
				Text += latin_to_sitelen(word) + "󱦒";
			}
			else
			{
				Text += latin_to_sitelen(word);
			}
		}
	}

	public string latin_to_sitelen(string word)
	{
		switch (word)
		{
			// 0x0f1900
			case "a":
				return "󱤀";
			case "akesi":
				return "󱤁";
			case "ala":
				return "󱤂";
			case "alasa":
				return "󱤃";
			case "ale":
				return "󱤄";
			// 0x0f1905
			case "anpa":
				return "󱤅";
			case "ante":
				return "󱤆";
			case "anu":
				return "󱤇";
			case "awen":
				return "󱤈";
			case "e":
				return "󱤉";
			// 0x0f190a
			case "en":
				return "󱤊";
			case "esun":
				return "󱤋";
			case "ijo":
				return "󱤌";
			case "ike":
				return "󱤍";
			case "ilo":
				return "󱤎";
			case "insa":
				return "󱤏";
			// 0x0f1910
			case "jaki":
				return "󱤐";
			case "jan":
				return "󱤑";
			case "jelo":
				return "󱤒";
			case "jo":
				return "󱤓";
			case "kala":
				return "󱤔";
			// 0x0f1915
			case "kalama":
				return "󱤕";
			case "kama":
				return "󱤖";
			case "kasi":
				return "󱤗";
			case "ken":
				return "󱤘";
			case "kepeken":
				return "󱤙";
			//0x0f191a
			case "kili":
				return "󱤚";
			case "kiwen":
				return "󱤛";
			case "ko":
				return "󱤜";
			case "kon":
				return "󱤝";
			case "kule":
				return "󱤞";
			case "kulupu":
				return "󱤟";
			// 0x0f1920
			case "kute":
				return "󱤠";
			case "la":
				return "󱤡";
			case "lape":
				return "󱤢";
			case "laso":
				return "󱤣";
			case "lawa":
				return "󱤤";
			// 0x0f1925
			case "len":
				return "󱤥";
			case "lete":
				return "󱤦";
			case "li":
				return "󱤧";
			case "lili":
				return "󱤨";
			case "linja":
				return "󱤩";
			// 0x0f192a
			case "lipu":
				return "󱤪";
			case "loje":
				return "󱤫";
			case "lon":
				return "󱤬";
			case "luka":
				return "󱤭";
			case "lukin":
				return "󱤮";
			case "lupa":
				return "󱤯";
			// 0x0f1930
			case "ma":
				return "󱤰";
			case "mama":
				return "󱤱";
			case "mani":
				return "󱤲";
			case "meli":
				return "󱤳";
			case "mi":
				return "󱤴";
			// 0x0f1935
			case "mije":
				return "󱤵";
			case "moku":
				return "󱤶";
			case "moli":
				return "󱤷";
			case "monsi":
				return "󱤸";
			case "mu":
				return "󱤹";
			// 0x0f193a
			case "mun":
				return "󱤺";
			case "musi":
				return "󱤻";
			case "mute":
				return "󱤼";
			case "nanpa":
				return "󱤽";
			case "nasa":
				return "󱤾";
			case "nasin":
				return "󱤿";
			// 0x0f1940
			case "nena":
				return "󱥀";
			case "ni":
				return "󱥁";
			case "nimi":
				return "󱥂";
			case "noka":
				return "󱥃";
			case "o":
				return "󱥄";
			// 0x0f1945
			case "olin":
				return "󱥅";
			case "ona":
				return "󱥆";
			case "open":
				return "󱥇";
			case "pakala":
				return "󱥈";
			case "pali":
				return "󱥉";
			// 0x0f194a
			case "palisa":
				return "󱥊";
			case "pan":
				return "󱥋";
			case "pana":
				return "󱥌";
			case "pi":
				return "󱥍";
			case "pilin":
				return "󱥎";
			case "pimeja":
				return "󱥏";
			// 0x0f1950
			case "pini":
				return "󱥐";
			case "pipi":
				return "󱥑";
			case "poka":
				return "󱥒";
			case "poki":
				return "󱥓";
			case "pona":
				return "󱥔";
			// 0x0f1955
			case "pu":
				return "󱥕";
			case "sama":
				return "󱥖";
			case "seli":
				return "󱥗";
			case "selo":
				return "󱥘";
			case "seme":
				return "󱥙";
			// 0x0f195a
			case "sewi":
				return "󱥚";
			case "sijelo":
				return "󱥛";
			case "sike":
				return "󱥜";
			case "sin":
				return "󱥝";
			case "sina":
				return "󱥞";
			case "sinpin":
				return "󱥟";
			// 0x0f1960
			case "sitelen":
				return "󱥠";
			case "sona":
				return "󱥡";
			case "soweli":
				return "󱥢";
			case "suli":
				return "󱥣";
			case "suno":
				return "󱥤";
			// 0x0f1965
			case "supa":
				return "󱥥";
			case "suwi":
				return "󱥦";
			case "tan":
				return "󱥧";
			case "taso":
				return "󱥨";
			case "tawa":
				return "󱥩";
			// 0x0f196a
			case "telo":
				return "󱥪";
			case "tenpo":
				return "󱥫";
			case "toki":
				return "󱥬";
			case "tomo":
				return "󱥭";
			case "tu":
				return "󱥮";
			case "unpa":
				return "󱥯";
			// 0x0f1970
			case "uta":
				return "󱥰";
			case "utala":
				return "󱥱";
			case "walo":
				return "󱥲";
			case "wan":
				return "󱥳";
			case "waso":
				return "󱥴";
			// 0x0f1975
			case "wawa":
				return "󱥵";
			case "weka":
				return "󱥶";
			case "wile":
				return "󱥷";
			// END OF BASE SITELEN PONA
			case "ku":
				return "󱦈";
			// 0x0f1990
			case "(":
				return "󱦐";
			case ")":
				return "󱦑";
		}
		return "";
	}
}
