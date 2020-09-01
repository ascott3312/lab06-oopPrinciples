using System;

namespace IBuildaAZoo
{

    /// <summary>
    /// Parent Class
    /// </summary>
    public abstract class Animals
    {
        // Properties
        public abstract int NumberOfLegs { get; }
        public string Size { get; protected set; }
        public virtual string Skin => "Fur";
        // public virtual bool Skin { get { return true; }
     
        }
     
    }
