using Composite;

var subteam1 = new Team();
subteam1.Add(new Truck());
subteam1.Add(new Human());

var subteam2 = new Team();
subteam2.Add(new Human());
subteam2.Add(new Human());

var team = new Team();
team.Add(subteam1);
team.Add(subteam2);

team.Deploy();