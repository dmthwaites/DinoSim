// See https://aka.ms/new-console-template for more information

using DinoSim.Shared.ProgramManagers;

Console.WriteLine("Hello, World!");

var SimRunner = new SimRunner();
await SimRunner.Run(10);