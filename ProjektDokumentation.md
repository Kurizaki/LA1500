## Gruppe Camelia:

-Koelewijn (Projektleiter & Entwickler)

-Tuma (Grafikdesigner & Entwickler)

-Eser (Entwicklerin)

-Sacher (Entwickler)

| Datum    | Version | Zusammenfassung                                                                                                    |
| -------- | ------- | ------------------------------------------------------------------------------------------------------------------ |
| 21.02.23 | 0.0.1   | Projekt Idee und konzept des programms wurde Festgelegt. Eine erste Version von 1.1, 1.2 und 1.4 wurde bearbeitet. |
| 28.02.23 | 0.0.2   | Die Plannung wurde organisiert, die Aufgaben wurden aufgeteilt und 1.3, 2 und 3 wurden bearbeitet.                 |
| 01.03.23 | 0.03    | 1.2, 1.3, 2 und 3 wurden überarbeitet.                                                                             |

## 1 Informieren

### 1.1 Ihr Projekt

Wir haben uns dazu entschieden, einen Passwortmanager zu programmieren. Dieser verschlüsselt und speichert die Passwörter, damit sie sicher sind und man sie nicht vergessen kann. Die Passwörter und E-Mails sollen je in einem Profil gespeichert werden, welches man einzeln hervorrufen kann, damit man nicht zuerst nach den richtigen Daten suchen muss. Zudem wollen wir noch ein schönes UI machen, welches dem Benutzer das Gefühl von Sicherheit gibt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ            | Beschreibung                                                                                                                                                                                     |
| ---- | --------------- | -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| 1    | Muss            | Funktionalität | Als ein Benutzer möchte ich Profile erstellen können, damit ich mein Passwort speichern und verwalten kann.                                                                                      |
| 2    | Muss            | Funktionalität | Als ein Benutzer möchte ich in meinen Profilen Nutzername, E-Mail-Adresse und Passwort speichern können, damit ich schnell und einfach zugriff auf meine Anmeldedaten habe.                      |
| 3    | Muss            | Funktionalität | Als ein Benutzer möchte ich meine Profile speichern können, damit ich sie jederzeit abrufen und bearbeiten kann.                                                                                 |
| 4    | Muss            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, meine Profile zu bearbeiten, um meine Daten korrigieren und aktualisieren zu können.                                                          |
| 5    | Muss            | Funktionalität | Als ein Benutzer möchte ich, dass meine Daten verschlüsselt werden, um ihre Sicherheit zu gewährleisten.                                                                                         |
| 6    | Muss            | Funktionalität | Als ein Benutzer möchte ich ein benutzerfreundliches Interface haben, um schnell und einfach auf alle Funktionen zugreifen zu können.                                                            |
| 7    | Muss            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, starke Passwörter zu generieren, um meine Sicherheit zu erhöhen.                                                                              |
| 8    | Kann            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, ein Master-Passwort einzurichten, um meine Profile zu schützen.                                                                               |
| 9    | Kann            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, Sicherheitsfragen oder Sicherheitsschlüssel für das Master-Passwort zu verwenden, um das Passwort zurückzusetzen, wenn ich es vergessen habe. |
| 10   | Muss            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, ein Profil zu löschen, um alte oder nicht mehr benötigte Profile zu entfernen.                                                                |
| 11   | Muss            | Funktionalität | Als ein Benutzer möchte ich die Möglichkeit haben, meine Passwörter zu kopieren und einzufügen, um sie schnell und einfach zu benutzen.                                                          |

### 1.3 Testfälle

