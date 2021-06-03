# Proiect_SIA_TEAI_QA_Laborator

Salut ! Proiectul a fost realizat de catre studentii de la SIA11- Teodorescu Alexandru, Cîrșmar Daniel și Ghimp Sergiu. 
Programul efectueaza teste pe site-ul Emag. Prin teste am depistat si doua bug-uri a interfeței aplicatiei web.
Printre teste se numara:
1. Test pentru login cu succes (prin unele locuri vei intalni si Thread.Sleep-uri de un minut, pe care le-am pus ca sa 
   am timp sa rezolv capcha-urile Emag la fiecare Login....groaznic).
2. Test pentru login cu parola gresita.
3. Test pentru editarea datelor personale.
4. Test pentru editarea datelor personale cu un numar de telefon invalid.
5. Test pentru editarea datelor personale cu o data de nastere invalida (aici am descoperit faptul ca daca pun din select de ex. 31 februarie
   si dau click pe butonul save, nici nu face save, dar nici nu se afiseaza vreun mesaj de avertizare pt introducerea unor date eronate).
6. Test pentru editarea Nickname-ului (aici am descoperit inca un bug...in momentul in care schimb nickname-ul, initiala lui trebuie sa
   fie vizibila pe pagina de date personale intr-un cerc mare, prin stanga, si la fel si in navbar, intr-un cerc mai micut. In momentul
   in care schimb nickname-ur si accesez din nou datele personale, se face refresh cu initiala in cercul mare, dar in cerculetul din
   navbar, ramane initiala nickname-ului de dinainte).
7. Test pentru adaugarea unei noi adrese de livrare.
8. Test pentru editarea unei adrese de livrare.
9. Test pentru stergerea unei adrese de livrare.

Proiectul respecta toate cerintele impuse in mesajul de pe Teams (POM, WebElements diverse, wait-uri explicite etc.). 

Va multumim !
Cu respect,
Studentii de la SIA11- Teodorescu Alexandru, Cîrșmar Daniel și Ghimp Sergiu.
