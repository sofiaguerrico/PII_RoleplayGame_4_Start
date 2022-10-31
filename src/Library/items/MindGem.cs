namespace RoleplayGame.Items
{
    /// <summary>
    /// MindGem. Gema de la mente. Da ataque y defensa.
    /// </summary>
    public class MindGem : IGem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 16;
            }
        }


        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 26;
            }
        }

         public override string ToString()
        {
            return "MindGem";
        }
    }
}
