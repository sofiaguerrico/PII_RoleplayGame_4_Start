namespace RoleplayGame.Items
{
    public class PocketKnife : IAttackItem
    {
        public int AttackPower
        {
            get
            {
                return 20;
            }
        }

        public override string ToString()
        {
            return "PocketKnife";
        }
    }
}