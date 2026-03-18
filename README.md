 APBD CW1 – Git i GitHub

1. Kiedy Git wykonuje fast-forward, a kiedy powstaje merge commit?
- Fast-forward: gdy gałąź docelowa (`main`) nie ma własnych commitów od momentu utworzenia gałęzi
- Merge commit: gdy gałąź docelowa ma własne niezależne commity

2. Czym w praktyce różni się merge od rebase?
- Merge: łączy historię gałęzi, czasem tworząc dodatkowy commit merge; historia nie jest liniowa.  
- Rebase: przesuwa commity na górę innej gałęzi, tworząc liniową historię; nie tworzy merge commitów.

 3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
- Konflikt został wymuszony w gałęzi `feature-conflict2`.  
- Zmodyfikowano ten sam fragment w `main` i `feature-conflict2`.  
- Po merge ręcznie połączono oba komunikaty i commit został zatwierdzony.
