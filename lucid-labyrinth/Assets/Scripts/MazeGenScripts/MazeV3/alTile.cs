using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class alTData
{
    public Vector2Int currentPos;
    public bool finished;
    public bool u, d, l, r;

    public bool isBranching;
    public List<Vector2Int> outBranch;
    public List<List<alTData>> branches;


    public bool isSolution;
    public Vector2Int indir;
    public Vector2Int outdir;


    public alTData getNeighbor(alTData[,] grid, Vector2Int pos)
    {
        Vector2Int neiPos = currentPos + pos;
        return grid[neiPos.x, neiPos.y];
    }
}