namespace AbstractFactory
{
    interface IGoalFactory
    {
        IMealPlan CreateMealPlan();
        IWorkoutPlan CreateWorkoutPlan();
    }
}