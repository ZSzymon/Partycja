# Game_project


!!!!!!!!!!!!!Dodałam do projektu z package manager'a w tej kolejności: "High definition RP" i "Shader Graph" !!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 


Uwaga od tej chwili większość materiałów podstawowych z unity nie zadziała(różowe tekstury), trza tworzyć nowe ^^^ Jak będą jakieś problemy to jestem w stanie to przerobić.

UWAGA 2 Masywana poprawa cieniowania i postprocessing itp


Zanim zaimportujesz menu to wrzuć cokolwiek z textMeshPro i zaktualizuj.




---------foldery----------
Assety z modelami, które dodałeś do menu są w "Models",tak samo dźwięk dałam do "audio", zostawiłam na w Assets tylko te assety, których nie da się zakwalifikować konkretnie typu "standard assets" 



Modele/Animacje


Assets/Models/ i tu podzial wg folderow np.Player lub Weapon -modele i jeśli potrzeba Animator Controler/ głębiej folder Animations



Prefaby bez podziału na foldery, ale dałam tam folder Weapon bo może będzie więcej broni
Jak jest czegoś sporo to najlepiej folder zrobić


Assets/Prefabs


Audio


Scenes i Scripts tam bez folderów narazie - tak jak było

--------------------------------------------------










Btw, tu piszmy komentarze/notatki, które mogą się przydać dla ogólnej wiedzy. Jeśli uważasz, że potrzebne są dwa odzielne pliki to stwórz jakiś txt i tam pisz swoje komentarze, a ja tu będę.

:)
Pls, jak coś testujesz to stwórz drugą scene/skopiuj moją, aby uniknąć jakichś konfliktów gita lub ogólnych bugów w skryptach
:)
Pozatym jak ktoś zaczyna klepać jakąś dużą mechanikę czy coś to informujmy się, żeby przypadkiem nie dublować roboty :)

!!!!!!! Iiiiii dla przypomnienia dla wszystkich !!!!!!!!!!!

Git nie lubi plików o pojemności większej niż 25mb, ale to bardziej będzie boleć przy 3d/muzyce, choć na javie nie miałam problemu z takimi rzeczami. Także jak coś wrzucamy poza skryptami/2d itp, to sprawdzamy rozmiar xD

!!!!!!!!!!! NIE MARTWIMY SIĘ BUGAMI Z KOLIZJĄ XD !!!!!!!!!!!!!!!

!!!!!!!!!! Ustawienia Unity Input'u w silniku i kodzie (nazwy, które nie są "horizontal/vertical"), Jakby coś się zwaliło w ustawieniach inputu !!!!!!!!!!!!!!!!!

Ruch(do zmiany ogólne działanie) i camera na klawiaturze+mysz działa(jest automatycznie podpięta w unity)

Xbox:

B - Dodge

Rb- Attack1

Menu(opcje prawy przycisk)-Options

!!!!!!!!!! Ubogi GDD / ogólny plan !!!!!!!!!!!!

Poniżej moje wyobrażenie planu xD Jak coś chcesz zmienić/dopowiedzieć itp, jestem otwarta na pomysły, ale wolałabym zostać przy tym settingu bo nie muszę wiele klepać grafiki skomplikowanej+animacje (pozatym zawsze można walnąć minducka fabularnego i zrobić setting z lovecrafta na końcu xD). Jak coś masz do ugadania w związku z mechaniką/gameplayem proszę bardzo, możemy coś zmieniać/podyskutować :) .

Setting/fabuła? : Przechodzisz świat podziemny/zaświaty, normalnie jest bodajże 12 etapów, wypełnionych portalami/drzwiami i strażnikami, robimy 1 lvl. I jak mówię da się wrzucić pod to lovecrafta, a dokładnie Nyarlathotep'a, ale to już w razie potrzeby mindfucka czy fabuły.

Plan jest taki, że narazie jeden przeciwnik (na tę chwilę będę robić model wężoczłeka zombi, z nożami/kopeszem(chepeszem), jeśli animacje będą bardzo złe w moim wykonaniu to mam darmowe do ataku pięściami :) ) w kilku wersjach jeśli dam radę graficznie, a jak nie to jeden zespawnowany kilka razy na mapie. Jak zdążymy i zrobię grafikę to boss. Walka soulsowa, czytaj: stamina. Narazie ogarniaczamy się do jednej broni/postaci, jak starczy czasu i chęci to można coś dorzucić (magia/broń dystansowa).Początkowo sam atak i unik, a potem moooożna dodać parowanie/blok czy coś, ale czas i algosy lecą :) . Animacje załatwię darmowe, lub jak nie będzie mogę coś zrobić(raczej drewniane xD). Jeśli chodzi o mapę to: 1 lvl z punktem końcowym (portal/drzwi), z bossem lub bez na końcu. Pozatym byłoby to jezioro/morze ognia i to wszystko zapewne umieszczone w jaskinii. Kwestie lvl designu proponuję ogarnąć na koniec jak się wszystko potestuje i będzie grafika(kamienie już mam).

Jeśli potrzeba jakiegoś wglądu do designu itp.

http://www.touregypt.net/featurestories/hell.htm

https://en.wikipedia.org/wiki/Gate_deities_of_the_underworld

Możliwy Boss?

https://pl.wikipedia.org/wiki/Set_(b%C3%B3g)

lub (jest kilka jego postaci do wyboru) 

https://lovecraft.fandom.com/wiki/Nyarlathotep
