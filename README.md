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
