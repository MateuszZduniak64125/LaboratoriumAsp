https://github.com/MateuszZduniak64125/LaboratoriumAsp



Część B. Podgląd HTTP w przeglądarce

Pytanie                                                                Odpowiedź
-------------------------------------------------------------------------------------------------------------------------------------
Metoda żądania                                                         GET

Kod statusu odpowiedzi                                                 200 OK

Content-Type odpowiedzi                                                text/html; charset=utf-8

Nagłówek User-Agent żądania                                            Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 
                                                                       (KHTML, like Gecko) Chrome/154.0.0.0 Safari/537.36 Edg/154.0.0.0

Ile żądań wykonała strona łącznie i dlaczego więcej niż jedno?         8, ponieważ każdy element podpięty na stronie wysyła osobne 
                                                                       żądanie



Pytanie: Co się stanie po ?a=x w /Book/Sum?
Odpowiedź: Konwersja tekstu "x" na int się nie udaje. Parametr "a" przyjmuje wartość domyślną 0, błąd trafia do ModelState, a akcja wykonuje się dalej i zwraca wynik z zerem.

Pytanie: Jaki jest kod statusu po ?a=x i dlaczego?
Odpowiedź: 200 OK. Nie przerywa działania metody i nie zwraca automatycznie błędu 400 Bad Request.

Pytanie: Dlaczego nagłówek w Book/Health to Content-Type: application/json?
Odpowiedź: Metoda Json() zwraca JsonResult, który serializuje obiekt do JSON i automatycznie ustawia nagłówek application/json; charset=utf-8.
