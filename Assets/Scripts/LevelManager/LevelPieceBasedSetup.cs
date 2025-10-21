using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class LevelPieceBasedSetup : ScriptableObject
{
    [Header("Pieces")]
    public List<LevelPieceBase> levelStartPieces;
    public List<LevelPieceBase> levelPieces;
    public List<LevelPieceBase> levelEndPieces;

    public int pieceStartNumber = 3;
    public int pieceNumber = 5;
    public int pieceEndNumber = 1;
}
