namespace AbstractFactory
{
    class HomePage
    {
        public void SetGoal(IGoalFactory factory)
        {
            Console.WriteLine(factory.CreateMealPlan());
            Console.WriteLine(factory.CreateWorkoutPlan());
        }
    }
}