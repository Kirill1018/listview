namespace view
{
    partial class Kind
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("1_st element", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2_nd element", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3_rd element", 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kind));
            this.rev_ord = new System.Windows.Forms.Button();
            this.dir_ord = new System.Windows.Forms.Button();
            this.list_view = new System.Windows.Forms.ListView();
            this.list = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // rev_ord
            // 
            this.rev_ord.BackColor = System.Drawing.SystemColors.GrayText;
            this.rev_ord.ForeColor = System.Drawing.SystemColors.MenuText;
            this.rev_ord.Location = new System.Drawing.Point(59, 322);
            this.rev_ord.Name = "rev_ord";
            this.rev_ord.Size = new System.Drawing.Size(75, 39);
            this.rev_ord.TabIndex = 0;
            this.rev_ord.Text = "reverse order";
            this.rev_ord.UseVisualStyleBackColor = false;
            this.rev_ord.Click += new System.EventHandler(this.rev_ord_Click);
            // 
            // dir_ord
            // 
            this.dir_ord.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dir_ord.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dir_ord.Location = new System.Drawing.Point(203, 322);
            this.dir_ord.Name = "dir_ord";
            this.dir_ord.Size = new System.Drawing.Size(75, 39);
            this.dir_ord.TabIndex = 1;
            this.dir_ord.Text = "direct order";
            this.dir_ord.UseVisualStyleBackColor = false;
            this.dir_ord.Click += new System.EventHandler(this.dir_ord_Click);
            // 
            // list_view
            // 
            this.list_view.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.list_view.ForeColor = System.Drawing.SystemColors.ControlText;
            this.list_view.HideSelection = false;
            this.list_view.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.list_view.LargeImageList = this.list;
            this.list_view.Location = new System.Drawing.Point(59, 56);
            this.list_view.Name = "list_view";
            this.list_view.Size = new System.Drawing.Size(219, 152);
            this.list_view.SmallImageList = this.list;
            this.list_view.TabIndex = 2;
            this.list_view.UseCompatibleStateImageBehavior = false;
            // 
            // list
            // 
            this.list.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("list.ImageStream")));
            this.list.TransparentColor = System.Drawing.Color.Transparent;
            this.list.Images.SetKeyName(0, "200 easy pictures of cats.png");
            this.list.Images.SetKeyName(1, "pencil pictures of cats.png");
            this.list.Images.SetKeyName(2, "pictures for pencil drawing.png");
            // 
            // Kind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.list_view);
            this.Controls.Add(this.dir_ord);
            this.Controls.Add(this.rev_ord);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kind";
            this.Text = "listview";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rev_ord;
        private System.Windows.Forms.Button dir_ord;
        private System.Windows.Forms.ListView list_view;
        private System.Windows.Forms.ImageList list;
    }
}

