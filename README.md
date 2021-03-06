## Naziv Teme:Smart School System

## Tim9-Fera
Članovi Tima:
  1. Amar Feraget
  2. Irfan Duzan
  3. Emira Haseljić
  
## Opis Teme

Cilj ovog projekta je da roditelji budu upućeniji u aktivnosti svoga djeteta u školi, ovaj sistem se može prilagoditi i za osnovne škole ali je prvenstveno namijenjen za srednje škole. Glavna svrha sistema je ta što bi roditelji bili u toku sa školskim aktivnostima svoga djetea. Znamo da djeca ne govore sve roditeljima zato smo došli na ideju da kreiramo ovako nešto. Prilikom upisa djeteta u školu administrator sistema bi unosio njegove podatke i dodavao ga u sistem i jedini on bi imao pravo da mijenja podatke ili briše u potpunosti pojedinog učenika iz sistema, dalje bi administrator sistema kreirao korisničke naloge za roditelje i nakon toga bi roditelji mogli da se logiraju sa tim nalogom na mobilnom uređaju i da imaju uvid u sljedeće stvari: ocjene, izostanke(opravdane i neopravdane), koje predmete njihovo dijete sluša i vladanje. Roditelji bi imali mogućnost da promjene naknadno lozinku. Obavještenja u vidu notifikacija bi bilo korišteno za slanje svih važnih obavještenja, a bila bi i opcija da se šalje na e-mail kao što su: obavještenje o roditeljskim sastancima, poziv roditelja na razgovor. Koristili bi RFID readere tako da svaki učenik dobije karticu i prilikom dolaska i odlaska iz škole skenira karticu. 

## PROCESI
* Registrovanje/editovanje/brisanje podataka o učenicima
Administrator sistema bi unosio potrebne podatke i tako dodavao novog učenika prilikom njegovog upisa u školu, također bi mogao editovat podatke o postojećem učeniku ili brisat.
* Prijava u sistem
Roditelji se logiraju sa dobijenim pristupnim podacima od strane administratora.
* Odjava/Log out iz sistema
Ako nema aktivnosti na aplikaciji za određeno vrijeme aplikacija bi se automatski izlogirala
* Izbor roditelja za koje dijete želi da prikaže informacije
U slučaju da roditelj ima više djece koja idu u istu školu mogao bi birati za koje dijete želi da prikaže informacije
* Pretraga Administartora
Admin će moći pretrazivat sve učenike po više parametara
* Registrovanje dolaska i odlaska preko kartica
Provjeravalo bi se kojem učeniku pripada kartica i čuvalo bi se u bazi podataka vrijeme njegovog dolasak i odlaska

## FUNKCIONALNOSTI
* Mogućnost registracije novih učenika 
* Mogućnost editovanja podataka o postojećim učenicima 
* Mogućnost  brisanja postojećih učenika 
* Mogućnost kreiranja korisničkog naloga za roditelje
* Mogućnost pretraga učenika 
* Logiranje roditelja sa korisničkim nalogom
* Mjenjanje početne lozinke od strane roditelja za svoj korisnički nalog
* Registrovanje dolaska i odlaska učenika pomoću RFID readera i kartica
* Prikaz svih podataka roditelju za njegovo dijete
* Pretraga roditelja za koje dijete želi da prikaže informacije ako ima više djece

## Akteri
1. Administartor sistema
Osoba koja bi jedina imala pravo da dodaje učenike, briše učenike i editoje već postojeće učenike.Kod nas je to pedagog u školi. Pored ovog ta osoba bi kreirala korisničke naloge za roditelje.Također bi imalo pravo da pretražuju učenike po više paramerara kao što su ime, prezime, razredu.
2. Učenici
Mora koristiti kartice pri ulasku i izlasku iz škole
3. Roditelji
Imali bi pravo uvida za sve gore navede stavri za svoje dijete i mogli bi mjenjati lozinku za svoj korisnički nalog
4. Profesori
Pravo unosa podataka za učenike kojima predaje, sazivanje roditeljskih i slanje obavještenja roditeljima 
