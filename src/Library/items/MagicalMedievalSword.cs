namespace RoleplayGame.Items
{
    /// <summary>
    /// Espada medieval. Permite atacar a los rivales sacandoles mucho daño.
    /// </summary>
    public class MagicalMedievalSword : Magic
    {
        /// <summary>
        /// Necesito agarrar de un objeto de tipo MedievalSword el AttackPower.
        /// </summary>
        MedievalSword MSword = new MedievalSword();
        
        /// <summary>
        /// Necesito agarrar de un objeto de tipo Magic el AttackPower.
        /// </summary>
        Magic MMSword = new Magic();

        /// <summary>
        /// El poder de ataque.
        /// </summary>
        /// <value></value>
        public int AttackPowerMagic
        {
             
            get
            {
                return  MSword.AttackPower + MMSword.AttackPower ;
            }
        }

         public override string ToString()
        {
            return "MagicalMedievalSword";
        }
    }
}