| TC-№ | Ausgangslage                                                        | Eingabe                                                                         | Erwartete Ausgabe                                                                                             |
| ---- | ------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| 1.1  | Benutzer ist im Menü                                                | Klickt auf "Profil Erstellen"                                                   | Ein neues Form wird geöffnet, in dem der Benutzer ein Profil erstellen kann.                                  |
| 1.2  | Benutzer ist im Menü                                                | Klickt auf "Profil Ausgeben"                                                    | Die Liste aller gespeicherten Profile wird angezeigt, wenn welche vorhanden sind.                             |
| 2.1  | Benutzer ist in der Profil-Erstellung                               | Gibt gültige Informationen in alle Felder ein und Klickt auf "Profil speichern" | Profil wird gespeichert und das Form schliesst sich, benutzer kehrt zum Menü zurück.                          |
| 2.2  | Benutzer ist in der Profil-Erstellung                               | Gibt ungültige Informationen in ein Feld ein und Klickt auf "Profil speichern"  | Profil wird nicht gespeichert und eine Fehlermeldung wird ausgegeben.                                         |
| 3.1  | Benutzer ist in der Profil-Erstellung                               | Gibt gültige Informationen in alle Felder ein und Klickt auf "Profil speichern" | Profil, Nutzername, Email, Passwort wird verschlüsselt und in die Text datei eingeschrieben.                  |
| 3.2  | Benutzer ist in der Profil-Erstellung                               | Gibt ungültige Informationen in ein Feld ein und Klickt auf "Profil speichern"  | Profil, Nutzername, Email, Passwort wird nicht verschlüsselt und nicht in die Text datei eingeschrieben.      |
| 3.3  | Benutzer ist in der Profil-Erstellung                               | Klickt auf "Zurück"                                                             | Schliesst das Form und verwirft alle Änderungen.                                                              |
| 4.1  | Benutzer ist im Menü                                                | Klickt auf "Profil Ausgeben"                                                    | Die Liste aller gespeicherten Profile wird angezeigt.                                                         |
| 4.2  | Benutzer ist in der Profil Ausgabe                                  | klickt auf "bearbeiten" eines bestimmten Profils                                | Neues Form öffnet sich, Profil mit bestimmten index wird ausgegeben.                                          |
| 4.3  | Benutzer hat ein Profil ausgewählt und bearbeitet es                | Klickt auf "Profil speichern"                                                   | Die bearbeiteten Informationen werden im ausgewählten Profil gespeichert. Das Form schließt sich.             |
| 4.4  | Benutzer hat ein Profil ausgewählt und bearbeitet es                | Klickt auf "Zurück"                                                             | Schliesst das Form und verwirft alle Änderungen.                                                              |
| 5.1  | Benutzer Bestätigt aus ein Forms                                    | klickt auf bestätigung                                                          | Profil, Nutzername, Email, Passwort wird verschlüsselt, wird in Text datei eingeschrieben.                    |
| 6.1  | Der Benutzer möchte eine bestimmte Funktion nutzen                  | Klick auf das entsprechende Button                                              | Der Benutzer wird zur entsprechenden Funktion weitergeleitet, wo er alle relevanten Informationen sehen kann. |
| 6.2  | Der Benutzer befindet sich auf einer Unterseite                     | Klick auf "Zurück"                                                              | Der Benutzer wird zur vorherigen Seite zurückgeleitet.                                                        |
| 7.1  | Der Benutzer hat noch kein Passwort generiert                       | Klick auf "Passwort generieren"                                                 | Der Passwort-Generator generiert ein starkes, zufälliges Passwort und zeigt es dem Benutzer an.               |
| 7.2  | Der Benutzer ist mit dem generierten Passwort nicht zufrieden       | Klick auf "Passwort generieren"                                                 | Der Passwort-Generator generiert ein neues, starkes, zufälliges Passwort.                                     |
| 7.3  | Der Benutzer ist mit dem Passwort zufrieden und möchte es speichern | Klick auf "Profil speichern"                                                    | Das Passwort wird im Profil des Benutzers gespeichert.                                                        |
| 8.1  | Starten des Programms                                               | Keine Eingabe benötigt                                                          | Ein Form mit der Abfrage des Master-Passworts wird geöffnet.                                                  |
| 8.2  | Erstes mal Starten des Programms                                    | Keine Eingabe benötigt                                                          | Registrierung eines Master Passworts und erstellung eines Sicherheitsschlüssels                               |
| 9.1  | Benutzer ist im Master-Passwort Form                                | 5 mal falsches Passwort eingeben                                                | Sicherheitsschlüssel wird erwartet                                                                            |
| 9.2  | 5 mal falsches Passwort eingeben                                    | Sicherheitsschlüssel wird eingegeben                                            | Neue Registrierung des Master Passworts wird geöffnet                                                         |
| 9.3  | 5 mal falsches Passwort eingeben                                    | 3 mal falscher Sicherheitsschlüssel eingegeben                                  | Programm wird beendet.                                                                                        |
| 10.1 | Benutzer hat ein Profil ausgewählt und bearbeitet es                | Klickt auf "Profil Löschen"                                                     | Das ausgewählte Profil wird gelöscht und aus der Profil-Liste entfernt.                                       |
| 11.1 | Benutzer ist in der Profil Ausgabe                                  | Makiert das Passwort und kann es Kopieren                                       | Das Passwort des ausgewählten Profils wird in die Zwischenablage kopiert.                                     |

