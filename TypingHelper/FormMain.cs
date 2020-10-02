using System;
using System.Windows.Forms;

namespace TypingHelper
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    private void FormMain_Load(object sender, EventArgs e)
    {
      textBoxMain.Text = string.Empty;
    }

    private void ButtonHelp1_Click(object sender, EventArgs e)
    {
      textBoxMain.Text += $"Bonjour,{Environment.NewLine}";
    }

    private void ButtonHelper2_Click(object sender, EventArgs e)
    {
      textBoxMain.Text += $"Le prix de la cotisation est de 170€ pour l'année.{Environment.NewLine}";
    }

    private void ButtonHelper3_Click(object sender, EventArgs e)
    {
      textBoxMain.Text += $"L'entrainement des compétiteurs a lieu le mardi soir de 19h30 à 21h30.{Environment.NewLine}";
    }

    private void ButtonHelper99_Click(object sender, EventArgs e)
    {
      textBoxMain.Text += $"Cordialement,{Environment.NewLine}Le secrétaire";
    }
  }
}
