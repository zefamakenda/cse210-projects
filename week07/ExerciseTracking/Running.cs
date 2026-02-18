using System;


namespace ExerciseTracking 

{
    class Running : Activity 

    {
        private double _distanceKm; 

        public Running(DateTime date, int minutes, double distanceKm) 
            : base(date, minutes) // call base constructor

        {
            _distanceKm = distanceKm;

        }

        public override double GetDistance() => _distanceKm; 


        public override double GetSpeed() => (GetDistance() / GetMinutes()) * 60;

        public override double GetPace() => GetMinutes() / GetDistance(); 
        
    }
}