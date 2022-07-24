using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    
    public List<Card> deck = new List<Card>();

    void Start() {
        List<int> player1cards = new List<int>{ConvertCardToInteger("6"), ConvertCardToInteger("11")};
        List<int> player2cards = new List<int>{ConvertCardToInteger("9"), ConvertCardToInteger("3")};

        Dictionary<string, dynamic> winner = DetermineWinner(player1cards, player2cards);

        Debug.Log(winner["player-won"]);
    }

    int ConvertCardToInteger(string card) {
        if (card == "jack") {
            return 11;
        } else if (card == "queen") {
            return 12;
        } else if (card == "king") {
            return 13;
        } else {
            return int.Parse(card);
        } 
    }

    Dictionary<string, dynamic> DetermineWinner(List<int> player1cards, List<int> player2cards) {
        // NOTES: player-won could be player1, player2 and tie. It decides who won
        Dictionary<string, dynamic> result = new Dictionary<string, dynamic>() {
            {"player-won", "none"},
            {"player-one-total", 0},
            {"player-two-total", 0}
        }; 

        int player1total = 0;
        int player2total = 0;

        // Totals up the total for the card
        for(int i=0; i < player1cards.Count; i++) {
            player1total += player1cards[i];
        }   

        for(int i=0; i < player2cards.Count; i++) {
            player2total += player2cards[i];
        }

        result["player-one-total"] = player1total;
        result["player-two-total"] = player2total;

        // Determines who win
        if (player1total > player2total)
            result["player-won"] = "player-1";
        else if (player1total < player2total)
            result["player-won"] = "player-2";
        else
            result["player-won"] = "tie";

        return result;
    }

}
