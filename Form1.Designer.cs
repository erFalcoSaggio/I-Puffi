namespace I_Puffi
{
    partial class frm_Principale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Principale));
            errorProvider1 = new ErrorProvider(components);
            pnl_Mappa = new Panel();
            lbl_TitoloMappa = new Label();
            lbl_InfoTitolo = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_Punteggio = new Label();
            lbl_CaseTitolo = new Label();
            lbl_NumeroDiCase = new Label();
            btn_Left = new Button();
            btn_Down = new Button();
            btn_Up = new Button();
            btn_Right = new Button();
            lbl_BottoniPlayerTitolo = new Label();
            lbl_GargamellaBottoniTitolo = new Label();
            btn_LeftGargamella = new Button();
            btn_DownGargamella = new Button();
            btn_RightGargamella = new Button();
            btn_UpGargamella = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // pnl_Mappa
            // 
            pnl_Mappa.BackColor = Color.White;
            pnl_Mappa.Location = new Point(12, 40);
            pnl_Mappa.Name = "pnl_Mappa";
            pnl_Mappa.Size = new Size(600, 600);
            pnl_Mappa.TabIndex = 0;
            // 
            // lbl_TitoloMappa
            // 
            lbl_TitoloMappa.AutoSize = true;
            lbl_TitoloMappa.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TitoloMappa.Location = new Point(209, 7);
            lbl_TitoloMappa.Name = "lbl_TitoloMappa";
            lbl_TitoloMappa.Size = new Size(161, 30);
            lbl_TitoloMappa.TabIndex = 0;
            lbl_TitoloMappa.Text = "Mappa di gioco";
            // 
            // lbl_InfoTitolo
            // 
            lbl_InfoTitolo.Anchor = AnchorStyles.None;
            lbl_InfoTitolo.AutoSize = true;
            lbl_InfoTitolo.Font = new Font("Ink Free", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_InfoTitolo.Location = new Point(123, 17);
            lbl_InfoTitolo.Name = "lbl_InfoTitolo";
            lbl_InfoTitolo.Size = new Size(60, 30);
            lbl_InfoTitolo.TabIndex = 1;
            lbl_InfoTitolo.Text = "Info";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(lbl_InfoTitolo, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_Punteggio, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_CaseTitolo, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_NumeroDiCase, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_Left, 0, 5);
            tableLayoutPanel1.Controls.Add(btn_Down, 1, 5);
            tableLayoutPanel1.Controls.Add(btn_Up, 1, 4);
            tableLayoutPanel1.Controls.Add(btn_Right, 2, 5);
            tableLayoutPanel1.Controls.Add(lbl_BottoniPlayerTitolo, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_GargamellaBottoniTitolo, 1, 6);
            tableLayoutPanel1.Controls.Add(btn_LeftGargamella, 0, 8);
            tableLayoutPanel1.Controls.Add(btn_DownGargamella, 1, 8);
            tableLayoutPanel1.Controls.Add(btn_RightGargamella, 2, 8);
            tableLayoutPanel1.Controls.Add(btn_UpGargamella, 1, 7);
            tableLayoutPanel1.Location = new Point(641, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9160795F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9160757F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.9160757F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93397951F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.845952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.845952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.93397951F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.845952F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.845952F));
            tableLayoutPanel1.Size = new Size(308, 600);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lbl_Punteggio
            // 
            lbl_Punteggio.Anchor = AnchorStyles.None;
            lbl_Punteggio.AutoSize = true;
            lbl_Punteggio.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Punteggio.Location = new Point(13, 87);
            lbl_Punteggio.Name = "lbl_Punteggio";
            lbl_Punteggio.Size = new Size(76, 20);
            lbl_Punteggio.TabIndex = 2;
            lbl_Punteggio.Text = "Punteggio";
            // 
            // lbl_CaseTitolo
            // 
            lbl_CaseTitolo.Anchor = AnchorStyles.None;
            lbl_CaseTitolo.AutoSize = true;
            lbl_CaseTitolo.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CaseTitolo.Location = new Point(31, 152);
            lbl_CaseTitolo.Name = "lbl_CaseTitolo";
            lbl_CaseTitolo.Size = new Size(40, 20);
            lbl_CaseTitolo.TabIndex = 2;
            lbl_CaseTitolo.Text = "Case";
            // 
            // lbl_NumeroDiCase
            // 
            lbl_NumeroDiCase.Anchor = AnchorStyles.None;
            lbl_NumeroDiCase.AutoSize = true;
            lbl_NumeroDiCase.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NumeroDiCase.Location = new Point(144, 152);
            lbl_NumeroDiCase.Name = "lbl_NumeroDiCase";
            lbl_NumeroDiCase.Size = new Size(18, 20);
            lbl_NumeroDiCase.TabIndex = 2;
            lbl_NumeroDiCase.Text = "0";
            // 
            // btn_Left
            // 
            btn_Left.Anchor = AnchorStyles.None;
            btn_Left.BackgroundImage = (Image)resources.GetObject("btn_Left.BackgroundImage");
            btn_Left.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Left.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Left.Location = new Point(3, 316);
            btn_Left.Name = "btn_Left";
            btn_Left.Size = new Size(96, 77);
            btn_Left.TabIndex = 4;
            btn_Left.UseVisualStyleBackColor = true;
            btn_Left.Click += btn_Left_Click;
            // 
            // btn_Down
            // 
            btn_Down.Anchor = AnchorStyles.None;
            btn_Down.BackgroundImage = Properties.Resources.Progetto_senza_titolo__5_;
            btn_Down.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Down.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Down.Location = new Point(105, 316);
            btn_Down.Name = "btn_Down";
            btn_Down.Size = new Size(96, 76);
            btn_Down.TabIndex = 4;
            btn_Down.UseVisualStyleBackColor = true;
            btn_Down.Click += btn_Down_Click;
            // 
            // btn_Up
            // 
            btn_Up.Anchor = AnchorStyles.None;
            btn_Up.BackgroundImage = Properties.Resources.Progetto_senza_titolo__4_;
            btn_Up.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Up.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Up.Location = new Point(105, 233);
            btn_Up.Name = "btn_Up";
            btn_Up.Size = new Size(96, 77);
            btn_Up.TabIndex = 3;
            btn_Up.UseVisualStyleBackColor = true;
            btn_Up.Click += btn_Up_Click;
            // 
            // btn_Right
            // 
            btn_Right.Anchor = AnchorStyles.None;
            btn_Right.BackgroundImage = Properties.Resources.Progetto_senza_titolo__3_;
            btn_Right.BackgroundImageLayout = ImageLayout.Stretch;
            btn_Right.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Right.Location = new Point(207, 316);
            btn_Right.Name = "btn_Right";
            btn_Right.Size = new Size(98, 77);
            btn_Right.TabIndex = 4;
            btn_Right.UseVisualStyleBackColor = true;
            btn_Right.Click += btn_Right_Click;
            // 
            // lbl_BottoniPlayerTitolo
            // 
            lbl_BottoniPlayerTitolo.Anchor = AnchorStyles.None;
            lbl_BottoniPlayerTitolo.AutoSize = true;
            lbl_BottoniPlayerTitolo.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BottoniPlayerTitolo.Location = new Point(129, 202);
            lbl_BottoniPlayerTitolo.Name = "lbl_BottoniPlayerTitolo";
            lbl_BottoniPlayerTitolo.Size = new Size(47, 20);
            lbl_BottoniPlayerTitolo.TabIndex = 2;
            lbl_BottoniPlayerTitolo.Text = "Puffo";
            // 
            // lbl_GargamellaBottoniTitolo
            // 
            lbl_GargamellaBottoniTitolo.Anchor = AnchorStyles.None;
            lbl_GargamellaBottoniTitolo.AutoSize = true;
            lbl_GargamellaBottoniTitolo.Font = new Font("Ink Free", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_GargamellaBottoniTitolo.Location = new Point(110, 403);
            lbl_GargamellaBottoniTitolo.Name = "lbl_GargamellaBottoniTitolo";
            lbl_GargamellaBottoniTitolo.Size = new Size(86, 20);
            lbl_GargamellaBottoniTitolo.TabIndex = 2;
            lbl_GargamellaBottoniTitolo.Text = "Gargamella";
            // 
            // btn_LeftGargamella
            // 
            btn_LeftGargamella.Anchor = AnchorStyles.None;
            btn_LeftGargamella.BackgroundImage = (Image)resources.GetObject("btn_LeftGargamella.BackgroundImage");
            btn_LeftGargamella.BackgroundImageLayout = ImageLayout.Stretch;
            btn_LeftGargamella.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_LeftGargamella.Location = new Point(3, 517);
            btn_LeftGargamella.Name = "btn_LeftGargamella";
            btn_LeftGargamella.Size = new Size(96, 80);
            btn_LeftGargamella.TabIndex = 4;
            btn_LeftGargamella.UseVisualStyleBackColor = true;
            btn_LeftGargamella.Click += btn_Left_Click;
            // 
            // btn_DownGargamella
            // 
            btn_DownGargamella.Anchor = AnchorStyles.None;
            btn_DownGargamella.BackgroundImage = Properties.Resources.Progetto_senza_titolo__5_;
            btn_DownGargamella.BackgroundImageLayout = ImageLayout.Stretch;
            btn_DownGargamella.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DownGargamella.Location = new Point(105, 517);
            btn_DownGargamella.Name = "btn_DownGargamella";
            btn_DownGargamella.Size = new Size(96, 80);
            btn_DownGargamella.TabIndex = 4;
            btn_DownGargamella.UseVisualStyleBackColor = true;
            btn_DownGargamella.Click += btn_Down_Click;
            // 
            // btn_RightGargamella
            // 
            btn_RightGargamella.Anchor = AnchorStyles.None;
            btn_RightGargamella.BackgroundImage = Properties.Resources.Progetto_senza_titolo__3_;
            btn_RightGargamella.BackgroundImageLayout = ImageLayout.Stretch;
            btn_RightGargamella.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_RightGargamella.Location = new Point(207, 517);
            btn_RightGargamella.Name = "btn_RightGargamella";
            btn_RightGargamella.Size = new Size(98, 80);
            btn_RightGargamella.TabIndex = 4;
            btn_RightGargamella.UseVisualStyleBackColor = true;
            btn_RightGargamella.Click += btn_Right_Click;
            // 
            // btn_UpGargamella
            // 
            btn_UpGargamella.Anchor = AnchorStyles.None;
            btn_UpGargamella.BackgroundImage = Properties.Resources.Progetto_senza_titolo__4_;
            btn_UpGargamella.BackgroundImageLayout = ImageLayout.Stretch;
            btn_UpGargamella.Font = new Font("Ink Free", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpGargamella.Location = new Point(105, 434);
            btn_UpGargamella.Name = "btn_UpGargamella";
            btn_UpGargamella.Size = new Size(96, 77);
            btn_UpGargamella.TabIndex = 3;
            btn_UpGargamella.UseVisualStyleBackColor = true;
            btn_UpGargamella.Click += btn_Up_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // frm_Principale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_TitoloMappa);
            Controls.Add(pnl_Mappa);
            Name = "frm_Principale";
            Text = "I Puffi";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorProvider1;
        private Panel pnl_Mappa;
        private Label lbl_TitoloMappa;
        private Label lbl_InfoTitolo;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Left;
        private Button btn_Up;
        private Label lbl_Punteggio;
        private Button btn_Down;
        private ImageList imageList1;
        public Button btn_Right;
        private Label lbl_CaseTitolo;
        private Label lbl_NumeroDiCase;
        private Label lbl_BottoniPlayerTitolo;
        private Label lbl_GargamellaBottoniTitolo;
        private Button btn_LeftGargamella;
        private Button btn_DownGargamella;
        public Button btn_RightGargamella;
        private Button btn_UpGargamella;
    }
}