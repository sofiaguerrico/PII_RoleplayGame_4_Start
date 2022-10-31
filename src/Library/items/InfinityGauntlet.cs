using System.Collections.Generic;
using System.Linq;
namespace RoleplayGame.Items
{
    public class InfinityGauntlet : IAttackItem, IDefenseItem
    {
        List<IGem> GemList = new List<IGem>();

        public void EquipGem(IGem gem)
        {
            GemList.Add(gem);
        }

        public int AttackPower
        {
            get
            {
                return  GemList.Sum(gem => gem.AttackPower);
            }
        }

        public int DefensePower
        {
            get
            {
                return  GemList.Sum(gem => gem.DefensePower);
            }
        }

        public override string ToString()
        {
            return "InfinityGauntlet";
        }
    }   
}