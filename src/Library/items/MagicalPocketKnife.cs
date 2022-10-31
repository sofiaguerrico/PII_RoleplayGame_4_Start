namespace RoleplayGame.Items
{
    public class MagicalPocketKnife : IAttackItem
    {
        public Magic MagicPower = new Magic();

        public PocketKnife PocketKnife = new PocketKnife();

        public int AttackPower
        {
            get
            {
                return MagicPower.AttackPower + PocketKnife.AttackPower;
            }
        }

        public override string ToString()
        {
            return "MagicalPocketKnife";
        }
    }
}