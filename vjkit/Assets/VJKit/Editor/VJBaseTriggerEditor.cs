﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System;
using System.Collections.Generic;

[CustomEditor(typeof(VJBaseTrigger))]
[CanEditMultipleObjects]
public class VJBaseTriggerEditor : VJBaseModifierEditor 
{
    public VJBaseTriggerEditor()
    {
    }

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
    }
}
