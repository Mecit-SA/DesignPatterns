namespace AbstractFactory
{
    class WeightLossFactory : IGoalFactory
    {
        public IMealPlan CreateMealPlan()
        {
            return new WeightLossMealPlan();
        }

        public IWorkoutPlan CreateWorkoutPlan()
        {
            return new WeightLossWorkoutPlan();
        }
    }
}