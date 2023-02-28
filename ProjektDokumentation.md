
## Gruppe Camelia:

-Koelewijn (Gruppenleiter)

-Tuma

-Eser

-Sacher

| Datum | Version | Zusammenfassung                                        |
| ----- | ------- | ------------------------------------------------------ |
|       | 0.0.1   | Projekt Idee und konzept des programms wurde überlegt. |
|       | ...     |                                                        |
|       | 1.0.0   |                                                        |

## 1 Informieren

### 1.1 Ihr Projekt

Wir haben uns dazu entschieden einen Passwortmanager zu programmieren. Dieser verschlüsselt und speichert die Passwörter, damit sie sicher sind und man sie nicht vergessen kann. Die Passwörter und E-Mails sollen je in einem Profil gespeichert werden, welches man einzeln hervorrufen kann, damit man nicht zuerst nach den richtigen Daten suchen muss. Zudem wollen wir noch ein schönes UI machen, welches dem Benutzer das Gefühl von Sicherheit gibt.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ            | Beschreibung                                                                                                                                                                                                              |
| ---- | --------------- | -------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 1    | Muss            | Funktionalität | Als ein Benutzer möchte ich Profile erstellen können, damit ich mein Passwort speichern kann                                                                                                                              |
| 2    | Muss            | Funktionalität | Als ein Benutzer möchte ich in meinen Profilen, Nutzername, Email und Passwort speichern können                                                                                                                           |
| 3    | Muss            | Funktionalität | Als ein Benutzer möchte ich die Daten speichern können, damit ich meine Profile jederzeit aufrufen kann.                                                                                                                  |
| 4    | Muss            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben meine Profile zu bearbeiten, damit ich meine Daten korrigieren kann.                                                                                                    |
| 5    | Muss            | Funktionalität | Als ein Benutzer möchte ich das die Daten verschlüsselt werden, damit sie sicher sind.                                                                                                                                    |
| 6    | Muss            | Funktionalität | Als ein Benutzer möchte ich ein übersichtliches Interface haben, damit ich auf alles einfach zugreifen kann.                                                                                                              |
| 7    | Muss            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben Passwörter generieren lassen, damit ich ein starkes Passwort habe                                                                                                       |
| 8    | Kann            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben ein Master Passwort einzubauen, damit nur ich auf meine Daten zugreifen kann.                                                                                           |
| 9    | Kann            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben ein Sicherheitsschlüssel oder Sicherheitsfrage für das Master Passwort einzubauen, damit ich ein neues Masterpasswort erstellen kann wenn ich das alte vergressen habe. |
| 10   | Kann            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben mehrere Emails / Nutzernamen in einem Profil einzubauen, damit es übersichtlicher für mich ist.                                                                         |
| 11   | Kann            | Funktionalität | Als ein Benutzer möchte ich die möglichkeit haben Websiten pro Profil zu speichern, damit ich weiss zu welchem Passwort was gehört.                                                                                       |


### 1.3 Testfälle

