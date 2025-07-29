# 🎮 Final Project – Breakout Game in C# (Windows Forms)

**Breakout** is a classic arcade game, created as a final school project using C# and Windows Forms. The player controls a paddle to bounce a ball and break the blocks on the screen. The objective is to destroy all blocks without letting the ball fall.

---

## 🧩 Features

- Smooth paddle movement (left/right).
- 3 rows of 5 blocks each (total of 15 blocks).
- Randomly colored blocks.
- Dynamic scoring system.
- Win/Lose messages.
- Pause and resume functionality.
- Keyboard-only controls.

---

## 📺 User Interface

The UI consists of the following components:

- `Label txtScor`: Displays the score and game messages.
- `PictureBox jucator`: The paddle controlled by the player.
- `PictureBox bila`: The ball that bounces off the paddle and blocks.
- `Timer timerjoc`: Controls ball movement and game logic every 20 ms.

The window has a fixed size of `1207 x 704` pixels, black background, and is fully controlled by the keyboard.

---

## 🎮 Controls

| Key         | Function                          |
|-------------|-----------------------------------|
| ⬅️ / A       | Move paddle to the left           |
| ➡️ / D       | Move paddle to the right          |
| ⏸ P         | Pause the game                    |
| ⏎ Enter     | Start / Resume the game           |
| ⎋ Escape    | Exit the game                     |

---

## 🎯 Objective

- Each broken block adds 1 point to the score.
- At 15 points: intermediate win message.
- At 30 points: final win message – all blocks are broken!
- If the ball falls below the paddle: game over.

---

## 🧠 Game Logic (Summary)

- The ball moves diagonally and bounces off the walls and paddle.
- Collisions with the paddle and blocks change the ball's direction and speed.
- Blocks are destroyed on contact and removed from the window.
- When the game ends (win/loss), the player can press Enter to restart.

---

## ▶️ How to Run

1. Open the solution in **Visual Studio**.
2. Make sure you're targeting **.NET Framework** (4.x).
3. Press `F5` or click `Start` to run the game.
4. Use the keyboard to play.

---

## 📂 Project Structure

```
Breakoutio/
├── Form1.cs                # Main game logic
├── Form1.Designer.cs       # Graphical interface
├── Program.cs              # Application entry point
├── Breakoutio.csproj       # Visual Studio project file
```

---

## 🛠️ Created For

This project was developed as part of a **final computer science exam** and is ideal for learning the basics of event-driven programming and graphical interfaces in C#.
