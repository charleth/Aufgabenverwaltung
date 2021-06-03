# Aufgabenverwaltung
Aufgabenverwaltungs-Software

IL Aufgabe aus dem Mouton-C#-Kurs

Programmieren Sie eine WindowsForms Anwendung, mit der der Nutzer eine Liste von Aufgaben verwalten kann.
Jede Aufgabe besteht aus folgenden Informationen:

    Bezeichnung
    Abgabedatum
    Mitarbeiter
    Erledigungsgrad (in %)
    
<p dir="ltr" style="text-align: left;">
    <div>Aufgaben:<br></div>
    <div>
        <ol>
            <li>Legen Sie ein WindowsForms Projekt an. Im Hauptfenster ist die Liste der Aufgaben zu sehen, erstmal als ListBox. Definieren Sie dafür eine Klasse Aufgabe mit Konstruktor und ToString()-Methode. In der Fenster-Klasse, programmieren Sie eine
                Funktion AddAufgabe(Aufgabe a), die die gegebene Aufgabe in die List und in die ListBox hinzufügt.<br>Fügen Sie zum Testen einige festkodierte Aufgaben ein.</li>
            <li>Aufgaben aus .csv-Datei laden. Bereiten Sie dafür eine Datei mit Testdaten vor, und programmieren Sie eine Funktion, die diese lädt, Aufgaben-Objekte erstellt, und sie mit AddAufgabe speichert und anzeigt. Im Konstruktor des Hauptfensters,
                rufen Sie die Ladefunktion auf.</li>
            <li>Button + Maske "Aufgabe hinzufügen". Programmieren Sie ein 2. Fenster namens AufgabenEditor, wo der Nutzer eine neue Aufgabe erfassen kann. Fügen Sie ins Hauptfenster einen Button hinzu, der dieses 2. Fenster als Dialog öffnet. Fügen Sie ins
                2. Fenster einen Button "Aufgabe erstellen" hinzu. Dieser schließt das 2. Fenster (mit Close()), erstellt ein neues Aufgabe-Objekt, und ruft hauptfenster.AddAufgabe() auf. Dafür muss der Konstruktor des AufgabenEditors das Hauptfenster
                als Parameter bekommen.<br></li>
            <li>Button "Aufgabe entfernen". Im Hauptfenster, fügen Sie einen Button hinzu, der prüft, ob eine Aufgabe in der ListBox markiert ist, und ggf. diese aus der List und aus der ListBox entfernt.</li>
            <li>Button + Maske "Aufgabe bearbeiten". Passen Sie den AufgabenEditor so an, dass er eine Aufgabe als Konstruktorparameter bekommen kann. Bekommt er null, so verhält er sich wie bisher, mit "Aufgabe einfügen"-Button. Bekommt er tatsächlich ein
                Aufgaben-Objekt, so merkt er sich dieses objekt in eine dafür vorgesehene Variable, kopiert die Eigenschaften der Aufgabe in die Eingabefelder, und ändert den Text des Buttons auf "Änderungen speichern". In der Funktion des Buttons wird
                unterschieden: ist keine Aufgabe vorhanden, so wird weiterhin eine erstellt und ins Hauptfenster hinzugefügt; ist eine Aufgabe vorhanden, so werden die Eingaben in ihre Attribute gespeichert und dem Hauptfenster mitgeteilt, dass diese
                Aufgabe sich geändert hat, damit das Hauptfenster die ListBox aktualisieren kann. Dafür braucht das Hauptfenster eine Methode AufgabeGeaendert(Aufgabe). Hinweis: da die List und die ListBox über Indexe synchronisiert werden, lohnt es sich
                vielleicht, den Index der bearbeiteten Aufgabe an den AufgabenEditor zu übergeben...</li>
            <li>Daten speichern. Programmieren Sie eine Funktion DatenSpeichern(), die die Aufgaben in die .csv-Datei speichert. Diese Funktion muss im Hauptfenster definiert sein, weil sie auf die Liste der Aufgaben zugreift; sie wird aber vom AufgabenEditor
                aufgerufen, wenn eine Änderung passiert ist (neue Aufgabe oder Aufgabe geändert).</li>
        </ol>
        <div>Erweiterungen</div>
        <div>
            <ul>
                <li>ListBox durch DataGridView ersetzen: jede Eigenschaft der Aufgaben wird in einer Spalte angezeigt. Dafür können die Daten entweder "manuell" in die DataGridView kopiert werden (genauso wie die String-Darstellung in die ListBox), oder eine
                    DataTable zur Speicherung der Daten benutzt werden (anstatt List), und diese DataTable als Datenquelle in der DataGridView registriert werden.</li>
                <li>Daten in einer Datenbank speichern. In einem ersten Schritt kann die Speicherung und das Laden genauso wie in einer Datei gemacht werden; falls eine DataGridView benutzt worden ist, kann diese direkt mit der Datenbank verbunden werden
                    (über eine SQLDataSource).</li>
            </ul>
        </div>
    </div><br></p>
