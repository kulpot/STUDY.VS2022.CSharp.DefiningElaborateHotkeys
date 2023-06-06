using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ref link:https://www.youtube.com/watch?v=h5rK1BAs99Q&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=58
// msdn.microsoft.com/en-us/library/system.windows.forms.keys.aspx
//

namespace DefiningElaborateHotkeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            Array keyArray = typeof(Keys).GetEnumValues();

            foreach (Keys key in keyArray)
            {
                comboFirstKey.Items.Add(key);
                comboSecondKey.Items.Add(key);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Keys key1 = (Keys)comboFirstKey.SelectedItem;
            Keys key2 = (Keys)comboSecondKey.SelectedItem;

            txtResult.Text = (key1 | key2).ToString();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            /*if (e.KeyCode == (Keys.E | Keys.F))
            {
                this.Text = e.KeyCode.ToString();
            }*/

            bool cPressed = Keyboard.IsKeyPressed(Keys.C);
            bool kPressed = Keyboard.IsKeyPressed(Keys.K);
            bool ctrlPressed = Keyboard.IsKeyPressed(Keys.ControlKey);

            this.Text = (ctrlPressed && cPressed && kPressed).ToString();
        }
    }
}
