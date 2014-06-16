using CharacterManager.Data.Enums;

namespace CharacterManager.Data
{
    public struct Skill
    {
        public string Name { get; set; }
        public Abilities AbilityScore { get; set; }
        public float Ranks { get; set; }
        public bool CrossClass { get; set; }
    }
}
