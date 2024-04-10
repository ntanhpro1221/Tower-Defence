using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;

namespace Test {
    public class CharactorStats<T> {
        public T hp;
        public T atk;
        public T spd;
        public T xpRequired;
    }
    public class CharactorInfo {
        public string id;
        public string name;
        public string description;
        public CharactorStats<Vector2> statsTrans;
        public List<CharactorSkill<Vector2>> skills;
    }
    public class CharactorData {
        public int level;
        public int xp;
    }
    public class CharactorSkill<T> {
        public T CDTime { get; set; }
        public List<T> skillParams { get; set; }
        public string Description;
    }
    public class Charactor {
        protected CharactorData data;

        protected readonly CharactorInfo info;
        protected CharactorStats<float> stats;

        protected CharactorStats<Vector2> statsBonus;
        public void OnStatsChanged() {
            
        }
        public void AddXP(int amount) {
            
        }
        public void SetLevel(int level) {

        }
        public void Hit() { }
        public void Move() { }
    }

}