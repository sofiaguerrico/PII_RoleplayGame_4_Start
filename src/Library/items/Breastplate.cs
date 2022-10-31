namespace RoleplayGame.Items
{
    /// <summary>
    /// Breastplate. Es la coraza del Troll. 
    /// </summary>
    public class Breastplate : IDefenseItem
    {

        /// <summary>
        /// El poder de defensa.
        /// </summary>
        /// <value></value>
        public int DefensePower
        {
            get
            {
                return 50;
            }
        }

         public override string ToString()
        {
            return "Breastplate";
        }
    }
}