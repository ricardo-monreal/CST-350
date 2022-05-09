// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using Microsoft.Extensions.DependencyInjection;
using VideoGameDependencyInjectionCore;

//HeroThatOnlyUsesSwords hero1 = new HeroThatOnlyUsesSwords("Solaire");

//hero1.Attack();
//Console.WriteLine();

//HeroThatCanUseAnyWeapon hero2 = new HeroThatCanUseAnyWeapon("Eregon", new Sword("brissinger"));
//hero2.Attack();
//Console.WriteLine();

//HeroThatCanUseAnyWeapon hero3 = new HeroThatCanUseAnyWeapon("The Joker", new Grenade("The Pineapple"));
//hero3.Attack();
//Console.WriteLine();


//HeroThatCanUseAnyWeapon hero4 = new HeroThatCanUseAnyWeapon("GI Joe", new Gun("Six shooter",
//new List<Bullet> { 
//    
//}));
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();
//hero4.Attack();

// -------------------- Activity 7: Part 2 -------------------------- // 

ServiceCollection services = new ServiceCollection();

// all new weapons will now be Grenades by default
//services.AddTransient<IWeapon, Grenade>(grenade => new Grenade("Exploding Pen"));
//services.AddTransient<IWeapon, Sword>(s => new Sword("The Sword of Gryffindor"));
services.AddTransient<IWeapon, Gun>(g => new Gun("Six Shooter",
    new List<Bullet> { 
    new Bullet("Silver Slug", 10),
    new Bullet("Lead Ball", 20),
    new Bullet("Rusty Nail", 3),
    new Bullet("Hollow Point", 5)
    }));


// all new heroes will be 'Jonny' by default. 
services.AddTransient<IHero, HeroThatCanUseAnyWeapon>(hero => new HeroThatCanUseAnyWeapon("Jonny English", hero.GetService<IWeapon>() )
);
// sort of a "compile" step to assemble everyting listed above
ServiceProvider provider = services.BuildServiceProvider();


// implementation
// based on all of the configuration above, we can create a new hero in one, small step
var hero5 = provider.GetService<IHero>();

hero5.Attack();
Console.WriteLine();

Console.ReadLine();
