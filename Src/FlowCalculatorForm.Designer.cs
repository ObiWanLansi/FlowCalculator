namespace FlowCalculator
{
    partial class FlowCalculatorForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbMeasurements = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtbMeasurement1 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement4 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement5 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement6 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement7 = new System.Windows.Forms.MaskedTextBox();
            this.mtbMeasurement8 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbDuesenDurch = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtbQuellung = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtbTotal = new System.Windows.Forms.MaskedTextBox();
            this.mtbAverage = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowRechnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMeasurements.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMeasurements
            // 
            this.gbMeasurements.Controls.Add(this.mtbMeasurement8);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement7);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement6);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement5);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement4);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement3);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement2);
            this.gbMeasurements.Controls.Add(this.mtbMeasurement1);
            this.gbMeasurements.Controls.Add(this.label8);
            this.gbMeasurements.Controls.Add(this.label7);
            this.gbMeasurements.Controls.Add(this.label6);
            this.gbMeasurements.Controls.Add(this.label5);
            this.gbMeasurements.Controls.Add(this.label4);
            this.gbMeasurements.Controls.Add(this.label3);
            this.gbMeasurements.Controls.Add(this.label2);
            this.gbMeasurements.Controls.Add(this.label1);
            this.gbMeasurements.Location = new System.Drawing.Point(10, 40);
            this.gbMeasurements.Name = "gbMeasurements";
            this.gbMeasurements.Size = new System.Drawing.Size(170, 270);
            this.gbMeasurements.TabIndex = 0;
            this.gbMeasurements.TabStop = false;
            this.gbMeasurements.Text = "Messungen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messung 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Messung 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Messung 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Messung 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Messung 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Messung 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Messung 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Messung 8";
            // 
            // mtbMeasurement1
            // 
            this.mtbMeasurement1.AsciiOnly = true;
            this.mtbMeasurement1.Location = new System.Drawing.Point(80, 30);
            this.mtbMeasurement1.Mask = "##,##";
            this.mtbMeasurement1.Name = "mtbMeasurement1";
            this.mtbMeasurement1.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement1.TabIndex = 8;
            this.mtbMeasurement1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement2
            // 
            this.mtbMeasurement2.AsciiOnly = true;
            this.mtbMeasurement2.Location = new System.Drawing.Point(80, 60);
            this.mtbMeasurement2.Mask = "##,##";
            this.mtbMeasurement2.Name = "mtbMeasurement2";
            this.mtbMeasurement2.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement2.TabIndex = 9;
            this.mtbMeasurement2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement3
            // 
            this.mtbMeasurement3.AsciiOnly = true;
            this.mtbMeasurement3.Location = new System.Drawing.Point(80, 90);
            this.mtbMeasurement3.Mask = "##,##";
            this.mtbMeasurement3.Name = "mtbMeasurement3";
            this.mtbMeasurement3.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement3.TabIndex = 10;
            this.mtbMeasurement3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement4
            // 
            this.mtbMeasurement4.AsciiOnly = true;
            this.mtbMeasurement4.Location = new System.Drawing.Point(80, 120);
            this.mtbMeasurement4.Mask = "##,##";
            this.mtbMeasurement4.Name = "mtbMeasurement4";
            this.mtbMeasurement4.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement4.TabIndex = 11;
            this.mtbMeasurement4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement5
            // 
            this.mtbMeasurement5.AsciiOnly = true;
            this.mtbMeasurement5.Location = new System.Drawing.Point(80, 150);
            this.mtbMeasurement5.Mask = "##,##";
            this.mtbMeasurement5.Name = "mtbMeasurement5";
            this.mtbMeasurement5.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement5.TabIndex = 12;
            this.mtbMeasurement5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement6
            // 
            this.mtbMeasurement6.AsciiOnly = true;
            this.mtbMeasurement6.Location = new System.Drawing.Point(80, 180);
            this.mtbMeasurement6.Mask = "##,##";
            this.mtbMeasurement6.Name = "mtbMeasurement6";
            this.mtbMeasurement6.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement6.TabIndex = 13;
            this.mtbMeasurement6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement7
            // 
            this.mtbMeasurement7.AsciiOnly = true;
            this.mtbMeasurement7.Location = new System.Drawing.Point(80, 210);
            this.mtbMeasurement7.Mask = "##,##";
            this.mtbMeasurement7.Name = "mtbMeasurement7";
            this.mtbMeasurement7.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement7.TabIndex = 14;
            this.mtbMeasurement7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbMeasurement8
            // 
            this.mtbMeasurement8.AsciiOnly = true;
            this.mtbMeasurement8.Location = new System.Drawing.Point(80, 240);
            this.mtbMeasurement8.Mask = "##,##";
            this.mtbMeasurement8.Name = "mtbMeasurement8";
            this.mtbMeasurement8.Size = new System.Drawing.Size(70, 20);
            this.mtbMeasurement8.TabIndex = 15;
            this.mtbMeasurement8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbDuesenDurch);
            this.groupBox1.Location = new System.Drawing.Point(190, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Düsendurchschnitt";
            // 
            // mtbDuesenDurch
            // 
            this.mtbDuesenDurch.AsciiOnly = true;
            this.mtbDuesenDurch.Location = new System.Drawing.Point(10, 20);
            this.mtbDuesenDurch.Mask = "##,##";
            this.mtbDuesenDurch.Name = "mtbDuesenDurch";
            this.mtbDuesenDurch.Size = new System.Drawing.Size(90, 20);
            this.mtbDuesenDurch.TabIndex = 9;
            this.mtbDuesenDurch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtbQuellung);
            this.groupBox2.Location = new System.Drawing.Point(190, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 50);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inklusive Quellung";
            // 
            // mtbQuellung
            // 
            this.mtbQuellung.AsciiOnly = true;
            this.mtbQuellung.Location = new System.Drawing.Point(10, 20);
            this.mtbQuellung.Mask = "##,##";
            this.mtbQuellung.Name = "mtbQuellung";
            this.mtbQuellung.ReadOnly = true;
            this.mtbQuellung.Size = new System.Drawing.Size(90, 20);
            this.mtbQuellung.TabIndex = 9;
            this.mtbQuellung.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtbAverage);
            this.groupBox3.Controls.Add(this.mtbTotal);
            this.groupBox3.Location = new System.Drawing.Point(10, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(170, 60);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ergebnis";
            // 
            // mtbTotal
            // 
            this.mtbTotal.AsciiOnly = true;
            this.mtbTotal.Location = new System.Drawing.Point(10, 30);
            this.mtbTotal.Mask = "##,##";
            this.mtbTotal.Name = "mtbTotal";
            this.mtbTotal.ReadOnly = true;
            this.mtbTotal.Size = new System.Drawing.Size(70, 20);
            this.mtbTotal.TabIndex = 10;
            this.mtbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbAverage
            // 
            this.mtbAverage.AsciiOnly = true;
            this.mtbAverage.Location = new System.Drawing.Point(90, 30);
            this.mtbAverage.Mask = "##,##";
            this.mtbAverage.Name = "mtbAverage";
            this.mtbAverage.ReadOnly = true;
            this.mtbAverage.Size = new System.Drawing.Size(70, 20);
            this.mtbAverage.TabIndex = 11;
            this.mtbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowRechnerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 390);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flowRechnerToolStripMenuItem
            // 
            this.flowRechnerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beendenToolStripMenuItem});
            this.flowRechnerToolStripMenuItem.Name = "flowRechnerToolStripMenuItem";
            this.flowRechnerToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.flowRechnerToolStripMenuItem.Text = "&Flow Rechner";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.beendenToolStripMenuItem.Text = "&Beenden";
            // 
            // FlowCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 412);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbMeasurements);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FlowCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flow Rechner";
            this.gbMeasurements.ResumeLayout(false);
            this.gbMeasurements.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMeasurements;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement8;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement7;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement6;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement5;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement4;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement3;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement2;
        private System.Windows.Forms.MaskedTextBox mtbMeasurement1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mtbDuesenDurch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtbQuellung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mtbAverage;
        private System.Windows.Forms.MaskedTextBox mtbTotal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem flowRechnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

