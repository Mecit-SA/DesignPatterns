namespace AbstractFactory
{
    class BuildMuscleFactory : IGoalFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new BuildMuscleMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new BuildMuscleWorkoutPlan();
        }
    }
}