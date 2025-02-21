﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearGame
{
    public class Player
    {

        public const int NUMBER_OF_CHARACTERS = 4;
        public const int NUMBER_OF_MOVEMENT_SQUARES = 40;

        public Strategy PlayerStrategy { get; set; }
        public bool AllCahractersInFinalSquare {  get; set; }
        public Color PlayerColor { get; set; }
        public TextBox[] PlayerSquares { get; set; }
        public TextBox PlayerStartingSquare { get; set; }
        public Character[] PlayerCharacters { get; set; }
        public int NumberOfCharactersInFinalSquare { get; set; }



        public Player(Color playerColor, TextBox[] playerSquares, Strategy playerStrategy)
        {
            if (playerSquares.Length != 2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
            {
                throw new ArgumentException("Invalid number of squares for player");
            }

            PlayerColor = playerColor;
            PlayerStrategy = playerStrategy;
            NumberOfCharactersInFinalSquare = 0;
            PlayerSquares = playerSquares;
            AllCahractersInFinalSquare = false;
            PlayerStartingSquare = playerSquares[NUMBER_OF_CHARACTERS];

            PlayerCharacters = new Character[NUMBER_OF_CHARACTERS];

            for (int i = 0; i < NUMBER_OF_CHARACTERS; i++)
            {
                PlayerCharacters[i] = new Character(i, PlayerSquares[i], playerColor);
            }
        }

        public List<Character> ActiveCharacters = new List<Character>();

        public void KnockOutCharacterOfThisPlayer(Character characterToBeKnockedOut)
        {
            if (characterToBeKnockedOut.IsInFinalSquare || characterToBeKnockedOut.IsInStartingSquare || ActiveCharacters.Contains(characterToBeKnockedOut) == false)
            {
                throw new ArgumentException("Character can not be knocked out.");
            }

            characterToBeKnockedOut.Reset();
            ActiveCharacters.Remove(characterToBeKnockedOut);
        }

        public int IndexOfMoveEndingSquare(Character character, int roll)
        {
            int indexOfEndSquare = character.LocationIndex + roll;

            if (indexOfEndSquare < NUMBER_OF_CHARACTERS)
            {
                throw new ArgumentException("Invalid character movement: less than character count.");
            }

            if (indexOfEndSquare >= 2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
            {
                indexOfEndSquare = 2 * (2 * NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES - 1) - indexOfEndSquare;
            }

            return indexOfEndSquare;
        }

        public Character? FindCahracterByLocation(TextBox location)
        {
            if (location.BackColor == PlayerColor)
            {
                foreach (Character character in ActiveCharacters)
                {
                    if (character.LocationBox == location)
                    {
                        return character;
                    }
                }
            }
            return null;
        }

        public void SetACharacterActive()
        {
            if (ActiveCharacters.Count == NUMBER_OF_CHARACTERS)
            {
                throw new ArgumentException("All characters are already active");
            }

            if (PlayerStartingSquare.BackColor == PlayerColor)
            {
                throw new ArgumentException("Starting square is already occupied");
            }

            foreach (Character character in PlayerCharacters)
            {
                if (character.IsInStartingSquare)
                {
                    character.IsInStartingSquare = false;
                    ActiveCharacters.Add(character);
                    character.MoveCharacter(PlayerStartingSquare, NUMBER_OF_CHARACTERS);
                    return;
                }
            }

            throw new ArgumentException("There are no characters in starting squares.");
        }

        public void MoveCahracter(int numOfSquaresToMove, Character character)
        {
            if (character.IsInStartingSquare || character.IsInFinalSquare || ActiveCharacters.Contains(character) == false)
            {
                throw new ArgumentException("Invalid character location");
            }

            int indexOfSqureToMove = IndexOfMoveEndingSquare(character, numOfSquaresToMove);

            if (PlayerSquares[indexOfSqureToMove].BackColor == PlayerColor)
                {
                return;
                }

            if (indexOfSqureToMove >= NUMBER_OF_CHARACTERS + NUMBER_OF_MOVEMENT_SQUARES)
            {
                MoveToFinalSquare(indexOfSqureToMove, character);
                return;
            }

            character.MoveCharacter(PlayerSquares[indexOfSqureToMove], indexOfSqureToMove);

        }

        public void MoveToFinalSquare(int indexOfSquareToMove, Character character)
        {
            character.MoveCharacter(PlayerSquares[indexOfSquareToMove], indexOfSquareToMove);
            character.IsInFinalSquare = true;
            ActiveCharacters.Remove(character);
            NumberOfCharactersInFinalSquare++;

            AllCahractersInFinalSquare = NumberOfCharactersInFinalSquare == NUMBER_OF_CHARACTERS;
        }

        public void Reset()
        {
            foreach (Character character in PlayerCharacters)
            {
                character.Reset();
            }

            NumberOfCharactersInFinalSquare = 0;
            ActiveCharacters.Clear();
            AllCahractersInFinalSquare = false;
        }

    }

}