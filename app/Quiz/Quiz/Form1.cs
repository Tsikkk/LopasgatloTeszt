using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        bool addPoint=false;
        
        private string[] questions = {
            "Melyik az alapvető osztály a C# programozási nyelvben?",
            "Mi a C# nyelv egyik fő jellemzője?",
            "Milyen kulcsszót használunk a C# osztályok öröklődésének deklarálásához?",
            "Milyen kulcsszót használunk a C# osztályok absztrakt osztályként való deklarálásához?",
            "Melyik kulcsszót használjuk a C#-ban egy osztály metódusainak és tulajdonságainak elrejtésére?",
            "Melyik az a függvény, ami automatikusan meghívódik egy osztály példányosításakor?",
            "Milyen módosítóval rendelkező tagváltozókra nincs közvetlen hozzáférés a leszármazott osztályokból C#-ban?",
            "Melyik kulcsszót használjuk a C#-ban az interfész definíciójának megadásához?",
            "Mi az az öröklődési mód, amikor egy osztály több interfészt is implementál?",
            "Melyik az az attribútum, amely lehetővé teszi az osztály és interfész metadatának kezelését a C# nyelvben?",
            "Melyik módosítóval rendelkező tagváltozókhoz lehet hozzáférni az adott osztályon kívülről is a C# nyelvben?",
            "Melyik kulcsszóval tudunk hivatkozni az aktuális osztály egy másik konstruktorára C#-ban?",
            "Melyik módosítóval rendelkező tagváltozókhoz lehet hozzáférni csak az adott osztályon belül a C# nyelvben?"
        };

        private string[][] answers = {
            new string[]{"a) Base", "b) Main", "c) Object"},
            new string[]{"a) Dinamikus típusú nyelv", "b) Szigorúan típusbiztos nyelv", "c) Logikai nyelv"},
            new string[]{"a) extend", "b) inherits", "c) extends"},
            new string[]{"a) abstract", "b) final", "c) sealed"},
            new string[]{"a) override", "b) private", "c) hide"},
            new string[]{"a) construct()", "b) init()", "c) constructor()"},
            new string[]{"a) protected", "b) private", "c) public"},
            new string[]{"a) interface", "b) implements", "c) extends"},
            new string[]{"a) Multi-level inheritance", "b) Multiple inheritance", "c) Hierarchical inheritance"},
            new string[]{"a) [metadata]", "b) [attribute]", "c) [annotation]"},
            new string[]{"a) private", "b) public", "c) protected"},
            new string[]{"a) this", "b) super", "c) self"},
            new string[]{"a) private", "b) protected", "c) public"}
        };

        private char[] correctAnswers = {
            'c', 'b', 'b', 'a', 'b', 'c', 'b', 'a', 'b', 'b', 'b', 'a', 'a'
        };
        private int point = 0;

        private int currentQuestionIndex = 0;

        public Form1()
        {
            InitializeComponent();
            LoadQuestion(currentQuestionIndex);
        }

        private void LoadQuestion(int index)
        {
            kerdes.Text = questions[index];
            valasz1.Text = answers[index][0];
            valasz2.Text = answers[index][1];
            valasz3.Text = answers[index][2];
            valasz1.ForeColor = valasz2.ForeColor = valasz3.ForeColor = Color.Black; // Reset colors
            valasz1C.Checked = valasz2C.Checked = valasz3C.Checked = false; // Reset checkboxes
            pont.Text = "Pontok: " + point;
        }




        private void next_Click_1(object sender, EventArgs e)
        {
            check();
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Length)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                MessageBox.Show("Quiz Finished!");
                // Optionally, you can reset the quiz here.
                currentQuestionIndex = 0;
                LoadQuestion(currentQuestionIndex);
            }
            addPoint = false;
        }
        private void check()
        {
            char userAnswer = ' ';
            if (valasz1C.Checked)
                userAnswer = 'a';
            else if (valasz2C.Checked)
                userAnswer = 'b';
            else if (valasz3C.Checked)
                userAnswer = 'c';

            // Highlight correct answer in green
            switch (correctAnswers[currentQuestionIndex])
            {
                case 'a':
                    valasz1.ForeColor = Color.Green;
                    break;
                case 'b':
                    valasz2.ForeColor = Color.Green;
                    break;
                case 'c':
                    valasz3.ForeColor = Color.Green;
                    break;
            }

            // Highlight incorrect answers in red and the user's answer
            switch (userAnswer)
            {
                case 'a':
                    if (userAnswer != correctAnswers[currentQuestionIndex])
                        valasz1.ForeColor = Color.Red;
                    break;
                case 'b':
                    if (userAnswer != correctAnswers[currentQuestionIndex])
                        valasz2.ForeColor = Color.Red;
                    break;
                case 'c':
                    if (userAnswer != correctAnswers[currentQuestionIndex])
                        valasz3.ForeColor = Color.Red;
                    break;
            }
            if (userAnswer== correctAnswers[currentQuestionIndex] && addPoint==false)
            {
                point++;
            }
            pont.Text = "Pontok: " + point;

        }
        

        private void ckeckAnsw_Click(object sender, EventArgs e)
        {
            check();
            addPoint = true;
        }

        
    }
}
