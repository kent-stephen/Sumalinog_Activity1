using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchAlgo
{
    public partial class Sumalinog_Activity1_BFS : Form
    {
        private System.Windows.Forms.Button[] buttons = new System.Windows.Forms.Button[36];
        int[] maze = new int[36];
        int start = 0;
        int goal = 0;
        bool isStart = false;
        bool isGoal = false;

        public Sumalinog_Activity1_BFS()
        {
            InitializeComponent();

            int y = 0;
            int x = 0;
            for (int i = 0; i < 36; i++)
            {
                if (i % 6 == 0 && i != 0)
                {
                    y++;
                    x = 0;
                }
                this.buttons[i] = new System.Windows.Forms.Button();
                this.buttons[i].Location = new System.Drawing.Point(28+x*39, 104+y*29);
                this.buttons[i].BackColor = System.Drawing.SystemColors.Control;
                this.buttons[i].Name = "button"+i+1;
                this.buttons[i].Size = new System.Drawing.Size(40, 30);
                this.buttons[i].TabIndex = 4+i+1;
                int temp = i + 1;
                this.buttons[i].Text = temp+"";
                this.buttons[i].UseVisualStyleBackColor = true;
                this.buttons[i].Click += new System.EventHandler(this.buttons_Click);

                this.Controls.Add(this.buttons[i]);
                x++;
            }

            for(int i = 0; i < 36; i++)
            {
                maze[i] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyQueue q = new MyQueue();

            label.Text = "Maze Path!";

            maze[start] = 1;
            maze[goal] = 2;

            int Q = -1, origin = start;

            try
            {
                while (origin != goal)
                {
                    if (origin>5 && maze[origin - 6] != -1 && !q.contains(origin - 6))
                    {
                        Q = origin - 6;
                        q.enque(Q, origin);
                    }
                    if (origin<30 && maze[origin + 6] != -1 && !q.contains(origin + 6))
                    {
                        Q = origin + 6;
                        q.enque(Q, origin);
                    }
                    if (origin % 6 != 0 && maze[origin - 1] != -1 && !q.contains(origin - 1))
                    {
                        Q = origin - 1;
                        q.enque(Q, origin);
                    }
                    if ((origin + 1) % 6 != 0 && maze[origin + 1] != -1 && !q.contains(origin + 1))
                    {
                        Q = origin + 1;
                        q.enque(Q, origin);
                    }
                    origin = q.next(origin);
                }
                
                foreach(int n in q.getPath(start, goal))
                {
                    buttons[n].BackColor = System.Drawing.Color.Blue;
                }
            }
            catch (Exception er)
            {
                label.Text = "Can't find path, might be trapped";
            }
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (cb_Select.SelectedIndex == 0)
            {
                if (btn.BackColor == System.Drawing.Color.Yellow)
                {
                    btn.BackColor = System.Drawing.SystemColors.Control;
                    isStart = false;
                    start = 0;
                    label.Text = "Choose Starting State";
                }
                else
                {
                    if (isStart == false)
                    {
                        btn.BackColor = System.Drawing.Color.Yellow;
                        start = Int16.Parse(btn.Text) - 1;
                        isStart = true;
                    }
                    else
                    {
                        label.Text = "Start state already chosen";
                    }
                }
               
                
            }
            else if (cb_Select.SelectedIndex == 1)
            {
                if (btn.BackColor == System.Drawing.Color.Red)
                {
                    btn.BackColor = System.Drawing.SystemColors.Control;
                    isGoal = false;
                    goal = 0;
                    label.Text = "Choose Goal State";
                }
                else
                {
                    if (isGoal == false)
                    {
                        btn.BackColor = System.Drawing.Color.Red;
                        goal = Int16.Parse(btn.Text) - 1;
                        isGoal = true;
                    }
                    else
                    {
                        label.Text = "Goal state is already chosen";
                    }
                }
                
                
            }
            else if (cb_Select.SelectedIndex == 2)
            {
                if (btn.BackColor == System.Drawing.SystemColors.Control)
                    btn.BackColor = System.Drawing.Color.Green;
                else
                    btn.BackColor = System.Drawing.SystemColors.Control;
            }
        
            btn.UseVisualStyleBackColor = false;
            maze[Int16.Parse(btn.Text)-1] = -1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            start = 0;
            goal = 0;
            isStart = false;
            isGoal = false;
            for (int i = 0; i < 36; i++)
            {
                maze[i] = 0;
                buttons[i].BackColor = System.Drawing.SystemColors.Control;

            }
            label.Text = "Maze Reset!";

        }

        private void cb_Select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Select.SelectedIndex == 0)
            {
                label.Text = "Choose Starting State";
            }
            else if (cb_Select.SelectedIndex == 1)
            {
                label.Text = "Choose Goal State";
            }
            else if (cb_Select.SelectedIndex == 2)
            {
                label.Text = "Click where to assign obstacle!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
