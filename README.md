## Opis projektu
Celem projektu jest stworzenie:
- Pierwsza aplikacja konsolowa .NET – optymalizacja problemu plecakowego.
- Testy jednostkowe dla aplikacji konsolowej.
- Graficzny interfejs użytkownika.

## Opis Klas i Metod

### Klasa `Result`
Klasa `Result` reprezentuje wynik działania algorytmu. Zawiera listę elementów (`items`), gdzie każdy element jest reprezentowany jako ciąg znaków. Konstruktor klasy przyjmuje listę liczb całkowitych i zamienia je na ciągi znaków.

### Klasa `Program`
Klasa `Program` jest klasą główną programu. Zawiera metodę `Main`, która jest punktem wejścia aplikacji. W metodzie `Main` tworzony jest obiekt klasy `Problem`, rozwiązywany jest problem plecakowy z określonymi parametrami, a następnie wywoływana jest metoda `SeeResult` dla wyświetlenia wyników.

### Klasa `Problem`
Klasa `Problem` reprezentuje problem plecakowy. Zawiera ona metody do rozwiązania problemu, sprawdzania dopasowania elementu (`IsFitting`), obliczania wyniku (`Solve`), pobierania wyników (`getresults`) oraz wyświetlania wyników (`SeeResult`). Konstruktor klasy inicjalizuje listę elementów na podstawie określonej liczby i losowo generuje ich wagi i wartości.

### Klasa `Item`
Klasa `Item` reprezentuje pojedynczy element, który może być umieszczony w plecaku. Zawiera ona pola przechowujące wagę, wartość oraz stosunek wartości do wagi. Konstruktor klasy inicjalizuje te wartości na podstawie podanych parametrów.
## Gui

### Metoda `button1_Click`
Metoda `button1_Click` jest obsługą zdarzenia kliknięcia przycisku na interfejsie użytkownika. Po kliknięciu przycisku:
- Lista `listBox2` zostaje wyczyszczona.
- Z pola tekstowego `textBox1` pobierana jest liczba i przekształcana na typ całkowity (`int`).
- Z pola tekstowego `textBox2` pobierany jest ziarno losowości i przekształcany na typ całkowity (`int`).
- Z pola tekstowego `textBox3` pobierana jest pojemność plecaka i przekształcana na typ całkowity (`int`).
- Tworzony jest obiekt klasy `Problem` z wykorzystaniem pobranych danych.
- Rozwiązywany jest problem plecakowy poprzez wywołanie metody `Solve` na obiekcie problemu, przy użyciu pobranej pojemności.
- Wynik jest wyświetlany na interfejsie użytkownika poprzez dodanie elementów do listy `listBox1`:
  - Ciąg znaków reprezentujący elementy plecaka jest dodawany jako pojedynczy element listy `listBox1`.
  - Łączna wartość elementów plecaka jest dodawana do listy `listBox1`.
  - Łączna waga elementów plecaka jest dodawana do listy `listBox1`.
- Wyniki dla poszczególnych elementów plecaka są dodawane do listy `listBox2` poprzez iterację przez zwrócone wyniki z metody `getresults` na obiekcie problemu.

## Testy Jednostkowe
Namespace `TestProject` zawiera testy jednostkowe, które sprawdzają poprawność działania różnych funkcji i zachowań klasy `Problem`.

#### Testy Metod Klasy `Problem`
- `TestAtLeastOneItemFits`: Testuje, czy przynajmniej jeden element mieści się w plecaku. Tworzony jest problem plecakowy z określoną pojemnością, a następnie sprawdzane jest, czy wynikowa lista elementów nie jest pusta.
  
- `TestNoItemFits`: Testuje, czy w przypadku braku elementów możliwych do umieszczenia w plecaku, lista wynikowa jest pusta. Tworzony jest problem plecakowy z zerową liczbą elementów, a następnie dodawany jest element o wadze i wartości. Po rozwiązaniu problemu, sprawdzane jest, czy lista wynikowa jest pusta.
  
- `TestItemOrderDoesNotAffectSolution`: Testuje, czy kolejność elementów nie wpływa na rozwiązanie problemu plecakowego. Tworzone są dwa problemy plecakowe z różnymi kolejnościami elementów, ale takimi samymi wagami i wartościami. Po rozwiązaniu obu problemów, porównywane są listy wynikowe, czy są takie same.
  
- `TestSpecificInstanceSolution`: Testuje konkretne rozwiązanie problemu plecakowego dla określonej instancji. Tworzony jest problem plecakowy z określoną pojemnością, a następnie sprawdzane jest, czy uzyskane rozwiązanie ma oczekiwaną łączną wartość.
  
- `TestCapacityZero`: Testuje zachowanie programu, gdy pojemność plecaka wynosi zero. Tworzony jest problem plecakowy z określoną pojemnością, a następnie sprawdzane jest, czy lista wynikowa jest pusta.
  
- `TestNegativeCapacity`: Testuje obsługę wyjątku w przypadku ujemnej pojemności plecaka. Tworzony jest problem plecakowy, a następnie oczekiwane jest zgłoszenie wyjątku `ArgumentException` w wyniku próby rozwiązania problemu z ujemną pojemnością.
  
- `TestNullItemsList`: Testuje obsługę wyjątku w przypadku próby rozwiązania problemu z pustą listą elementów. Tworzony jest problem plecakowy, a następnie lista elementów ustawiana jest na wartość `null`. Oczekiwane jest zgłoszenie wyjątku `NullReferenceException` w wyniku próby rozwiązania problemu z taką listą.
