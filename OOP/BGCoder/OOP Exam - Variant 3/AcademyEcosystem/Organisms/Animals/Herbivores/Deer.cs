﻿namespace AcademyEcosystem
{
    public class Deer : Animal, IHerbivore
    {
        // Field
        private int biteSize;

        // Constructor
        public Deer(string name, Point location)
            : base(name, location, 3)
        {
            this.biteSize = 1;
        }

        // Methods
        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining) this.Awake();
                else this.sleepRemaining -= timeElapsed;
            }
            base.Update(timeElapsed);
        }

        public int EatPlant(Plant p)
        {
            if (p != null) return p.GetEatenQuantity(this.biteSize);
            return 0;
        }
    }
}
