using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventOfCodeDay2 {
	internal class Program {
		static void Main(string[] args) {
			StreamReader Input = new StreamReader("input.txt");
			List<string> Output = new List<string>();
			bool Reading = true;
			while (Reading) {
				string Round = Input.ReadLine();
				if (Round == null) {
					Reading = false;
				} else {
					Output.Add(Round);
				}
			}
			int Score = 0;
			for (int i = 0; i < Output.Count; i++) { 
				string Game = Output[i];
				int Opponent = 0;
				int Player = 0;
				if (Game[0] == 'A') {
					Opponent = 1;
				} else if (Game[0] == 'B') {
					Opponent = 2;
				} else if (Game[0] == 'C') {
					Opponent = 3;
				}
				if (Game[2] == 'X') {
					Player = Opponent-1;
					if (Player == 0) {
						Player = 3;
					}
				} else if (Game[2] == 'Y') {
					Player = Opponent;
				} else if (Game[2] == 'Z') {
					Player = Opponent+1;
					if(Player == 4) {
						Player = 1;
					}
					Player = -Player;
				}
				switch (Player - Opponent) { 
					case 0: {
							Score += Player+3;
							break;
						}
					
					case -1: {
							Score += Player;
							break;
						}
					
					case 2: {
							Score += Player;
							break;
						}
					case -3: {
							Score += -Player + 6;
							break;
						}
					case -4: {
							Score += -Player + 6;
							break;
						}
					case -5: {
							Score += -Player + 6;
							break;
						}
					
					default: {
							Score += 1;
							Console.WriteLine("hi");
							Console.WriteLine(i);
							Console.WriteLine(Player-Opponent);
							break;
						}
				}

			}
			Console.WriteLine(Score);
			Console.ReadLine();
		}
	}
}
