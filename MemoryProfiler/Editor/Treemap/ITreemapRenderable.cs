using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor.Graphs;
using UnityEngine;

namespace Assets.Editor.Treemap
{
    internal interface ITreemapRenderable
    {
        Color GetColor();
        Rect GetPosition();
        string GetLabel();
    }
}
