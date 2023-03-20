// See https://aka.ms/new-console-template for more information
using Funcionalidad2__GetStaircase;

List<string> listAgents = new List<string>() { "A", "B", "C" };
string agent;
int size = 0;

Console.WriteLine("Seleccione A) Agente A. B) Agente B. C) Agente C: ");
agent = Console.ReadLine();
if (listAgents.Exists(a => a == agent.ToUpper()))
{
    Console.WriteLine("Ingrese el tamaño de lista de números (debe ser mayor a 0 y menor o igual a 100): ");
    int.TryParse(Console.ReadLine(), out size);
    if (size > 0 && size <= 100)
    {
        
        Console.WriteLine("El agente seleccionado " + agent.ToUpper() + ", usó el metodo: " + new Staircase().ResultMethod(agent.ToUpper()) + ", y su resultado es: " );
        new Staircase().GetStaircase(agent.ToUpper(), size);
    }
    else
    {
        Console.WriteLine("No elegiste un tamaño válido.");
    }
}
else
{
    Console.WriteLine("No elegiste un agente válido.");
}

