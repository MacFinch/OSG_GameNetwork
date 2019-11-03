Dokument założycielski grupy OSG

Wstęp

Niniejsza grupa została zainicjowana podczas pierwszych ćwiczeń z Systemów Operacyjnych na pierwszym roku studiów zaocznych z informatyki na Uniwersytecie Ekonomicznym w Katowicach. Chcąc zainspirować studentów do samodzielnego przyjrzenia się systemom operacyjnym jako narzędziom do rozwiązywania konkretnych i realnych problemów w środowisku businessowym, profesor Artur Machura poprosił studentów o samodzielne podzielenie się na 2-3 osobowe grupy oraz wymyślenie sobie projektu, którego realizacja wymaga fachowej pracy z wyselekcjonowanym pod kątem projektu Systemem Operacyjnym.

Wykorzystując to zdanie jako preteks studenci – Jarosław W. Zięba, Łukasz Ponikowski, – postanowili podjąć się nieco ambitniejszego projektu niż wymagany, aby móc przy okazji rozwinąć inne cenne umiejętności, którymi mogą być zainteresowani potencjalni pracodawcy. Celem jest wykształcić skillset, który umożliwi wszystkim członkom grupy zdobycie entry level position w branży przed rozpoczęciem drugiego roku studiów.

Wszystkim potencjalnym pracodawcom, którzy czytają niniejszy dokument, serdecznie dziękujemy za poświęcony czas, oraz wyrażamy nadzieje, że analiza naszego repozytorium pomoże państwu znaleźć człowieka, którego szukacie.


O projekcie

Niektóre z podjętych decyzji odnośnie technologii używanych do realizacji niniejszego projektu mogą wydać się nieintuicyjne lub wręcz błędne z punktu widzenia obowiązujących w branży standardów. Najbardziej rzucającym się w oczy przykładem będzie zapewne decyzja o implementacji back-end w C#.Net core pomimo faktu korzystania z systemu RHEL. Tak samo wątpliwości może rodzić sama struktura projektu.

