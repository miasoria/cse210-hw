// --- EXCEED REQUIREMENTS: Capture the mood ---
public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";
    public string _mood = "";

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Estado de Ánimo: {_mood}");
        Console.WriteLine($"Indication: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine("----------------------------------------");
    }
}