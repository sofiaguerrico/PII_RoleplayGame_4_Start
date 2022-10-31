namespace RoleplayGame.Items
{
    /// <summary>
    /// Gema de la realidad. Permite atacar y defensa.
    /// </summary>
    public class RealityGem : IGem
    {
        /// <summary>
        /// El poder de ataque
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

        /// <summary>
        /// Impresión
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Gema de la realidad";
        }

        
    }
}