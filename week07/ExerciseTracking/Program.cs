using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de actividades
        List<Activity> activities = new List<Activity>();

        // Crear instancias de cada tipo
        Running r1 = new Running("03 Nov 2022", 30, 3.0);
        Cycling c1 = new Cycling("04 Nov 2022", 30, 6.0);
        Swimming s1 = new Swimming("05 Nov 2022", 30, 20);

        // Añadir a la lista
        activities.Add(r1);
        activities.Add(c1);
        activities.Add(s1);

        // Iterar y llamar a GetSummary (Polimorfismo en acción)
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}