using UnityEngine;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;


// Animation Fields with normal and optimized namings since JSON may use either format.
/*
----------------------------------------------------------
 Normal Name            -> Optimized Name
----------------------------------------------------------
ANIMATION               -> AN
SYMBOL_DICTIONARY       -> SD
metadata                -> MD
name                    -> N
StageInstance           -> STI
SYMBOL_Instance         -> SI
SYMBOL_name             -> SN
TIMELINE                -> TL
LAYERS                  -> L
Layer_name              -> LN
Layer_type              -> LT
Clipped_by              -> Clpb
Frames                  -> FR
framerate               -> FRT
version                 -> V
index                   -> I
duration                -> DU
elements                -> E
color                   -> C
filters                 -> F
ATLAS_SPRITE_instance   -> ASI
Instance_Name           -> IN
symbolType              -> ST
bitmap                  -> BM
blend                   -> B
firstFrame              -> FF
loop                    -> LP
transformationPoint     -> TRP
Matrix3D                -> M3D
Matrix                  -> MX
mode                    -> M
Position                -> POS
*/

namespace Flashline.Data.TextureAtlas
{

    [System.Serializable]
    public class AnimateAtlas
    {
        public Animation ANIMATION;
        public SymbolDictionary SYMBOL_DICTIONARY;
        public Metadata metadata;
    }
    
    [System.Serializable]
    public class Animation
    {
        public string name;
        public StageInstance StageInstance;
        public string SYMBOL_name;
        public Timeline TIMELINE;
    }

    [System.Serializable]
    public class StageInstance
    {
        public SymbolInstance SYMBOL_Instance;
    }

    [System.Serializable]
    public class Timeline
    {
        public List<Layer> LAYERS;
    }

    [System.Serializable]
    public class Layer
    {
        public string Layer_name;
        public string Layer_type;
        public string Clipped_by;
        public List<Frame> Frames;
    }

    [System.Serializable]
    public class Metadata
    {
        public double framerate;
        public string version;
    }

    [System.Serializable]
    public class Frame
    {
        public int index;
        public int duration;
        public string name;
        public List<Element> elements;
        // ColorEffects
        // Filters
    }

    [System.Serializable]
    public class Element
    {
        public SymbolInstance SYMBOL_Instance;
        public AtlasSymbolInstance ATLAS_SPRITE_instance;
    }

    [System.Serializable]
    public class SymbolInstance
    {
        public string SYMBOL_name;
        public string Instance_Name;
        public string symbolType;
        // bitmap
        // blend
        public int firstFrame;
        public string loop;
        public TransformationPoint transformationPoint;
        public Matrix3D Matrix3D;
        public DecomposedMatrix DecomposedMatrix;
        // color
        // filters
    }

    // ColorEffects
    // Filters
    // AdjustColorFilter
    // BlurFilter
    // GlowFilter
    // DropShadow
    // BevelFilter
    // GradientFilter
    // GradientEntry
    // Bitmap

    [System.Serializable]
    public class AtlasSymbolInstance
    {
        public string name;
        public Matrix3D Matrix3D;
        public DecomposedMatrix DecomposedMatrix;
    }

    [System.Serializable]
    public class Matrix3D
    {
        public double m00;
        public double m01;
        public double m02;
        public double m03;
        public double m10;
        public double m11;
        public double m12;
        public double m13;
        public double m20;
        public double m21;
        public double m22;
        public double m23;
        public double m30;
        public double m31;
        public double m32;
        public double m33;
    }

    [System.Serializable]
    public class DecomposedMatrix
    {
        public Position Position;
        public Rotation Rotation;
        public Scaling Scaling;
    }

    [System.Serializable]
    public class TransformationPoint
    {
        public double x;
        public double y;
    }

    [System.Serializable]
    public class Position
    {
        public double x;
        public double y;
        public double z;
    }

    [System.Serializable]
    public class Rotation
    {
        public double x;
        public double y;
        public double z;
    }

    [System.Serializable]
    public class Scaling
    {
        public double x;
        public double y;
        public double z;
    }

    [System.Serializable]
    public class Symbol
    {
        public string SYMBOL_name;
        public Timeline TIMELINE;
    }

    [System.Serializable]
    public class SymbolDictionary
    {
        public List<Symbol> Symbols;
    }
}
