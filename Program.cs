// ReadMe til "Spare Parts Inventory Assistant"
// Dette program bruges til vare på lagerstatus for reservedelene på dette lager
//
// Programmet følger denne opbygning:
// 1. Starter med en velkomstbesked.
// 2. Jeg opbygger en liste af dele på lageret (hydraulic pump, PLC module, servo motor).
// 3. Jeg starter et loop der spørger brugeren om hvilken del de ønsker.
// 4. Hvis inputtet matcher en del på lageret -> Så bekræftes og afsluttes.
// 5. Hvis input ikke matcher -> gives besked om der ikke er det på lager,
//    men giver liste med lagervarer, og spørger brugeren om hvilken del de ønsker.
// 6. Hvis brugeren spørger specifikt om lagerstatus -> svar med antal og navne.
//    Genkendes spørgsmålet ikke vises liste med lagervarer.
// 7. Programmet stopper kun, når en del er fundet.
//
// Programmet er case-sensitive og kræver derfor korrekt stavning.

using System;

class Program
{
    static void Main()
    {
        string[] parts = { "hydraulic pump", "PLC module", "servo motor" };

        Console.WriteLine("Hej. Velkommen til reservedelslageret!");

        while (true)
        {
            Console.WriteLine("Hvilken del ønsker du?");
            string input = Console.ReadLine();

            // Tjek om input matcher en reservedel
            bool found = false;
            foreach (string part in parts)
            {
                if (input == part) // exact match
                {
                    Console.WriteLine($"Jeg har {part} på lager til dig her!");
                    found = true;
                    break;
                }
            }

            if (found)
                break; // afslut programmet

            // Special-forespørgsler
            if (input == "Har du overhovedet noget på lager?" ||
                input == "Er der overhovedet noget på lager?")
            {
                Console.WriteLine($"Vi har {parts.Length} på lager!");
                foreach (string part in parts)
                {
                    Console.WriteLine(part);
                }
                continue;
            }

            // Hvis ikke fundet
            Console.WriteLine($"Jeg er bange for vi ikke har {input} på lager");
            Console.WriteLine("Men her er listen over hvad vi har på lager: Kan du bruge det?");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}
