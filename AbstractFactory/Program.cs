using AbstractFactory;

var homePage = new HomePage();
homePage.SetGoal(new BuildMuscleFactory());