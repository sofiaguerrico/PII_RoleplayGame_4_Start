namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada medieval. Permite atacar a los rivales sacandoles mucho daño.
    /// </summary>
    public class MedievalSword : IAttackItem
    {
        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 27;
            }
        }

         public override string ToString()
        {
            return "MedievalSword";
        }
    }
}