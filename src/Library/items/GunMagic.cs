namespace RoleplayGame.Items
{
    /// <summary>
    /// Gun. Permite atacar.
    /// </summary>
    public class GunMagic : IAttackItem
    {

        Gun arma=new Gun();
        Magic magia=new Magic();
        /// <summary>
        /// El poder de ataque
        /// </summary>
        /// <value></value>
        public int AttackPower
        {
            get
            {
                return arma.AttackPower + magia.AttackPower;
            }
        }

        /// <summary>
        /// Impresión
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Gun 9MM mágica";
        }

        
    }
}
