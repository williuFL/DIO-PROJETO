namespace RPG.src.entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, string Level, string HP, string MagicPow, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MagicPow = MagicPow;
            this.HeroType = HeroType;
        }
        
        
        public override string Attack() 
        {
            return this.Name + " " + "lançou sua magia.";
        }

        public string Attack(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " " + "lançou uma magia super poderosa com bônus de " + Bonus+".";
            }
            else
            {
                return this.Name + " " + "lançou um poder não tão forte com bônus de " + Bonus+".";
            }
        }
    }
}