### 1.4 Diagramme

UC Diagramm

<img width="535" alt="Bildschirm­foto 2023-02-21 um 11 40 11 AM" src="https://user-images.githubusercontent.com/89131189/220322734-e3646ffe-c5fe-450c-b0a0-3362e5c2d34c.png">

PAP nur mit Muss Verbindlichkeiten

![Passwort Manager1](https://user-images.githubusercontent.com/110892283/220339275-22d13b07-7d90-4e11-9a85-e7497c6d89c7.png)

Zusätzliche Informieren und Planen unterlagen

![WhatsApp Image 2023-02-21 at 12 57 02](https://user-images.githubusercontent.com/110892283/220339634-b9d13d21-0e56-4590-a271-8f9b69887ba2.jpeg)

[Password Manager.docx](https://github.com/Kurizaki/LA1500/files/11011250/Password.Manager.docx)

## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung                                           | geplante Zeit |
| ---- | -------- | --------- | ------------------------------------------------------ | ------------- |
| 1.A  | 07.03.23 | Koelewijn | Entwicklung der Profil Erstellung                      | 150min        |
| 2.A  | 07.03.23 | Koelewijn | Einlesen von Text Datei, speichern in Listen           | 150min        |
| 2.B  | 07.03.23 | Koelewijn | überschreiben der Text Datei                           | 105min        |
| 3.A  | 07.03.23 | Sacher    | Einlesen von Text Datei, speichern in Listen           | 100min        |
| 3.B  | 07.03.23 | Sacher    | Liste ausgeben in der Applikation                      | 150min        |
| 4.A  | 14.03.23 | Sacher    | Entwicklung Abrufen der Profilen und bearbeiten        | 150min        |
| 4.B  | 14.03.23 | Koelewijn | Veränderung in der Liste beim Bearbeiten eines Profils | 150min        |
| 5.A  | 07.03.23 | Eser      | Entwicklung der Verschlüsselung                        | 100min        |
| 5.B  | 14.03.23 | Eser      | Entwicklung der Entschlüsselung                        | 100min        |
| 5.C  | 14.03.23 | Eser      | Text Datei Verschlüsseln & Entschlüsseln               | 150min        |
| 6.A  | 07.03.23 | Tuma      | Erste Version des UI                                   | 175min        |
| 6.B  | 21.03.23 | Tuma      | Letzte Version des UI                                  | 175min        |
| 7.A  | 14.03.23 | Tuma      | Entwicklung des Passwort Generator                     | 45min         |
| 8.A  | 21.03.23 | Koeleiwjn | Entwicklung des Master Passworts                       | 150min        |
| 9.A  | 21.03.23 | Sacher    | 6 Stelliger Sicherheitsschlüssel generieren lassen     | 100min        |
| 10.A | 21.03.23 | Koelewijn | Entwicklung Profile zu Löschen                         | 100min        |
| 11.A | 21.03.23 | Sacher    | Kopieren eines Passworts                               | 100min        |

Total: 47.7 Arbeitspakete

## 3 Entscheiden

Zunächst haben wir beschlossen, das Programm in mehrere Forms aufzuteilen, um die Entwicklungsaufgaben besser auf die Entwickler zu verteilen und die Arbeitseffizienz zu erhöhen. Dabei haben wir auch die Funktionen und Eigenschaften jedes einzelnen Forms festgelegt.

Wir haben sorgfältig entschieden, welche Funktionen auf unserem Niveau realisierbar sind und welche nicht. Basierend auf diesen Entscheidungen haben wir uns darauf geeinigt, welche Funktionen in das Programm aufgenommen werden sollen.

Wir haben uns dazu entschieden, Listen zu verwenden, um die Werte zu speichern, da dies eine effektive und leicht zugängliche Methode ist.

Wir haben uns für die Entwicklung in Winforms entschieden, da wir uns mit dieser Technologie wohl fühlen und sie unseren Anforderungen am besten entspricht.

Wir haben uns für verschiedene Verschlüsselungsmethoden entschieden, jedoch letztendlich Frau Eser die finale Entscheidung überlassen, weil sie diesen Teil realisiert.

Wir haben uns entschieden, die Profile in der Textdatei in einer bestimmten Reihenfolge zu speichern und welche Trennzeichen dabei zu verwenden sind, um die Lesbarkeit und Handhabung der Daten zu erleichtern.

Die Entwicklungsaufgaben haben wir aufgrund der individuellen Kompetenzen der Programmierer aufgeteilt, damit jeder an einem Teil des Programms arbeiten kann, bei dem er etwas Neues lernen und seine Fähigkeiten erweitern kann.

## 4 Realisieren

| AP-№ | Datum    | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | -------- | --------- | ------------- | ----------------- |
| 1.A  | 07.03.23 | Koelewijn | 150min        | 100min            |
| 2.A  | 07.03.23 | Koelewijn | 150min        | 100min            |
| 2.B  | 07.03.23 | Koelewijn | 105min        | 150min            |
| 3.A  | 07.03.23 | Sacher    | 100min        | 100min            |
| 3.B  | 07.03.23 | Sacher    | 150min        | 200min            |
| 4.A  | 14.03.23 | Sacher    | 150min        | 100min            |
| 4.B  | 14.03.23 | Koelewijn | 150min        | 100min            |
| 5.A  | 07.03.23 | Eser      | 100min        | 150min            |
| 5.B  | 14.03.23 | Eser      | 100min        | 150min            |
| 5.C  | 14.03.23 | Eser      | 150min        | 200min            |
| 6.A  | 07.03.23 | Tuma      | 175min        | 175min            |
| 6.B  | 21.03.23 | Tuma      | 175min        | 175min            |
| 7.A  | 14.03.23 | Tuma      | 45min         | 20min             |
| 8.A  | 21.03.23 | Koeleiwjn | 150min        | 200min            |
| 9.A  | 21.03.23 | Sacher    | 100min        | 50min             |
| 10.A | 21.03.23 | Koelewijn | 100min        | 100min            |
| 11.A | 21.03.23 | Sacher    | 100min        | 50min             |

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum    | Resultat     | Tester          |
| ---- | -------- | ------------ | --------------- |
| 1.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 1.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 2.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 2.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 3.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 3.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 3.3  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 4.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 4.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 4.3  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 4.4  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 5.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 6.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 6.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 7.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 7.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 7.3  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 8.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 8.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 9.1  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 9.2  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 9.3  | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 10.1 | 21.03.23 | Funktioniert | Keanu Koelewijn |
| 11.1 | 21.03.23 | Funktioniert | Keanu Koelewijn |

Die durchgeführten Testfälle haben das Programm geprüft und stellen sicher, dass es für den Benutzer ein optimales Erlebnis bietet. Durch eine sorgfältige Prüfung aller Funktionalitäten und möglichen Anwendungsfälle konnten potenzielle Schwachstellen erkannt und beseitigt werden, was zu einer höheren Stabilität und Zuverlässigkeit des Programms beiträgt. Die Testfälle haben auch dazu beigetragen, sicherzustellen, dass das Programm effizient arbeitet und dass die Benutzeroberfläche benutzerfreundlich ist.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage                                        | Eingabe                 | Erwartete Ausgabe                                      | Tatsächliche Ausgabe                         |
| ---- | --------------------------------------------------- | ----------------------- | ------------------------------------------------------ | -------------------------------------------- |
| I    | Programm wird gestartet                             | 5 Mausklicks auf weiter | Falsche Eingabe                                        | Fenster für Sicherheitsschlüssel öffnet sich |
| II   | Fenster für Sicherheitsschlüssel ist geöffnet       | 3 Mausklicks auf weiter | Falsche Eingabe                                        | Programm wird beendet                        |
| III  | Fenster für Änderung von Masterpasswort ist göffnet | Beenden Button          | Menu mit verschiedenen Funktionen wird wieder geöffnet | Programm schliesst sich                      |

## 6 Auswerten

[Lern Bericht](https://github.com/Kurizaki/LA1500/blob/main_project/Lernbericht.md)
