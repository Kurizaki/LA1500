# Lern-Bericht

## Gruppe Camelia:

-Koelewijn

-Tuma

-Eser

-Sacher

## Einleitung

Wir haben uns dazu entschieden, einen Passwortmanager zu programmieren. Dieser verschlüsselt und speichert die Passwörter, damit sie sicher sind und man sie nicht vergessen kann. Die Passwörter und E-Mails sollen je in einem Profil gespeichert werden, welches man einzeln hervorrufen kann, damit man nicht zuerst nach den richtigen Daten suchen muss.

## Was habe ich gelernt?

Wir haben gelernt, wie Verschlüsselungen funktionieren und wie man diese mithilfe einer Bibliothek in Visual Studio verwenden kann.

## Beschreibung

Verschlüsselungen sind heutzutage sehr wichtig zur Datensicherheit. Sie wird verwendet, um die Vertraulichkeit von Daten zu gewährleisten und um vertrauliche Daten sicher vor unautorisiertem Zugriff zu schützen. Dabei wird z.B. ein Text verschlüsselt, um ihn unlesbar macht für andere Benutzer. Eine verschlüsselte Datei kann nur mit einem passenden Schlüssel wieder entschlüsselt werden. Dadurch wird die Datei für einen Angreifer ohne den Schlüssel nicht lesbar. AES (Advanced Encryption Standard) ist eine Verschlüsselungsmethode, die weit verbreitet ist, um Daten zu verschlüsseln. Darum haben wir uns auch für die AES Verschlüsselung in unserem Projekt entschieden. Verschlüsselungen hängen aber von vielen Aspekten ab, sogar die Länge des Schlüssels ist wichtig, um die Verschlüsselung sicherer zu machen.

### Verschlüsselung mithilfe einer Bibliothek:

Die Bibliothek wurde von anderen Entwickler programmiert, um Daten zu verschlüsseln, man importiert die Bibliothek und man kann mithilfe eines Codes der dazugehörigen Bibliothek die Daten verschlüsseln.

z.B. bei der Bibliothek Twileloop.ExpressSecurity kann man Daten mit dem Code

```csharp
AESEncription.AES_Encrypt(Dateipfad, schlüssel);
```

Verschlüsseln und mit dem Code 

```csharp
AESEncription.AES_Decrypt(Dateipfad, encryptionpassword);
```

Kann man sie entschlüsseln, der Code ist aber bei jeder Bibliothek anders. Also muss man sich erst erkundigen, wie man die Daten verschlüsseln und entschlüsseln kann.

### Verschlüsselung selber programmiert:

Es ist viel schwieriger eine Verschlüsselung selbst zu programmieren, denn sie kann fehleranfällig sein und wenn man eine eigene neue Verschlüsselung dazu noch programmieren will, muss man sich zuerst ein Konzept überlegen, um die Daten sicher zu verschlüsseln. Ein Beispiel Code kann hier leider nicht vorgeführt werden, denn es ist viel komplizierter und der Code wäre viel länger.

https://youtu.be/DGYi3iz4RhY

Hier wird die Verschlüsselung und Entschlüsselung einer Datei mithilfe von einer Bibliothek getätigt.

## Verifikation

- Der erste Codeteil zeigt wie die Daten mit der AES Verschlüsselung verschlüsselt werden

- Der zweite Codeteil zeigt wie die Daten mit der AES Verschlüsselung entschlüsselt werden

- In dem Youtube Video wird veranschaulicht, wie eine Textdatei verschlüsselt und anschliessend wieder entschlüsselt wird.

# Reflektion zum Arbeitsprozess

**Was gut lief:** Während des Arbeitsprozesses verlief die Arbeit in der Gruppe reibungslos und die Kommunikation war hervorragend. Durch regelmäßige Besprechungen der Fortschritte und gegenseitige Unterstützung konnte das Team erfolgreich zusammenarbeiten. Dies war möglich durch geplante organisation der verteilten Aufgaben und kompetenzen.

**Was nicht so gut lief:** Es kam vor, dass Aufgaben schneller als erwartet erledigt wurden, was dazu führte, dass einige Gruppenmitglieder weniger zu tun hatten als andere.

**VBV**: Um die Effizienz zu steigern, sollte die Aufgabenverteilung so gestaltet werden, dass Mitglieder, die schneller als erwartet mit ihren Aufgaben fertig sind, anderen Mitgliedern helfen können oder an einer anderen Aufgabe arbeiten können, die mehr Zeit benötigt.
