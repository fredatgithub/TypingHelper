namespace TypingHelper
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      this.textBoxMain = new System.Windows.Forms.TextBox();
      this.buttonHelp1 = new System.Windows.Forms.Button();
      this.buttonHelper2 = new System.Windows.Forms.Button();
      this.buttonHelper3 = new System.Windows.Forms.Button();
      this.buttonHelper99 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxMain
      // 
      this.textBoxMain.Location = new System.Drawing.Point(397, 39);
      this.textBoxMain.Multiline = true;
      this.textBoxMain.Name = "textBoxMain";
      this.textBoxMain.Size = new System.Drawing.Size(368, 349);
      this.textBoxMain.TabIndex = 0;
      // 
      // buttonHelp1
      // 
      this.buttonHelp1.Location = new System.Drawing.Point(26, 39);
      this.buttonHelp1.Name = "buttonHelp1";
      this.buttonHelp1.Size = new System.Drawing.Size(75, 23);
      this.buttonHelp1.TabIndex = 1;
      this.buttonHelp1.Text = "Bonjour";
      this.buttonHelp1.UseVisualStyleBackColor = true;
      this.buttonHelp1.Click += new System.EventHandler(this.ButtonHelp1_Click);
      // 
      // buttonHelper2
      // 
      this.buttonHelper2.Location = new System.Drawing.Point(26, 77);
      this.buttonHelper2.Name = "buttonHelper2";
      this.buttonHelper2.Size = new System.Drawing.Size(131, 23);
      this.buttonHelper2.TabIndex = 2;
      this.buttonHelper2.Text = "Le prix de la cotisation";
      this.buttonHelper2.UseVisualStyleBackColor = true;
      this.buttonHelper2.Click += new System.EventHandler(this.ButtonHelper2_Click);
      // 
      // buttonHelper3
      // 
      this.buttonHelper3.Location = new System.Drawing.Point(26, 124);
      this.buttonHelper3.Name = "buttonHelper3";
      this.buttonHelper3.Size = new System.Drawing.Size(199, 23);
      this.buttonHelper3.TabIndex = 3;
      this.buttonHelper3.Text = "L\'entrainement des compétiteurs";
      this.buttonHelper3.UseVisualStyleBackColor = true;
      this.buttonHelper3.Click += new System.EventHandler(this.ButtonHelper3_Click);
      // 
      // buttonHelper99
      // 
      this.buttonHelper99.Location = new System.Drawing.Point(26, 365);
      this.buttonHelper99.Name = "buttonHelper99";
      this.buttonHelper99.Size = new System.Drawing.Size(92, 23);
      this.buttonHelper99.TabIndex = 4;
      this.buttonHelper99.Text = "Cordialement";
      this.buttonHelper99.UseVisualStyleBackColor = true;
      this.buttonHelper99.Click += new System.EventHandler(this.ButtonHelper99_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonHelper99);
      this.Controls.Add(this.buttonHelper3);
      this.Controls.Add(this.buttonHelper2);
      this.Controls.Add(this.buttonHelp1);
      this.Controls.Add(this.textBoxMain);
      this.Name = "FormMain";
      this.Text = "Typing helper";
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxMain;
    private System.Windows.Forms.Button buttonHelp1;
    private System.Windows.Forms.Button buttonHelper2;
    private System.Windows.Forms.Button buttonHelper3;
    private System.Windows.Forms.Button buttonHelper99;
  }
}

