namespace RPG.src.entities
{


    public abstract class Hero
    {
        public Hero(string Name, string Level, string HP, string MagicPow, string HeroType)
    {
        this.Name = Name;
        this.Level = Level;
        this.HP = HP;
        this.MagicPow = MagicPow;
        this.HeroType = HeroType;
        
    }

        public Hero()
        {
            
        }
        public string Name { get; set; }
        public string Level { get; set; }
        public string HeroType { get; set; }
        public string HP {get; set;}
        public string MagicPow { get; set; }

        public override string ToString() 
        {
            return this.Name + " " + this.Level + " " + this.HP + " " + this.MagicPow + " " + this.HeroType;
        }
        public virtual string Attack() {
            return this.Name + " " + "atacou com sua espada.";
        }
        public string AttackD(int Bonus)
        {
            if(Bonus > 6)
            {
                return this.Name + " " + "deu um crítico com sua espada, bônus de" + " " + Bonus+".";
            }
            else
            {
                return this.Name + " " + "o ataque não foi tão forte, bônus de" + Bonus+".";
            }
        }
            
    }
}