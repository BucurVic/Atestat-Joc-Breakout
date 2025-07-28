# 🎮 Atestat Breakoutio – Joc Breakout în C# (Windows Forms)

**Breakoutio** este un joc arcade clasic tip *Breakout*, creat ca proiect de atestat folosind C# și Windows Forms. Jucătorul controlează o paletă pentru a respinge o bilă și a sparge blocurile de pe ecran. Obiectivul este să distrugi toate blocurile fără să scapi bila.

---

## 🧩 Caracteristici

- Mișcare lină a paletei (stânga/dreapta).
- 3 rânduri a câte 5 blocuri (în total 15 blocuri).
- Blocuri colorate aleatoriu.
- Sistem de scor dinamic.
- Mesaje de câștig/pierdere.
- Pauză și reluare.
- Control exclusiv din tastatură.

---

## 📺 Interfață grafică

Componenta UI este compusă din:

- `Label txtScor`: Afișează scorul și mesajele jocului.
- `PictureBox jucator`: Reprezintă paleta controlată de jucător.
- `PictureBox bila`: Bila de joc care ricoșează în blocuri și paletă.
- `Timer timerjoc`: Controlează mișcarea bilei și logica jocului la fiecare 20 ms.

Fereastra are dimensiunea fixă `1207 x 704` pixeli, fundal negru și este controlată exclusiv din tastatură.

---

## 🎮 Controale

| Tastă        | Funcție                             |
|--------------|--------------------------------------|
| ⬅️ / A       | Mută paleta la stânga               |
| ➡️ / D       | Mută paleta la dreapta              |
| ⏸ P         | Pune jocul pe pauză                 |
| ⏎ Enter     | Pornește / Continuă jocul           |
| ⎋ Escape    | Iese din joc                         |

---

## 🎯 Obiectiv

- Fiecare bloc spart adaugă 1 punct la scor.
- La 15 puncte: mesaj intermediar de câștig.
- La 30 puncte: mesaj final de câștig – ai spart toate blocurile!
- Dacă bila cade sub paletă: joc pierdut.

---

## 🧠 Logica jocului (Rezumat)

- Bila se mișcă automat în diagonală, ricoșând în margini și în paletă.
- Coliziunile cu paleta și blocurile modifică direcția și viteza bilei.
- Blocurile sunt distruse la contact, fiind eliminate din fereastră.
- Când jocul se termină (win/loss), jucătorul poate apăsa Enter pentru restart.

---

## ▶️ Cum se rulează

1. Deschide soluția în **Visual Studio**.
2. Asigură-te că rulezi pe **.NET Framework** (4.x).
3. Apasă `F5` sau `Start` pentru a rula jocul.
4. Joacă folosind tastatura.

---

## 📂 Structura proiectului

```
Breakoutio/
├── Form1.cs                # Logica principală a jocului
├── Form1.Designer.cs       # Interfața grafică
├── Program.cs              # Punctul de pornire al aplicației
├── Breakoutio.csproj       # Fișierul proiectului Visual Studio
```

---

## ✅ Cerințe

- Windows
- .NET Framework (4.x)
- Visual Studio 2015 sau mai nou (cu suport pentru Windows Forms)

---

## 🛠️ Creat pentru

Acest proiect a fost realizat ca parte a **atestatului la informatică** și este ideal pentru a învăța elemente de bază ale programării orientate pe evenimente și ale interfeței grafice în C#.

---
