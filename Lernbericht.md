# Lern-Bericht

## Gruppe Camelia:

-Koelewijn

-Tuma

-Eser

-Sacher

## Einleitung

Wir haben uns dazu entschieden einen Passwortmanager zu programmieren. Dieser verschlüsselt und speichert die Passwörter, damit sie sicher sind und man sie nicht vergessen kann. Die Passwörter und E-Mails sollen je in einem Profil gespeichert werden, welches man einzeln hervorrufen kann, damit man nicht zuerst nach den richtigen Daten suchen muss.

## Was habe ich gelernt?

Wir haben gelernt wie Verschlüsselungen Funktionieren und wie man diese mit hilfe einer Bibliothek in Vistual Studio verwenden kann.

## Beschreibung

Verschlüsselungen sind Heutzutage sehr Wichtig zur Datensicherheit. Sie wird verwendet um die Vertraulichkeit von Daten zu gewähtrleisten und um Vertrauliche Daten sicher vor unautorisiertem Zugriff zu schützen. dabei wird z.B. ein Text verschlüsselt um Ihn unlesbar macht für andere Benutzer. Eine Verschlüsselte datei kann nur mit einem passenden schlüssel wieder entschlüsselt werden. Dadurch wird die Datei für einen Angreifer ohne den schlüssel nicht lesbar. AES (Advanced Encryption Standard) ist eine verschlüsselungsmethode die weit verbreitet ist  um Daten zu verschlüsseln. Darum haben wir uns auch für die AES Verschlüsselung in unserem Projekt entschieden. Verschlüsselungen hängen aber von vielen aspekten ab, sogar die länge des Schlüssels ist wichtig um die verschlüsselung wichtiger zu machen.

### Verschlüsselung mithilfe einer Bibliothek:

Die Bibliothek wurde von anderen Entwickler Programmiert um Daten zu verschlüsseln, man Impotiert die Bibliothek und man kann mithilfe eines Codes des dazugehörigen Bibliothek die Daten verschlüsseln.

z.B. bei der Bibliothek Twileloop.ExpressSecurity kann man Daten mit dem code

```csharp
AESEncription.AES_Encrypt(Dateipfad, schlüssel);
```

Verschlüsseln und mit dem code 

```csharp
AESEncription.AES_Decrypt(Dateipfad, encryptionpassword);
```

kann man sie entschlüsseln, der Code ist aber bei jeder Bibliothek anders also muss man sich erst erkundigen wie man die Daten verschlüsseln und Entschlüsseln kann.

### Verschlüsselung selber Programmiert:

Es ist viel schwieriger eine verschlüsselung selbst zu programmieren, denn sie kann fehleranfällig sein und wenn man eine eigene neue Verschlüsselung dazu noch programmieren will muss man sich zuerst ein konzep überlegen um die Daten sicher zu verschlüsseln. Ein Beispiel Code kann hier leider nicht vorgeführt werden denn es ist viel komplizierter und der Code wäre viel länger.





![Verschlüsselung](C:\Users\keanu\Downloads\Verschlüsselung.gif)

Hier wird die Verschlüsselung und Entschlüsselung einer Datei mithilfe von einer Bibliothek getätigt.

## Verifikation

✍️ Erklären Sie kurz und bündig, inwiefern die von Ihnen verwendeten Medien zeigen, was Sie gelernt haben.

# Reflektion zum Arbeitsprozess

👍 Überlegen Sie sich jeweils etwas, was gut an Ihrer Arbeit lief; 

👎 und etwas, was nicht gut lief.

**VBV**: ✍️ Formulieren Sie davon ausgehend einen *handelbaren* Verbesserungsvorschlag.


