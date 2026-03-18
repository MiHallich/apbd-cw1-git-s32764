1. Kiedy Git wykonuje fast-forward, a kiedy powstaje merge commit?

Fast-forward występuje wtedy, gdy gałąź main nie ma nowych commitów od momentu utworzenia gałęzi feature. W takiej sytuacji Git tylko przesuwa wskaźnik do przodu i nie tworzy nowego commita.

Merge commit powstaje wtedy, gdy obie gałęzie mają nowe commity. Git nie może wtedy wykonać fast-forward i tworzy nowy commit łączący historię.
 
2. Czym różni się merge od rebase?

Merge zachowuje pełną historię i pokazuje strukturę gałęzi. Tworzy dodatkowy commit łączący zmiany.

Rebase przepisuje historię i tworzy liniowy przebieg commitów, tak jakby wszystkie zmiany były wykonane po kolei.

3. W jaki sposób został rozwiązany konflikt?

Konflikt powstał, ponieważ ta sama linia kodu została zmieniona w dwóch gałęziach.

Rozwiązałem konflikt ręcznie, wybierając odpowiednią wersję, usuwając znaczniki konfliktu i zatwierdzając zmiany commitem.