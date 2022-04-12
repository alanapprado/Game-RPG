Class Program;

namespace dotnet___poo.src.Entities
{
    public class Hero
    {
    
        {
        public Hero(sring Name, int Level, string HeroType)
         this.Name= Name; 
         this.level = Level; 
         this.HeroType = HeroType;
        }

        public string name;
        
        public int level;

        public string HeroType;

        public override string ToString(){
            return this.Name + " " + this.Level + " " this.HeroType
        }
    }
}