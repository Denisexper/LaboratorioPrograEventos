namespace Laboratorio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            storeLIstBox = new ListBox();
            storeLabel1 = new Label();
            AddGroupBox1 = new GroupBox();
            nombrejuguetelabel = new Label();
            addbutton1 = new Button();
            addnombretxtbox = new TextBox();
            addjugueteLabel1 = new Label();
            AdministrargroupBox2 = new GroupBox();
            Eliminarbutton2 = new Button();
            administrarLabel2 = new Label();
            titleLabel = new Label();
            nombreclienteLabel = new Label();
            tttexbox = new TextBox();
            comprarbutton = new Button();
            imformacionbtt = new Button();
            errorProvider1 = new ErrorProvider(components);
            AddGroupBox1.SuspendLayout();
            AdministrargroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // storeLIstBox
            // 
            storeLIstBox.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            storeLIstBox.ForeColor = SystemColors.InactiveCaptionText;
            storeLIstBox.FormattingEnabled = true;
            storeLIstBox.ItemHeight = 24;
            storeLIstBox.Items.AddRange(new object[] { "Muñeca....25$" });
            storeLIstBox.Location = new Point(-1, 174);
            storeLIstBox.Margin = new Padding(4);
            storeLIstBox.Name = "storeLIstBox";
            storeLIstBox.Size = new Size(193, 220);
            storeLIstBox.TabIndex = 0;
            // 
            // storeLabel1
            // 
            storeLabel1.AutoSize = true;
            storeLabel1.Font = new Font("Bodoni MT Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            storeLabel1.Location = new Point(-1, 136);
            storeLabel1.Margin = new Padding(4, 0, 4, 0);
            storeLabel1.Name = "storeLabel1";
            storeLabel1.Size = new Size(217, 33);
            storeLabel1.TabIndex = 1;
            storeLabel1.Text = "Seleccione el Juguete";
            // 
            // AddGroupBox1
            // 
            AddGroupBox1.Controls.Add(nombrejuguetelabel);
            AddGroupBox1.Controls.Add(addbutton1);
            AddGroupBox1.Controls.Add(addnombretxtbox);
            AddGroupBox1.Controls.Add(addjugueteLabel1);
            AddGroupBox1.Location = new Point(232, 98);
            AddGroupBox1.Margin = new Padding(4);
            AddGroupBox1.Name = "AddGroupBox1";
            AddGroupBox1.Padding = new Padding(4);
            AddGroupBox1.Size = new Size(266, 237);
            AddGroupBox1.TabIndex = 2;
            AddGroupBox1.TabStop = false;
            // 
            // nombrejuguetelabel
            // 
            nombrejuguetelabel.AutoSize = true;
            nombrejuguetelabel.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nombrejuguetelabel.Location = new Point(12, 68);
            nombrejuguetelabel.Name = "nombrejuguetelabel";
            nombrejuguetelabel.Size = new Size(184, 26);
            nombrejuguetelabel.TabIndex = 3;
            nombrejuguetelabel.Text = "Nombre y precio";
            // 
            // addbutton1
            // 
            addbutton1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addbutton1.Location = new Point(-1, 169);
            addbutton1.Margin = new Padding(4);
            addbutton1.Name = "addbutton1";
            addbutton1.Size = new Size(245, 40);
            addbutton1.TabIndex = 2;
            addbutton1.Text = "Agregar";
            addbutton1.UseVisualStyleBackColor = true;
            addbutton1.Click += button1_Click;
            // 
            // addnombretxtbox
            // 
            addnombretxtbox.Location = new Point(-1, 100);
            addnombretxtbox.Margin = new Padding(4);
            addnombretxtbox.Name = "addnombretxtbox";
            addnombretxtbox.Size = new Size(245, 31);
            addnombretxtbox.TabIndex = 1;
            // 
            // addjugueteLabel1
            // 
            addjugueteLabel1.AutoSize = true;
            addjugueteLabel1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addjugueteLabel1.Location = new Point(0, 16);
            addjugueteLabel1.Margin = new Padding(4, 0, 4, 0);
            addjugueteLabel1.Name = "addjugueteLabel1";
            addjugueteLabel1.Size = new Size(205, 32);
            addjugueteLabel1.TabIndex = 0;
            addjugueteLabel1.Text = "Agregar juguete";
            // 
            // AdministrargroupBox2
            // 
            AdministrargroupBox2.Controls.Add(Eliminarbutton2);
            AdministrargroupBox2.Controls.Add(administrarLabel2);
            AdministrargroupBox2.Location = new Point(231, 354);
            AdministrargroupBox2.Margin = new Padding(4);
            AdministrargroupBox2.Name = "AdministrargroupBox2";
            AdministrargroupBox2.Padding = new Padding(4);
            AdministrargroupBox2.Size = new Size(266, 122);
            AdministrargroupBox2.TabIndex = 3;
            AdministrargroupBox2.TabStop = false;
            // 
            // Eliminarbutton2
            // 
            Eliminarbutton2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Eliminarbutton2.Location = new Point(8, 64);
            Eliminarbutton2.Margin = new Padding(4);
            Eliminarbutton2.Name = "Eliminarbutton2";
            Eliminarbutton2.Size = new Size(246, 48);
            Eliminarbutton2.TabIndex = 2;
            Eliminarbutton2.Text = "Eliminar Juguete";
            Eliminarbutton2.UseVisualStyleBackColor = true;
            Eliminarbutton2.Click += Eliminarbutton2_Click;
            // 
            // administrarLabel2
            // 
            administrarLabel2.AutoSize = true;
            administrarLabel2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            administrarLabel2.Location = new Point(8, 11);
            administrarLabel2.Margin = new Padding(4, 0, 4, 0);
            administrarLabel2.Name = "administrarLabel2";
            administrarLabel2.Size = new Size(162, 32);
            administrarLabel2.TabIndex = 0;
            administrarLabel2.Text = "Administrar";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Stencil", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            titleLabel.Location = new Point(121, 11);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(265, 39);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Tienda Cheros";
            // 
            // nombreclienteLabel
            // 
            nombreclienteLabel.AutoSize = true;
            nombreclienteLabel.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nombreclienteLabel.Location = new Point(5, 71);
            nombreclienteLabel.Margin = new Padding(4, 0, 4, 0);
            nombreclienteLabel.Name = "nombreclienteLabel";
            nombreclienteLabel.Size = new Size(176, 24);
            nombreclienteLabel.TabIndex = 5;
            nombreclienteLabel.Text = "Nombre del cliente";
            // 
            // tttexbox
            // 
            tttexbox.Location = new Point(201, 71);
            tttexbox.Margin = new Padding(4);
            tttexbox.Name = "tttexbox";
            tttexbox.Size = new Size(258, 31);
            tttexbox.TabIndex = 6;
            // 
            // comprarbutton
            // 
            comprarbutton.BackColor = SystemColors.AppWorkspace;
            comprarbutton.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            comprarbutton.Location = new Point(-1, 427);
            comprarbutton.Name = "comprarbutton";
            comprarbutton.Size = new Size(193, 39);
            comprarbutton.TabIndex = 11;
            comprarbutton.Text = "COMPRAR";
            comprarbutton.UseVisualStyleBackColor = false;
            comprarbutton.Click += comprarbutton_Click;
            comprarbutton.MouseClick += comprarbutton_MouseClick;
            // 
            // imformacionbtt
            // 
            imformacionbtt.BackColor = SystemColors.AppWorkspace;
            imformacionbtt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            imformacionbtt.Location = new Point(5, 497);
            imformacionbtt.Name = "imformacionbtt";
            imformacionbtt.Size = new Size(187, 43);
            imformacionbtt.TabIndex = 12;
            imformacionbtt.Text = "IMF COMPRA";
            imformacionbtt.UseVisualStyleBackColor = false;
            imformacionbtt.MouseClick += imformacionbtt_MouseClick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(522, 552);
            Controls.Add(imformacionbtt);
            Controls.Add(comprarbutton);
            Controls.Add(tttexbox);
            Controls.Add(nombreclienteLabel);
            Controls.Add(titleLabel);
            Controls.Add(AdministrargroupBox2);
            Controls.Add(AddGroupBox1);
            Controls.Add(storeLabel1);
            Controls.Add(storeLIstBox);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            AddGroupBox1.ResumeLayout(false);
            AddGroupBox1.PerformLayout();
            AdministrargroupBox2.ResumeLayout(false);
            AdministrargroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox storeLIstBox;
        private Label storeLabel1;
        private GroupBox AddGroupBox1;
        private Button addbutton1;
        private TextBox addnombretxtbox;
        private Label addjugueteLabel1;
        private GroupBox AdministrargroupBox2;
        private Button Eliminarbutton2;
        private Label administrarLabel2;
        private Label titleLabel;
        private Label nombreclienteLabel;
        private TextBox tttexbox;
        private Label nombrejuguetelabel;
        private Button comprarbutton;
        private Button imformacionbtt;
        private ErrorProvider errorProvider1;
    }
}