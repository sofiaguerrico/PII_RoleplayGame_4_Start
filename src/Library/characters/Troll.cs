using System.Collections.Generic;
using RoleplayGame.Items;

namespace RoleplayGame.Characters
{
    /// <summary>
    /// Personaje Elfo
    /// </summary>
    public class Troll : Character
    {
        public Troll(string name)
            : base(name)
        {
            this.Health = 100;
            this.AddItem(new Breastplate());
            this.AddItem(new Stick());
        }
    }
}