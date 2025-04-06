# Registro Visitatori - Progetto HMI (Interfacce Uomo Macchina)

Questo progetto è stato sviluppato come consegna per il corso universitario di **Realizzazione Interfacce Uomo Macchina**, seguendo le direttive fornite dal docente.  
L'applicazione consente la gestione dei visitatori all'interno di un'azienda, con registrazione in ingresso, visualizzazione dei presenti, e possibilità di segnare l'uscita.

---

## 🧾 Requisiti implementati

- ✅ Utilizzo del **template fornito** con struttura ASP.NET Core MVC
- ✅ Implementazione su **ASP.NET Core MVC + Entity Framework**
- ✅ Database in memoria (**InMemoryDb**) precaricato all’avvio
- ✅ Login funzionante con utenti seed (email1@test.it / password: Prova)
- ✅ Funzionalità complete:
  - Registrazione nuovo visitatore
  - Visualizzazione visitatori presenti
  - Segnalazione uscita visitatore
- ✅ Grafica responsive e moderna con **Bootstrap 5**
- ✅ Navbar coerente con il layout base (_LayoutHtml.cshtml)
- ✅ Restyling completo in chiave moderna e minimal
- ✅ Notifiche utente (con `TempData`) al salvataggio e all’uscita
- ✅ Organizzazione per cartelle View/Controller/Model in stile MVC

---

## 🖥️ Aspetti tecnici implementati

### 1. **Utilizzo di TempData per feedback utente**
Utilizzato per mostrare messaggi di successo (es. "Visitatore registrato con successo") dopo operazioni CRUD.

### 2. **Restyling personalizzato con Bootstrap + FontAwesome**
Tutte le interfacce sono state ridisegnate per essere usabili, pulite e coerenti con il layout ONIT del template. Utilizzati:
- card con shadow e bordi arrotondati
- badge di stato (presente/uscito)
- icone contestuali per migliorare la UX

---

## ▶️ Come eseguire il progetto

1. Clona la repository:
   ```bash
   git clone https://github.com/acetheberliner/registroVisitatori.git
   ```
2. Apri il progetto in Visual Studio

3. Esegui Template.Web con F5

4. Verrà aperto il browser su https://localhost:7132/

5. Effettua il login con:
     Email: email1@test.it
     Password: Prova

## 🧪 Test di usabilità
È stata testata la chiarezza delle interfacce con utenti non tecnici.
Feedback positivi sulla semplicità d’uso e sulla chiarezza delle operazioni (ingresso/uscita).

## 🧩 Tecnologie usate
- ASP.NET Core 6 MVC
- Entity Framework Core
- Bootstrap 5
- FontAwesome
- Razor Views
- TempData
- Layout ONIT fornito dal template

## 🎯 Linee guida rispettate:
Requisito	Stato
- ✅ Utilizzo del template base	✔️ 
- ✅ ASP.NET Core MVC	✔️ 
- ✅ Layout responsive & Bootstrap	✔️ 
- ✅ Wireframe & struttura coerente	✔️ 
- ✅ Pagina principale + crea + modifica	✔️ 
- ✅ Coerenza tra aree	✔️ 
- ✅ Esperienza utente chiara	✔️ 
- ✅ Styling sobrio e moderno	✔️ 

## 🧑‍💻 Autore
Bagnolini Tommaso
Laboratorio di Interfacce uomo-macchina
2024/2025