Decyzje te wynikają jednak z faktu, że prawdziwym projektem nie jest opisywany tu projekt. To co w całym tym dokumencie nazywamy projektem poza tym akapitem, jest tak naprawdę narzędziem do realizacji projektu nadrzędnego, którego opis brzmi w następujący sposób: zaliczyć ćwiczenia z Systemów Operacyjnych, zdać studia, zdobyć cenione na rynku umiejętności. Z tego powodu nasz projekt musi się zdawać czymś odwrotnym do tego, czego należałoby się spodziewać: funkcjonalność naszego projektu jest wymuszana przez technologie, a nie technologia dobierana tak, aby jak najlepiej spełniać wymagania funkcjonalność. Wynika to z faktu, że znajomość pewnych technologii jest wymuszana przez program studiów (C#.Net, Unix etc), inne zaś zdają się być przydatne do uzyskania przewagi konkurencyjnej na rynku pracy (np. Test Driven Development, Git etc). Dlatego też nasz projekt może wydawać się błędnie zdefiniowany, a technologie wybrane w sposób losowy. 


Opis projektu

Nasz projekt polega na stworzeniu aplikacji server-client, która umożliwiać będzie użytkownikom granie z innymi graczami przez internet w następujące gry: Kółko krzyżyk, kółko krzyżyk bez granic, piłka nożna na papierze, pong, tetris na dwie osoby w trybie kooperacji. Logika każdej gry zaimplementowana będzie po stronie serwera, co oznacza, że gry nie będą działać bez połączenia z internetem, ale za to implementacja po stronie klienta będzie szybsza w produkcji. 

Gry będą implementowane w kolejności od najmniej skomplikowanej logicznie do najbardziej (kółko krzyżyk można zaimplementować bez interfejsu graficzne w pierwszych wersjach roboczych, a terris wymaga już nie tylko grafiki, ale także opracowania algorytmów maskujących ewentualne spadki w prędkości połączenia). 

Elementy takie jak rankingi, auto parowanie graczy o podobnych umiejętnościach, możliwość analizy rozegranych w przeszłości rozgrywek, podglądanie gier innych graczy i tym podobne mogą zostać zaimplementowane w dowolnym momencie pracy, jednakże nie muszą: może się okazać, że potrzebne do ich implementacji technologie nie są nam bezpośrednio potrzebne, a nadmiar zadań  na uniwersytecie może nam nie dać komfortu zaimplementowania wszystkich wartych implementacji funkcjonalności.

Strona serwerowa aplikacji zaimplementowania zostanie przy pomocy C#.Net Core. Aplikacje klienckie zostaną zaimplementowana w następujących technologiach: Unix/Mac – Python, Windows – Python, przeglądarka internetowa – JS. Jeżeli czas pozwoli to istnieje możliwość, że aplikacje będzie równie zaimplementowana na systemie iOS.

Cel minimalistyczny należy uznać za osiągnięty w momencie, w którym uda nam się uruchomić aplikacje pozwalającą na grę w kółko krzyżyk przez internet z użytkownikami innych systemów, umożliwiający jednoczesną obsługę 128 połączeń do serwera – 64 gry naraz.  

Celem maksymalistycznym jest zaś implementacja wszystkich proponowanych gier z opcjonalnymi funkcjonalnościami oraz ich deployment na wybrane platformy oraz zaimplementowanie reklam w aplikacji.

Specyfikacja gier
  1. TicTacToe (kółko-krzyżyk):
  
  	Gra turowa na dwie osoby. 
  	Gracze losują figur (krzyżyk lub kółko).
	Grę zaczyna krzyżyk zajmując jedno z pól na matrycy 3x3.
  	Gracze ruszają się naprzemiennie aż do:
	  	Ułożenia 3 takich samych figur w linii (wiersze, kolumny, diagonalne), co oznacza zwycięstwo.
		Wyczerpania pól, co oznacza remis. 


Struktura organizacyjna

W skład naszego zespołu wchodzą dwie osoby:

1. Jarosław Zięba. Początkujący programista języka Python, aspirujący do zostania developerem pracującym nad rozwojem i implementacją nowoczesnych technologii Sztucznej Inteligencji. Podczas rozwoju tego projektu chciałby rozwinąć swoje umiejętności programistyczne (Python, C#), nauczyć się pracować w grupie nad realnym problemem, SQL, a także zdobyć niezbędną wiedzę i umiejętności do pracowania na systemie operacyjnym z rodziny Unix/Linux zarówno po stronie serwera jak i jako workstation.

2. Łukasz Ponikowski. Programista stawiający swoje pierwsze kroki, aspirujący do zostania Web developerem. Podczas realizacji projektu chciałby zdobyć umiejętność programowania w C# oraz JS, opanować SQL, protokowy komunikacji server-client (http, TCP), oraz administracji serwerem.

Biorą pod uwagę umiejętności oraz aspirację członków zespołu struktura organizacyjna wyglądać będzie, jak następuje:

Jarosław Zięba: Projekt manager, developer, zarządzanie serwerem aplikacji, produkcja aplikacji desktopowej, pomoc przy rozwijaniu serwera baz danych, rozwój głównego serwera, specjalista od protokołu TCP.

Łukasz Ponikowski: Specjalista od baz danych, developer, zarządzanie serwerem baz danych, produkcja aplikacji przeglądowej, rozwój serwera baz danych, pomoc przy rozwijaniu serwera głównego, specjalista od protokołu HTTP.


Metodologia pracy

1. Pracujemy w metodologii Test driven development, czyli najpierw implementujemy testy, a potem funkcje i klasy spełniające te testy. W ten sposób podczas powiększania funkcjonalności będziemy zawsze wiedzieć czy inny fragmenty kodu się nie wysypują: tak długo jak działają stare testy to musi tez działać stara funkcjonalność, nawet jeśli została zaimplementowana nowa. 
2. Działamy przy założeniu, że każdy malutki projekcik ma realizować jakąś działająca cześć systemu zamiast starać się od razu robić duże skoki robić. 
3. Od momentu stworzenia pierwszego działającego testu pracować będziemy z tygodniowym development circle, czyli co tydzień wypuszczana będzie poprawiona działająca wersja, a także co tydzień odbywać będzie się spotkanie mające na celu sporządzenia raportu postępu oraz opracowanie wytycznych odnośnie prac na następne tygodnie.
4. Funkcjonalność implementowana będzie w takiej kolejności, w jakiej dane technologie, koncepcje pojawią się podczas nauki na studiach z poszanowaniem generalnego rozwoju projektu.
5. Do zarządzania wersjami używać będziemy technologii git z platformą github.
6. Członkowie grupy zobowiązują się także zawsze służyć pomocą przy nauce potrzebnych zagadnień innym członkom grupy.
