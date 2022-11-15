//Riprendiamo l’esercizio della biblioteca considerando però alcune varianti:
//non è necessario (ma consigliato) ragionare con gli oggetti.
//evitiamo categoricamente la questione dell’eredità tra oggetti
//
//potete implementare una singola tabella per tutti i documenti:
//ovviamente in questo caso ci dovrà essere una colonna che gestisce il tipo di documento
//
//Realizzate almeno le tabelle dei documenti e dei prestiti con le opportune relazioni;
//qui potete inserire solo un campo nome cliente nel prestito e ignorare la parte di registrazione richiesta
//nel database potete usare una sola colonna varchar, direttamente nel documento, per inserire il nome e cognome dell’autore
//
//
//Bonus:
//implementate anche la tabella utente e i controllo di registrazione (che significa che l’utente è dentro al db e quindi prima di fare il prestito deve essere trovato dal bibliotecario attraverso il sistema)
//Si vuole progettare un sistema per la gestione di una biblioteca.
//
//Gli utenti si possono registrare al sistema, fornendo:
//cognome,
//nome,
//email,
//password,
//recapito telefonico,
//
//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//titolo,
//anno,
//settore(storia, matematica, economia, …),
//stato(In Prestito, Disponibile),
//uno scaffale in cui è posizionato,
//un autore (Nome, Cognome).
//
//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.