# agricola_csharp_challenge
1	Allgemeines

Die GEOINFO Applications AG heisst dich herzlich willkommen zu deiner Probeaufgabe. Damit du bei uns ein wenig hereinschnuppern kannst und einen Teil von unserer täglichen Arbeit siehst, haben wir eine kleine Aufgabe für dich vorbereitet. Du solltest so in etwa 4-8 Stunden dafür einplanen und musst nicht mehr dafür investieren. Solltest du Fragen zur Aufgabe haben, kannst du dich jederzeit gerne melden.

1.1	Vorbereitung

Bevor es losgehen kann, brauchst du zunächst Visual Studio. Wir arbeiten mit Visual Studio 2022 Professional, du kannst aber die Community Edition benutzen. Diese findest du [hier](https://visualstudio.microsoft.com/de/vs/community/). So sollte deine Installation in etwa aussehen:

 ![image](https://github.com/geoinfo-applications/agricola_csharp_challenge/assets/157117297/1d30b383-5d2b-431b-a376-502a9ede3220)

Neben Visual Studio benötigst du noch ein Tool, mit dem du SQLite-Datenbanken bearbeiten kannst. Wir empfehlen dir hierfür «DB Browser for SQLite»:

![image](https://github.com/geoinfo-applications/agricola_csharp_challenge/assets/157117297/289c8500-4515-41e0-9621-f6849e30ad69)

Da unsere Anwendung auf dem Design Pattern «MVVM» aufgebaut ist und wir hierfür eine Bibliothek benutzen, wird das CommunityToolkit.Mvvm Nuget-Package automatisch hinzugefügt. 
Für die Anbindung an die Datenbank verwenden wird das Nuget-Package System.Data.SQLite, das wir ebenfalls schon hinzugefügt haben.

1.2	Aufgabenstellung

Wie aus den Screenshots bereits zu erahnen ist, geht es darum ein kleines WPF-Tool zur Adressverwaltung zu entwickeln. Der Benutzer soll in der Lage sein, in der SQLite-Datenbank bestehende Adressen zu verwalten. Dies umfasst Adressen zu mutieren, zu löschen und neue Adressen hinzuzufügen. Das Tool sollte so aussehen:

![image](https://github.com/geoinfo-applications/agricola_csharp_challenge/assets/157117297/7e924ee2-2468-4517-999e-4f56ea43eed3)


Mit dem «+»-Button unten links sollen neue Adressen hinzugefügt und mit dem «-»-Button entsprechend wieder gelöscht werden können. Bearbeitet werden die Adressen direkt in der Tabelle in der GUI. Die PLZ und die Gemeinde sollen dabei Comboboxen sein. Diese sollen bereits abgefüllte Werte sein, die nicht vom Benutzer bearbeitet werden können. Eine PLZ soll mehreren Gemeinden zugewiesen sein können und umgekehrt auch eine Gemeinde mehreren PLZ.  Mit dem Button «Speichern» sollen die Daten – so wie sie der Benutzer vor sich hat – in der Datenbank gespeichert werden können. Das bedeutet, dass neue Adressen angelegt sowie bestehende aktualisiert werden können. Der Button «Beenden» soll das Programm nur schliessen. Nicht gespeicherte Änderungen sollen beim Schliessen nicht automatisch gespeichert werden.

1.3	Programmierkonzepte

Folgende Programmierkonzepte sollten im Rahmen der Probeaufgabe umgesetzt und angewendet werden:

-	WPF-Programmiertechniken:
 	- Bindings
 	- Mindestens einen eigenen Style definieren und verwenden, beispielsweise für Buttons
 	- Mindestens ein Grid und ein Stackpanel verwenden
 	- Commands
-	Allgemeine Programmiertechniken:
 	- Objektorientierung
 	- Kapselung
-	Einfache Implementierung von MVVM mithilfe von CommunityToolkit.Mvvm
-	Datenbank
 	- Mitgelieferte SQLite-Datenbank verwenden
 	- Datenstruktur mit Primärschlüsseln und Fremdschlüsselreferenzen
 	- Datenbankverbindung mithilfe von C# herstellen
 	- CRUD-Operationen auf der Datenbank ausführen

1.4	Abgabe

Wir bitten dich für diese Aufgabe nicht länger als 8 Stunden zu investieren. Du musst die Aufgabe nicht fertig machen, wenn du es in der vorgegebenen Zeit nicht schaffst. 

Bitte klone das Repository in dein eigenes privates Repository und teile es mit JacCGeo

