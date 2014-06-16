using System.Collections.Generic;
using CharacterManager.Data.Enums;

namespace CharacterManager.Data
{
    public class Character
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public CharacterClass Class { get; set; }
        public Dictionary<CharacterClass, int> ClassLevels { get; set; }
        public string Race { get; set; }
        public string Alignment { get; set; }
        public string ReligionOrDiety { get; set; }
        public Biography Biography { get; set; }
        public IDictionary<Abilities, float> AbilityScores { get; set; }
        public float TotalHitPoints { get; set; }
        public float CurrentHitPoints { get; set; }
        public IDictionary<CombatBonuses, float> CombatBonuses { get; set; }
        public IDictionary<SavingThrows, float> SavingThrows { get; set; }
        public IEnumerable<Skill> Skills { get; set; } 
    }
}
