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
        private string[] questions = {
            "1.) Melyik az alapvető osztály a C# programozási nyelvben?",
            "2.) Mi a C# nyelv egyik fő jellemzője?",
            "3.) Milyen kulcsszót használunk a C# osztályok öröklődésének deklarálásához?",
            "4.) Milyen kulcsszót használunk a C# osztályok absztrakt osztályként való deklarálásához?",
            "5.) Melyik kulcsszót használjuk a C#-ban egy osztály metódusainak és tulajdonságainak elrejtésére?",
            "6.) Melyik az a függvény, ami automatikusan meghívódik egy osztály példányosításakor?",
            "7.) Milyen módosítóval rendelkező tagváltozókra nincs közvetlen hozzáférés a leszármazott osztályokból C#-ban?",
            "8.) Melyik kulcsszót használjuk a C#-ban az interfész definíciójának megadásához?",
            "9.) Mi az az öröklődési mód, amikor egy osztály több interfészt is implementál?",
            "10.) Melyik az az attribútum, amely lehetővé teszi az osztály és interfész metadatának kezelését a C# nyelvben?",
            "11.) Melyik módosítóval rendelkező tagváltozókhoz lehet hozzáférni az adott osztályon kívülről is a C# nyelvben?",
            "12.) Melyik kulcsszóval tudunk hivatkozni az aktuális osztály egy másik konstruktorára C#-ban?",
            "13.) Melyik módosítóval rendelkező tagváltozókhoz lehet hozzáférni csak az adott osztályon belül a C# nyelvben?",
            "13+1.) Az alábbiak közül melyik C# objektumok ?"
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
            new string[]{"a) private", "b) protected", "c) public"},
            new string[]{ "a) A List<T> osztály példányai.", "b) A Dictionary<TKey, TValue> osztály példányai.", "c)     A StringBuilder osztály példányai."}
        };

        private char[] correctAnswers = {
            'c', 'b', 'b', 'a', 'b', 'c', 'b', 'a', 'b', 'b', 'b', 'a', 'a','a'
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
        }




        private void next_Click_1(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex < questions.Length)
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                int totalQuestions = questions.Length;
                float percentage = (float)point / totalQuestions * 100;
                MessageBox.Show("Quiz Finished!\nYour Score: " + percentage.ToString("0.00") + "%");

                // Check if the score is less than 60%
                if (percentage < 60)
                {
                    DialogResult result = MessageBox.Show("Your score is less than 60%. Do you want to restart the quiz?", "Restart Quiz", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        // Restart the quiz
                        point = 0;
                        currentQuestionIndex = 0;
                        LoadQuestion(currentQuestionIndex);
                    }
                    else
                    {
                        // Close the window
                        this.Close();
                    }
                }
                else
                {
                    // Close the window
                    this.Close();
                }
            }
        }

        private void ckeckAnsw_Click(object sender, EventArgs e)
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
        }

        
    }
}
