namespace RoleplayGame.Items
{
    /// <summary>
    /// Gun. Permite atacar.
    /// </summary>
    public class Gun : IAttackItem
    {
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return 30;
            }
        }

        /// <summary>
        /// Impresión
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Gun 9MM";
        }

        
    }
}