namespace RoleplayGame.Items
{
    public class InfinityGauntlet : IAttackItem, IDefenseItem
    {
        
        SoulGem SoulGem = new SoulGem();
        TimeGem TimeGem = new TimeGem();
        PowerGem PowerGem = new PowerGem();
        SpaceGem SpaceGem = new SpaceGem();
        RealityGem RealityGem = new RealityGem();
        MindGem MindGem = new MindGem();

        public int AttackPower
        {
            get
            {
                return  SoulGem.AttackPower + TimeGem.AttackPower + PowerGem.AttackPower + 
                        SpaceGem.AttackPower + RealityGem.AttackPower + MindGem.AttackPower;
            }
        }

        public int DefensePower
        {
            get
            {
                return  SoulGem.DefensePower + TimeGem.DefensePower + PowerGem.DefensePower + 
                        SpaceGem.DefensePower + RealityGem.DefensePower + MindGem.DefensePower;
            }
        }

        public override string ToString()
        {
            return "InfinityGauntlet";
        }
    }
    
}