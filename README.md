<div id="container" style="white-space:nowrap">

  <div id="image" style="display:inline float: right;">
        <img style="float: left;" src="./AddFiles/C%23_logo.png" alt="drawing" width="8%"/>
  </div>

  <div id="texts" style="display:inline; white-space:nowrap; float: right;"> 
        <h1>C#-Grundlagen</h1>
        <h3>Arbeitsauftrag zu if-else(if) und switch-case-Anweisungen</h3>
</div>

## :dart: Zielsetzung

Dieser Auftrag hat folgende Ziele:

+ Einfache Programmierprobleme nutzen, um die in den Modulen 1, 2, 3 und 4 behandelten Themen zu Vertiefen
+ Üben ein Problem in kleinere Teilprobleme zu zerlegen
+ Üben Informationen zu Recherchieren, die nicht explizit in der Aufgabenstellung genannt werden
+ Üben Sie das Erstellen, Klonen und Einreichen von Aufträgen über Visual Studio 2022 und GitHub

##  :school_satchel: Skills

+ Zerlegung eines Problems in eine Folge einfacher Aufgaben oder Berechnungen
+ Nutzung des Internets, um Informationen oder Formeln zu finden, die zur Lösung von Programmieraufgaben benötigt werden
+ Verwendung von Zuweisungs-Workflow-Schritten

## :bulb: Benötigtes Wissen
+ Konsolenausgabe formatieren und Daten über die Konsole einlesen
+ Verwendung und Konvertierung von Variablen mit unterschiedlichen Datentypen
+ Verarbeitung von Variablen und Literalen durch Operatoren
+ Anweisungen unter verschiedenen Bedingungen

## :bookmark_tabs: Informationsquelle
Das Informationsmaterial zur Aufgabe finden Sie hier:   
[Programmablaufplan](./AddFiles/SAS_PAP_Info.pdf)   
[Verzweigungen in C#](./AddFiles/SAS_Verzweigungen_Info.pdf)   
[GSO-Wiki](https://github.com/GSO-SW/public_content_gso/wiki/Grundlagen-der-Sprache-C%23#25-kontrollstrukturen)

---

### Aufgabe 1: Die kleinere Zahl

Ein Programm soll den Benutzer nach zwei Zahlen fragen und anschließend das Minimum, also die 
kleinere der beiden Zahlen ausgeben. 

Beispiel 1 Ausgabe/Ergebnis:

<img src="./AddFiles/Task1_example1.jpg" width=100% >

Beispiel 2 (Gleicher Wert) Ausgabe/Ergebnis:

<img src="./AddFiles/Task1_example2.jpg" width=100% >   
     
   
> :information_source: **Hinweise**:exclamation:
> + Sie müssen die Ausgabe unter der gestrichelten Linie erzeugen
> + Sie müssen die Formatierung im Beispiel genau befolgen, um den Unittest zu bestehen
> + Beachten Sie, dass die Ausgabe **nicht** gerundet wird   
   
 ### Aufgabenstelltung
 
**a)** Fertigen Sie eine entsprechende PAP an und laden Sie diese unter der Bezeichnung "Kleinere_Zahl_PAP.png" in den Ordner AddFiles hoch.   
     :exclamation: Arbeiten Sie in Zweierteams :busts_in_silhouette:

<img src="./AddFiles/Kleinere_Zahl_PAP.png" width=50% >

**b)** Implementieren Sie das Programm in C#.   
   :exclamation: Arbeiten Sie in Einzelarbeit :bust_in_silhouette:



---
  
### Aufgabe 2: Herzinfarkt-Risiko-Test

Die Krankenkasse Halbgesund möchte ihren Mitgliedern als besonderen Service einen 
Herzinfarktrisikotest anbieten. Dazu benötigt sie ein Computerprogramm, das folgende 
medizinischen Erfahrungswerte berücksichtigt:
  
|                     | Stress        | Kein Stress|
| ------------------- |:-------------:| ----------:|
| **Übergewicht**     | 62%           | 18%        |
| **Kein Übergewicht**| 15%           | 5%         |

Anmerkung: Hat eine Person Stress **und** Übergewicht, so beträgt ihr Herzinfarktrisiko nach der 
Tabelle 62%.   

Beispiel Ausgabe/Ergebnis:

<img src="./AddFiles/Task2_example.jpg" width=100% >     
     
   
> :information_source: **Hinweise**:exclamation:
> + Sie müssen die Ausgabe unter der gestrichelten Linie erzeugen
> + Sie müssen die Formatierung im Beispiel genau befolgen, um den Unittest zu bestehen
> + Beachten Sie, dass der Benutzer die Fragen mit **true** oder **false** beantworten muss
> + Fragen Sie zuerst nach dem Übergewicht und anschließend nach dem Stress
   
 ### Aufgabenstelltung   
  
**a)** Fertigen Sie ein entsprechendes Struktrogramm an und laden Sie es unter der Bezeichnung "Herzinfarkt_Risiko_PAP.png" in den Ordner AddFiles hoch.    
  :exclamation: Arbeiten Sie in Zweierteams :busts_in_silhouette:

<img src="./AddFiles/Herzinfarkt_Risiko_PAP.png" width=50% >

**b)** Implementieren Sie das Programm in C#.   
  :exclamation: Arbeiten Sie in Einzelarbeit :bust_in_silhouette:

---

### Aufgabe 3: Rechner

Entwickeln Sie einen Zahlenrechner, der den Benutzer zuerst nach zwei Zahlenwerten und dann 
nach einer Rechenoperation fragt, mit der die beiden Zahlen zu einem auszugebenden Ergebnis 
berechnet werden sollen.

Hinweis: Die Potenz einer Zahl berechnen Sie mit der Methode 'Math.Pow()'.

    double x = Math.Pow(2,3) // x=2^3
  
Beispiel Ausgabe/Ergebnis:

<img src="./AddFiles/Task3_example.jpg" width=100% >   
     
  
> :information_source: **Hinweise**:exclamation:
> + Sie müssen die Ausgabe unter der gestrichelten Linie erzeugen
> + Sie müssen die Formatierung im Beispiel genau befolgen, um den Unittest zu bestehen
> + Lesen Sie die Eingaben des benutzers in folgender Reihenfolge ein: Zahl1, Zahl2 anschließend Auswahl
  
**a)** Fertigen Sie ein entsprechendes Struktrogramm an und laden Sie es unter der Bezeichnung "Rechner_PAP.png" in den Ordner AddFiles hoch.    
    :exclamation: Arbeiten Sie in Zweierteams :busts_in_silhouette:

<img src="./AddFiles/Rechner_PAP.png" width=50% >

**b)** Implementieren Sie das Programm in C#.   
    :exclamation: Arbeiten Sie in Zweierteams :busts_in_silhouette:

---
  
### Aufgabe 4: Arbeit einreichen

1. In Visual Studio 2022 das Fenster "Git-Änderungen" aufrufen
2. Eine kurze Beschreibung Ihrer Änderungen in die Textbox eingeben und "commit für alle" klicken
3. Mit dem Pfeil nach oben die Arbeit auf GitHub pushen.
4. Das Repository im Brower aufrufen und aktualisieren um die Änderungen zu bestätigen.
5. Im Pull-Request die Nachricht "Bereit zum Bewerten" hinterlassen, damit Ihre Lehrkraft weiss das Sie fertig sind.

---
  
# :100: Erfolgskriterien
  
+ Eingesetzten Quellcode kommentieren
+ Quellcode schreiben der lesbar ist und mit Hilfe einer logischen Folge das Problem löst
+ Programmausgabe die korrekt, lesbar und richtig formatiert ist 
