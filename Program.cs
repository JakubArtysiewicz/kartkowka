using System.Text.Json;

class program{
    static void Main(){
        // Console.WriteLine(pola());
        // Console.WriteLine(kalkulator());
        // Console.WriteLine(zmianatemperator());
        srednia();
        
    }
    // 1) Obliczanie pola prostokąta, kwadratu, trapezu.
    // Napisz program w C#, który pobierze od użytkownika potrzebne dane, a następnie obliczy i wyświetli
    // pole prostokąta, kwadratu i trapeza. Użytkownik najpierw powinien podać co chce obliczyć za
    // pomocą if’a lub switch’a.
    static double pola(){
        Console.WriteLine("Co chcesz obliczyć Kwardrat/prostokąt - 1, trapez - 2");
        string odp = Console.ReadLine();
        if(odp == "1"){
            Console.WriteLine("Wpisz a:");
            double ab = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz b:");
            double ba = double.Parse(Console.ReadLine());
            return(pole_kwadratu(ab,ba));
        }
        if(odp == "2"){
            Console.WriteLine("Wpisz a:");
            double ab = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz b:");
            double ba = double.Parse(Console.ReadLine());
            Console.WriteLine("Wpisz h:");
            double h = double.Parse(Console.ReadLine());
            return(pole_trapezu(h,ab,ba));
        }
        else{
            return 0;
        }
    }
    static double pole_kwadratu(double a,double b){
        return (a*b);
    }
    static double pole_trapezu(double h, double a, double b){
        return ((a*b)/2)*h;
    }
    // 2) Prosty Kalkulator.
    // Napisz program w C#, który pobierze od użytkownika dwie liczby i wykonuje jedno z prostych działań
    // matematycznych, takich jak dodawanie, odejmowanie, mnożenie lub dzielenie. Wyświetl wynik na
    // ekranie.
    static double kalkulator(){
        double wynik = 0; 
        // Console.WriteLine("+,-,/,*");
        string zapytanie = Console.ReadLine();
       
            double liczba1 = double.Parse(zapytanie[0].ToString());
            double liczba2 = double.Parse(zapytanie[2].ToString());

        if(zapytanie[1].ToString()=="*"){
            wynik = liczba1 * liczba2;
        }
        if(zapytanie[1].ToString() == "/"){
            wynik = liczba1 / liczba2;
        }
        if(zapytanie[1].ToString()=="+"){
            wynik = liczba1 + liczba2;
        }
        if(zapytanie[1].ToString() == "-"){
            wynik = liczba1 - liczba2;
        }
        
        return wynik;
    }
    static double zmianatemperator(){
        Console.WriteLine("Wpisz ilosc:");
        double wynik = double.Parse(Console.ReadLine());
        Console.WriteLine("Wpisz jednostki(F/C):");
        string jednostki = Console.ReadLine();
        if(jednostki == "C"){
            wynik = (wynik * 9/5) + 32;
            return wynik;
        }
        else if(jednostki == "F"){
            wynik = (wynik - 32) * (5/9);
            return wynik;
        }
        else{
            return 0;
        }

    }
    static void Podzielne35(){
        Console.Write("Wpisz a: ");
        double a = double.Parse(Console.ReadLine());
        if(a%3==0 && a%5==0){
            Console.WriteLine("Tak");
        }
        else{
            Console.WriteLine("Nie");
        }
    }
     static void BMI(){
        Console.Write("Wpisz wysokość: ");
        double ws = double.Parse(Console.ReadLine()); 
        Console.Write("Wpisz waga: ");
        double wag = double.Parse(Console.ReadLine());
        Console.WriteLine(wag/((ws/100)*(ws/100)));
    }
    static void srednia()
    {
    List<double> numbers = new List<double>();
        string input;
        Console.WriteLine("Wprowadź liczby do obliczenia średniej arytmetycznej.");
        Console.WriteLine("Aby zakończyć wprowadzanie, wpisz 'koniec'.");

        while (true)
        {
            Console.Write("Wprowadź liczbę: ");
            input = Console.ReadLine();

            if (input.ToLower() == "koniec")
                break;

            if (double.TryParse(input, out double number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Proszę podać poprawną liczbę.");
            }
        }
        if (numbers.Count > 0)
        {
            double average = 0;
            foreach (var num in numbers)
            {
                average += num;
            }
            average /= numbers.Count;
            Console.WriteLine($"Średnia arytmetyczna wynosi: {average}");
        }
        else
        {
            Console.WriteLine("Nie wprowadzono żadnych liczb.");
        }
    }
}