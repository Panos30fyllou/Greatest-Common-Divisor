
namespace Greatest_Common_Divisor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.subjectTitle = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.algorithmTitleLabel = new System.Windows.Forms.Label();
            this.algorithmLabel = new System.Windows.Forms.Label();
            this.exampleLabel = new System.Windows.Forms.Label();
            this.algorithm1 = new System.Windows.Forms.Label();
            this.algorithm1Label = new System.Windows.Forms.Label();
            this.algorithm2Label = new System.Windows.Forms.Label();
            this.algorithm2 = new System.Windows.Forms.Label();
            this.execTitleLabel = new System.Windows.Forms.Label();
            this.alg1X = new System.Windows.Forms.TextBox();
            this.execAlg1Label = new System.Windows.Forms.Label();
            this.alg1Y = new System.Windows.Forms.TextBox();
            this.execAlg1Button = new System.Windows.Forms.Button();
            this.exec1TimeLabel = new System.Windows.Forms.Label();
            this.mdk1Label = new System.Windows.Forms.Label();
            this.mdk2Label = new System.Windows.Forms.Label();
            this.exec2TimeLabel = new System.Windows.Forms.Label();
            this.execAlg2Button = new System.Windows.Forms.Button();
            this.alg2Y = new System.Windows.Forms.TextBox();
            this.execAlg2Label = new System.Windows.Forms.Label();
            this.alg2X = new System.Windows.Forms.TextBox();
            this.alg1XLabel = new System.Windows.Forms.Label();
            this.alg1YLabel = new System.Windows.Forms.Label();
            this.alg2YLabel = new System.Windows.Forms.Label();
            this.alg2XLabel = new System.Windows.Forms.Label();
            this.conclusionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // subjectTitle
            // 
            this.subjectTitle.AutoSize = true;
            this.subjectTitle.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.subjectTitle.Location = new System.Drawing.Point(157, 9);
            this.subjectTitle.Name = "subjectTitle";
            this.subjectTitle.Size = new System.Drawing.Size(474, 33);
            this.subjectTitle.TabIndex = 0;
            this.subjectTitle.Text = "ΕΥΡΕΣΗ ΜΕΓΙΣΤΟΥ ΚΟΙΝΟΥ ΔΙΑΙΡΑΙΤΗ";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.nextButton.Location = new System.Drawing.Point(681, 818);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(107, 23);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "ΕΠΟΜΕΝΟ";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.next_Click);
            // 
            // algorithmTitleLabel
            // 
            this.algorithmTitleLabel.AutoSize = true;
            this.algorithmTitleLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithmTitleLabel.Location = new System.Drawing.Point(246, 66);
            this.algorithmTitleLabel.Name = "algorithmTitleLabel";
            this.algorithmTitleLabel.Size = new System.Drawing.Size(279, 25);
            this.algorithmTitleLabel.TabIndex = 2;
            this.algorithmTitleLabel.Text = "Η έννοια του αλγορίθμου";
            this.algorithmTitleLabel.Visible = false;
            // 
            // algorithmLabel
            // 
            this.algorithmLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithmLabel.Location = new System.Drawing.Point(251, 91);
            this.algorithmLabel.Name = "algorithmLabel";
            this.algorithmLabel.Size = new System.Drawing.Size(274, 112);
            this.algorithmLabel.TabIndex = 3;
            this.algorithmLabel.Text = "Αλγόριθμος είναι μια πεπερασμένη σειρά ενεργειών, αυστηρά καθορισμένων και εκτελέ" +
    "σιμων σε πεπερασμένο χρόνο, που στοχεύουν στην επίλυση ενός προβλήματος.";
            this.algorithmLabel.Visible = false;
            // 
            // exampleLabel
            // 
            this.exampleLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exampleLabel.Location = new System.Drawing.Point(179, 203);
            this.exampleLabel.Name = "exampleLabel";
            this.exampleLabel.Size = new System.Drawing.Size(405, 53);
            this.exampleLabel.TabIndex = 4;
            this.exampleLabel.Text = "Στο παράδειγμα μας, το πρόβλημα είναι η εύρεση του μέγιστου κοινού διαιρέτη δυο α" +
    "ριθμών x, y.";
            this.exampleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exampleLabel.Visible = false;
            // 
            // algorithm1
            // 
            this.algorithm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithm1.Location = new System.Drawing.Point(175, 286);
            this.algorithm1.Name = "algorithm1";
            this.algorithm1.Size = new System.Drawing.Size(191, 238);
            this.algorithm1.TabIndex = 5;
            this.algorithm1.Text = "Αλγόριθμος ΜΚΔ\n Δεδομένα // x,y //\n Αν x < y τότε\n    z ← x\n αλλιώς\n    z ← y\n Τέ" +
    "λος_αν\n Όσο (x mod z ≠ 0) ή (y mod z ≠ 0) επανάλαβε\n      z ← z-1\n Τέλος_επανάλη" +
    "ψης\n Αποτελέσματα // z //\n Τέλος ΜΚΔ";
            this.algorithm1.Visible = false;
            // 
            // algorithm1Label
            // 
            this.algorithm1Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithm1Label.Location = new System.Drawing.Point(175, 258);
            this.algorithm1Label.Name = "algorithm1Label";
            this.algorithm1Label.Size = new System.Drawing.Size(200, 28);
            this.algorithm1Label.TabIndex = 6;
            this.algorithm1Label.Text = "Αλγόριθμος 1";
            this.algorithm1Label.Visible = false;
            // 
            // algorithm2Label
            // 
            this.algorithm2Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithm2Label.Location = new System.Drawing.Point(410, 258);
            this.algorithm2Label.Name = "algorithm2Label";
            this.algorithm2Label.Size = new System.Drawing.Size(174, 28);
            this.algorithm2Label.TabIndex = 8;
            this.algorithm2Label.Text = "Αλγόριθμος 2";
            this.algorithm2Label.Visible = false;
            // 
            // algorithm2
            // 
            this.algorithm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.algorithm2.Location = new System.Drawing.Point(410, 286);
            this.algorithm2.Name = "algorithm2";
            this.algorithm2.Size = new System.Drawing.Size(174, 189);
            this.algorithm2.TabIndex = 7;
            this.algorithm2.Text = "Αλγόριθμος Ευκλείδης\n Δεδομένα // x,y //\n z ← y\n Όσο z ≠ 0 επανάλαβε\n     z ← x m" +
    "od y\n     x ← y\n     y ← z\n Τέλος_επανάληψης\n Αποτελέσματα // x //\n Τέλος Ευκλεί" +
    "δης";
            this.algorithm2.Visible = false;
            // 
            // execTitleLabel
            // 
            this.execTitleLabel.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execTitleLabel.Location = new System.Drawing.Point(232, 536);
            this.execTitleLabel.Name = "execTitleLabel";
            this.execTitleLabel.Size = new System.Drawing.Size(302, 24);
            this.execTitleLabel.TabIndex = 9;
            this.execTitleLabel.Text = "Εκτέλεση των αλγορίθμων";
            this.execTitleLabel.Visible = false;
            // 
            // alg1X
            // 
            this.alg1X.Location = new System.Drawing.Point(193, 613);
            this.alg1X.Name = "alg1X";
            this.alg1X.Size = new System.Drawing.Size(60, 20);
            this.alg1X.TabIndex = 10;
            this.alg1X.Visible = false;
            // 
            // execAlg1Label
            // 
            this.execAlg1Label.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execAlg1Label.Location = new System.Drawing.Point(175, 591);
            this.execAlg1Label.Name = "execAlg1Label";
            this.execAlg1Label.Size = new System.Drawing.Size(191, 19);
            this.execAlg1Label.TabIndex = 11;
            this.execAlg1Label.Text = "Αλγόριθμος 1";
            this.execAlg1Label.Visible = false;
            // 
            // alg1Y
            // 
            this.alg1Y.Location = new System.Drawing.Point(193, 639);
            this.alg1Y.Name = "alg1Y";
            this.alg1Y.Size = new System.Drawing.Size(60, 20);
            this.alg1Y.TabIndex = 12;
            this.alg1Y.Visible = false;
            // 
            // execAlg1Button
            // 
            this.execAlg1Button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execAlg1Button.Location = new System.Drawing.Point(178, 665);
            this.execAlg1Button.Name = "execAlg1Button";
            this.execAlg1Button.Size = new System.Drawing.Size(75, 23);
            this.execAlg1Button.TabIndex = 13;
            this.execAlg1Button.Text = "Εκτέλεση";
            this.execAlg1Button.UseVisualStyleBackColor = true;
            this.execAlg1Button.Visible = false;
            this.execAlg1Button.Click += new System.EventHandler(this.execAlg1_Click);
            // 
            // exec1TimeLabel
            // 
            this.exec1TimeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exec1TimeLabel.Location = new System.Drawing.Point(175, 710);
            this.exec1TimeLabel.Name = "exec1TimeLabel";
            this.exec1TimeLabel.Size = new System.Drawing.Size(191, 19);
            this.exec1TimeLabel.TabIndex = 14;
            this.exec1TimeLabel.Text = "Χρόνος Εκτέλεσης:";
            this.exec1TimeLabel.Visible = false;
            // 
            // mdk1Label
            // 
            this.mdk1Label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mdk1Label.Location = new System.Drawing.Point(175, 691);
            this.mdk1Label.Name = "mdk1Label";
            this.mdk1Label.Size = new System.Drawing.Size(191, 19);
            this.mdk1Label.TabIndex = 15;
            this.mdk1Label.Text = "ΜΚΔ:";
            this.mdk1Label.Visible = false;
            // 
            // mdk2Label
            // 
            this.mdk2Label.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.mdk2Label.Location = new System.Drawing.Point(410, 691);
            this.mdk2Label.Name = "mdk2Label";
            this.mdk2Label.Size = new System.Drawing.Size(191, 19);
            this.mdk2Label.TabIndex = 21;
            this.mdk2Label.Text = "ΜΚΔ:";
            this.mdk2Label.Visible = false;
            // 
            // exec2TimeLabel
            // 
            this.exec2TimeLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.exec2TimeLabel.Location = new System.Drawing.Point(410, 710);
            this.exec2TimeLabel.Name = "exec2TimeLabel";
            this.exec2TimeLabel.Size = new System.Drawing.Size(191, 19);
            this.exec2TimeLabel.TabIndex = 20;
            this.exec2TimeLabel.Text = "Χρόνος Εκτέλεσης:";
            this.exec2TimeLabel.Visible = false;
            // 
            // execAlg2Button
            // 
            this.execAlg2Button.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execAlg2Button.Location = new System.Drawing.Point(413, 665);
            this.execAlg2Button.Name = "execAlg2Button";
            this.execAlg2Button.Size = new System.Drawing.Size(75, 23);
            this.execAlg2Button.TabIndex = 19;
            this.execAlg2Button.Text = "Εκτέλεση";
            this.execAlg2Button.UseVisualStyleBackColor = true;
            this.execAlg2Button.Visible = false;
            this.execAlg2Button.Click += new System.EventHandler(this.execAlg2_Click);
            // 
            // alg2Y
            // 
            this.alg2Y.Location = new System.Drawing.Point(428, 639);
            this.alg2Y.Name = "alg2Y";
            this.alg2Y.Size = new System.Drawing.Size(60, 20);
            this.alg2Y.TabIndex = 18;
            this.alg2Y.Visible = false;
            // 
            // execAlg2Label
            // 
            this.execAlg2Label.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.execAlg2Label.Location = new System.Drawing.Point(410, 591);
            this.execAlg2Label.Name = "execAlg2Label";
            this.execAlg2Label.Size = new System.Drawing.Size(191, 19);
            this.execAlg2Label.TabIndex = 17;
            this.execAlg2Label.Text = "Αλγόριθμος 2";
            this.execAlg2Label.Visible = false;
            // 
            // alg2X
            // 
            this.alg2X.Location = new System.Drawing.Point(428, 613);
            this.alg2X.Name = "alg2X";
            this.alg2X.Size = new System.Drawing.Size(60, 20);
            this.alg2X.TabIndex = 16;
            this.alg2X.Visible = false;
            // 
            // alg1XLabel
            // 
            this.alg1XLabel.AutoSize = true;
            this.alg1XLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alg1XLabel.Location = new System.Drawing.Point(175, 620);
            this.alg1XLabel.Name = "alg1XLabel";
            this.alg1XLabel.Size = new System.Drawing.Size(14, 16);
            this.alg1XLabel.TabIndex = 22;
            this.alg1XLabel.Text = "x";
            this.alg1XLabel.Visible = false;
            // 
            // alg1YLabel
            // 
            this.alg1YLabel.AutoSize = true;
            this.alg1YLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alg1YLabel.Location = new System.Drawing.Point(175, 646);
            this.alg1YLabel.Name = "alg1YLabel";
            this.alg1YLabel.Size = new System.Drawing.Size(14, 16);
            this.alg1YLabel.TabIndex = 23;
            this.alg1YLabel.Text = "y";
            this.alg1YLabel.Visible = false;
            // 
            // alg2YLabel
            // 
            this.alg2YLabel.AutoSize = true;
            this.alg2YLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alg2YLabel.Location = new System.Drawing.Point(408, 641);
            this.alg2YLabel.Name = "alg2YLabel";
            this.alg2YLabel.Size = new System.Drawing.Size(14, 16);
            this.alg2YLabel.TabIndex = 25;
            this.alg2YLabel.Text = "y";
            this.alg2YLabel.Visible = false;
            // 
            // alg2XLabel
            // 
            this.alg2XLabel.AutoSize = true;
            this.alg2XLabel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.alg2XLabel.Location = new System.Drawing.Point(408, 615);
            this.alg2XLabel.Name = "alg2XLabel";
            this.alg2XLabel.Size = new System.Drawing.Size(14, 16);
            this.alg2XLabel.TabIndex = 24;
            this.alg2XLabel.Text = "x";
            this.alg2XLabel.Visible = false;
            // 
            // conclusionLabel
            // 
            this.conclusionLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.conclusionLabel.Location = new System.Drawing.Point(179, 753);
            this.conclusionLabel.Name = "conclusionLabel";
            this.conclusionLabel.Size = new System.Drawing.Size(405, 76);
            this.conclusionLabel.TabIndex = 26;
            this.conclusionLabel.Text = "Με την εκτέλεση των αλγορίθμων παρατηρούμε οτι ο ταχύτερος αλγόριθμος είναι ο αλγ" +
    "όριθμος του Ευκλείδη, και γιαυτό είναι και ο επικρατέστερος";
            this.conclusionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.conclusionLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 853);
            this.Controls.Add(this.conclusionLabel);
            this.Controls.Add(this.alg2YLabel);
            this.Controls.Add(this.alg2XLabel);
            this.Controls.Add(this.alg1YLabel);
            this.Controls.Add(this.alg1XLabel);
            this.Controls.Add(this.mdk2Label);
            this.Controls.Add(this.exec2TimeLabel);
            this.Controls.Add(this.execAlg2Button);
            this.Controls.Add(this.alg2Y);
            this.Controls.Add(this.execAlg2Label);
            this.Controls.Add(this.alg2X);
            this.Controls.Add(this.mdk1Label);
            this.Controls.Add(this.exec1TimeLabel);
            this.Controls.Add(this.execAlg1Button);
            this.Controls.Add(this.alg1Y);
            this.Controls.Add(this.execAlg1Label);
            this.Controls.Add(this.alg1X);
            this.Controls.Add(this.execTitleLabel);
            this.Controls.Add(this.algorithm2Label);
            this.Controls.Add(this.algorithm2);
            this.Controls.Add(this.algorithm1Label);
            this.Controls.Add(this.algorithm1);
            this.Controls.Add(this.exampleLabel);
            this.Controls.Add(this.algorithmLabel);
            this.Controls.Add(this.algorithmTitleLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.subjectTitle);
            this.Name = "Form1";
            this.Text = "ΜΚΔ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjectTitle;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label algorithmTitleLabel;
        private System.Windows.Forms.Label algorithmLabel;
        private System.Windows.Forms.Label exampleLabel;
        private System.Windows.Forms.Label algorithm1;
        private System.Windows.Forms.Label algorithm1Label;
        private System.Windows.Forms.Label algorithm2Label;
        private System.Windows.Forms.Label algorithm2;
        private System.Windows.Forms.Label execTitleLabel;
        private System.Windows.Forms.TextBox alg1X;
        private System.Windows.Forms.Label execAlg1Label;
        private System.Windows.Forms.TextBox alg1Y;
        private System.Windows.Forms.Button execAlg1Button;
        private System.Windows.Forms.Label exec1TimeLabel;
        private System.Windows.Forms.Label mdk1Label;
        private System.Windows.Forms.Label mdk2Label;
        private System.Windows.Forms.Label exec2TimeLabel;
        private System.Windows.Forms.Button execAlg2Button;
        private System.Windows.Forms.TextBox alg2Y;
        private System.Windows.Forms.Label execAlg2Label;
        private System.Windows.Forms.TextBox alg2X;
        private System.Windows.Forms.Label alg1XLabel;
        private System.Windows.Forms.Label alg1YLabel;
        private System.Windows.Forms.Label alg2YLabel;
        private System.Windows.Forms.Label alg2XLabel;
        private System.Windows.Forms.Label conclusionLabel;
    }
}

