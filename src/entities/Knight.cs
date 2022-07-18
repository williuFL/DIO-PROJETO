namespace RPG.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, string Level, string HP, string MagicPow, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MagicPow = MagicPow;
            this.HeroType = HeroType;
            
        }
    }
}