| TC-№ | Ausgangslage                                           | Eingabe                                        | Erwartete Ausgabe                                                                                                                                                              |
| ---- | ------------------------------------------------------ | ---------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| 1.1  | Benutzer ist im Menü                                   | klickt auf Profil Erstellen                    | Ein neues Form mit der möglichkeit ein Passwort zu erstellen wird geöffnet.                                                                                                    |
| 2.1  | Benutzer ist in der Profil Erstellung                  | klickt auf Bestätigung                         | Profil wird gespeichert und das Form schliesst sich, benutzer kehrt zum Menü zurück.                                                                                           |
| 2.2  | Benutzer ist in der Profil Erstellung                  | lässt eine Spalte Leer                         | Profil wird nicht gespeichert und eine Fehlermeldung wird ausgegeben.                                                                                                          |
| 3.1  | Benutzer ist in der Profil Erstellung                  | klickt auf Bestätigung                         | Profil, Nutzername, Email, Passwort wird verschlüsselt, wird in Text datei eingeschrieben.                                                                                     |
| 4.1  | Benutzer ist im Menü                                   | klickt auf Profil Ausgeben                     | Text datei wird ausgelesen, Profile, Nutzername, Email und Passwort wird getrennt in den Listen gespeichert und entschlüsselt. Neues Form wird erstellt und gibt die Daten aus |
| 4.2  | Benutzer ist in der Profil Ausgabe                     | klickt auf bearbeiten eines bestimmten Profils | Neues Form öffnet sich, Profil mit bestimmten index wird ausgegeben.                                                                                                           |
| 4.3  | Benutzer ist in der Profil bearbeitung                 | klickt auf bestätigung                         | bei bearbeitung wird das gewünschte Profil in der Liste mit dem Index verändert.                                                                                               |
| 5.1  | Benutzer Bestätigt aus ein Forms                       | klickt auf bestätigung                         | Profil, Nutzername, Email, Passwort wird verschlüsselt, wird in Text datei eingeschrieben.                                                                                     |
| 6.1  | Benutzer ist in der Applikation                        |                                                | Hat keine Probleme sich zu Navigieren.                                                                                                                                         |
| 7.1  | Benutzer ist in der Profil Erstellung                  | klickt auf Passwort generieren                 | Ein Passwort mit verscheidenen Zeichen wird Generiert.                                                                                                                         |
| 7.2  | Ein Passwort mit verscheidenen Zeichen wird Generiert. |                                                | Generiertes Passwort wird in der Text Box beim Passwort automatisch eingegeben                                                                                                 |
| 8.1  | Starten des Programms                                  |                                                | Abfrage des Masterpassworts                                                                                                                                                    |
| 9.1  | Erstes mal Starten des Programms                       |                                                | Registrierung eines Master Passworts und erstellung eines Sicherheitsschlüssels                                                                                                |
| 9.2  | Starten des Programms                                  | 5 mal falsches Passwort eingeben               | Sicherheitsschlüssel wird erwartet                                                                                                                                             |
| 9.3  | 5 mal falsches Passwort eingeben                       | Sicherheitsschlüssel wird eingegeben           | Neue Registrierung des Master Passworts wird geöffnet                                                                                                                          |
| 9.4  | 5 mal falsches Passwort eingeben                       | 3 mal falscher Sicherheitsschlüssel eingegeben | Programm wird beendet                                                                                                                              |


### 1.4 Diagramme

UC Diagramm

<img width="535" alt="Bildschirm­foto 2023-02-21 um 11 40 11 AM" src="https://user-images.githubusercontent.com/89131189/220322734-e3646ffe-c5fe-450c-b0a0-3362e5c2d34c.png">

PAP nur mit Muss Verbindlichkeiten

![Passwort Manager1](https://user-images.githubusercontent.com/110892283/220339275-22d13b07-7d90-4e11-9a85-e7497c6d89c7.png)

Zusätzliche Informieren und Planen unterlagen

![WhatsApp Image 2023-02-21 at 12 57 02](https://user-images.githubusercontent.com/110892283/220339634-b9d13d21-0e56-4590-a271-8f9b69887ba2.jpeg)

## 2 Planen

| AP-№ | Frist    | Zuständig | Beschreibung                                           | geplante Zeit |
| ---- | -------- | --------- | ------------------------------------------------------ | ------------- |
| 1.A  | 07.03.23 | Koelewijn | Entwicklung der Profil Erstellung                      | 75min         |
| 2.A  | 07.03.23 | Koelewijn | Einlesen von Text Datei, speichern in Listen           | 75min         |
| 2.B  | 07.03.23 | Koelewijn | überschreiben der Text Datei                           | 30min         |
| 3.A  | 07.03.23 | Sacher    | Einlesen von Text Datei, speichern in Listen           | 25min         |
| 3.B  | 07.03.23 | Sacher    | Liste ausgeben in der Applikation                      | 75min         |
| 4.A  | 14.03.23 | Sacher    | Entwicklung Abrufen der Profilen und bearbeiten        | 75min         |
| 4.B  | 14.03.23 | Koelewijn | Veränderung in der Liste beim Bearbeiten eines Profils | 75min         |
| 5.A  | 07.03.23 | Eser      | Entwicklung der Verschlüsselung                        | 100min        |
| 5.B  | 14.03.23 | Eser      | Entwicklung der Entschlüsselung                        | 100min        |
| 5.C  | 14.03.23 | Eser      | Text Datei Verschlüsseln & Entschlüsseln               | 150min        |
| 6.A  | 07.03.23 | Tuma      | Erste Version des UI                                   | 175min        |
| 6.B  | 21.03.23 | Tuma      | Letzte Version des UI                                  | 175min        |
| 7.A  | 14.03.23 | Tuma      | Entwicklung des Passwort Generator                     | 45min         |
| 8.A  | 21.03.23 | Koeleiwjn | Entwicklung des Master Passworts                       | 75min         |
| 9.A  | 21.03.23 | Sacher    | 6 Stelliger Sicherheitsschlüssel generieren lassen     | 25min         |

Total: 28.3 Arbeitspakete

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  |       |           |               |                   |
| ...  |       |           |               |                   |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |       |          |        |
| ...  |       |          |        |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.
