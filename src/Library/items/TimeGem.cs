namespace RoleplayGame.Items
{
    public class TimeGem : IGem
    {
        public int AttackPower
        {
            get
            {
                return 16;
            }
        }

        public int DefensePower
        {
            get
            {
                return 26;
            }
        }

        public override string ToString()
        {
            return "TimeGem";
        }
    }
}