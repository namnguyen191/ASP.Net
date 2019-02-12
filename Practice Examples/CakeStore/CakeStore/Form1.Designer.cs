namespace CakeStore
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
            this.lblStoreName = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.grpCustomCake = new System.Windows.Forms.GroupBox();
            this.grpTiers = new System.Windows.Forms.GroupBox();
            this.radTier3 = new System.Windows.Forms.RadioButton();
            this.radTier2 = new System.Windows.Forms.RadioButton();
            this.radTier1 = new System.Windows.Forms.RadioButton();
            this.grpOccasions = new System.Windows.Forms.GroupBox();
            this.radWedding = new System.Windows.Forms.RadioButton();
            this.radGraduation = new System.Windows.Forms.RadioButton();
            this.radAniversary = new System.Windows.Forms.RadioButton();
            this.grpFlavors = new System.Windows.Forms.GroupBox();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.grpCakeTypes = new System.Windows.Forms.GroupBox();
            this.radTradCake = new System.Windows.Forms.RadioButton();
            this.radCustomCake = new System.Windows.Forms.RadioButton();
            this.lstTradCakes = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpCustomerInfo.SuspendLayout();
            this.grpCustomCake.SuspendLayout();
            this.grpTiers.SuspendLayout();
            this.grpOccasions.SuspendLayout();
            this.grpFlavors.SuspendLayout();
            this.grpCakeTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Monotype Corsiva", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(13, 13);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(529, 67);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Nam Cake Store ( ͡° ͜ʖ ͡°)";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.txtLName);
            this.grpCustomerInfo.Controls.Add(this.txtFName);
            this.grpCustomerInfo.Controls.Add(this.lblLastName);
            this.grpCustomerInfo.Controls.Add(this.lblFName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(25, 98);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(355, 159);
            this.grpCustomerInfo.TabIndex = 1;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer\'s Information";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(150, 94);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(188, 35);
            this.txtLName.TabIndex = 3;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(149, 40);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(188, 35);
            this.txtFName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(134, 29);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(6, 40);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(137, 29);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name:";
            // 
            // grpCustomCake
            // 
            this.grpCustomCake.Controls.Add(this.grpTiers);
            this.grpCustomCake.Controls.Add(this.grpOccasions);
            this.grpCustomCake.Controls.Add(this.grpFlavors);
            this.grpCustomCake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomCake.Location = new System.Drawing.Point(25, 392);
            this.grpCustomCake.Name = "grpCustomCake";
            this.grpCustomCake.Size = new System.Drawing.Size(635, 243);
            this.grpCustomCake.TabIndex = 2;
            this.grpCustomCake.TabStop = false;
            this.grpCustomCake.Text = "Custom Cake";
            // 
            // grpTiers
            // 
            this.grpTiers.Controls.Add(this.radTier3);
            this.grpTiers.Controls.Add(this.radTier2);
            this.grpTiers.Controls.Add(this.radTier1);
            this.grpTiers.Location = new System.Drawing.Point(421, 54);
            this.grpTiers.Name = "grpTiers";
            this.grpTiers.Size = new System.Drawing.Size(199, 170);
            this.grpTiers.TabIndex = 2;
            this.grpTiers.TabStop = false;
            this.grpTiers.Text = "Number Of Tier";
            // 
            // radTier3
            // 
            this.radTier3.AutoSize = true;
            this.radTier3.Location = new System.Drawing.Point(7, 113);
            this.radTier3.Name = "radTier3";
            this.radTier3.Size = new System.Drawing.Size(113, 33);
            this.radTier3.TabIndex = 2;
            this.radTier3.Text = "3 Tiers";
            this.radTier3.UseVisualStyleBackColor = true;
            // 
            // radTier2
            // 
            this.radTier2.AutoSize = true;
            this.radTier2.Location = new System.Drawing.Point(7, 74);
            this.radTier2.Name = "radTier2";
            this.radTier2.Size = new System.Drawing.Size(113, 33);
            this.radTier2.TabIndex = 1;
            this.radTier2.Text = "2 Tiers";
            this.radTier2.UseVisualStyleBackColor = true;
            // 
            // radTier1
            // 
            this.radTier1.AutoSize = true;
            this.radTier1.Checked = true;
            this.radTier1.Location = new System.Drawing.Point(7, 35);
            this.radTier1.Name = "radTier1";
            this.radTier1.Size = new System.Drawing.Size(101, 33);
            this.radTier1.TabIndex = 0;
            this.radTier1.TabStop = true;
            this.radTier1.Text = "1 Tier";
            this.radTier1.UseVisualStyleBackColor = true;
            // 
            // grpOccasions
            // 
            this.grpOccasions.Controls.Add(this.radWedding);
            this.grpOccasions.Controls.Add(this.radGraduation);
            this.grpOccasions.Controls.Add(this.radAniversary);
            this.grpOccasions.Location = new System.Drawing.Point(216, 54);
            this.grpOccasions.Name = "grpOccasions";
            this.grpOccasions.Size = new System.Drawing.Size(199, 170);
            this.grpOccasions.TabIndex = 1;
            this.grpOccasions.TabStop = false;
            this.grpOccasions.Text = "Occasions";
            // 
            // radWedding
            // 
            this.radWedding.AutoSize = true;
            this.radWedding.Location = new System.Drawing.Point(7, 113);
            this.radWedding.Name = "radWedding";
            this.radWedding.Size = new System.Drawing.Size(135, 33);
            this.radWedding.TabIndex = 2;
            this.radWedding.Text = "Wedding";
            this.radWedding.UseVisualStyleBackColor = true;
            // 
            // radGraduation
            // 
            this.radGraduation.AutoSize = true;
            this.radGraduation.Location = new System.Drawing.Point(7, 74);
            this.radGraduation.Name = "radGraduation";
            this.radGraduation.Size = new System.Drawing.Size(156, 33);
            this.radGraduation.TabIndex = 1;
            this.radGraduation.Text = "Graduation";
            this.radGraduation.UseVisualStyleBackColor = true;
            // 
            // radAniversary
            // 
            this.radAniversary.AutoSize = true;
            this.radAniversary.Checked = true;
            this.radAniversary.Location = new System.Drawing.Point(7, 35);
            this.radAniversary.Name = "radAniversary";
            this.radAniversary.Size = new System.Drawing.Size(149, 33);
            this.radAniversary.TabIndex = 0;
            this.radAniversary.TabStop = true;
            this.radAniversary.Text = "Aniversary";
            this.radAniversary.UseVisualStyleBackColor = true;
            // 
            // grpFlavors
            // 
            this.grpFlavors.Controls.Add(this.radBanana);
            this.grpFlavors.Controls.Add(this.radVanilla);
            this.grpFlavors.Controls.Add(this.radChocolate);
            this.grpFlavors.Location = new System.Drawing.Point(11, 54);
            this.grpFlavors.Name = "grpFlavors";
            this.grpFlavors.Size = new System.Drawing.Size(199, 170);
            this.grpFlavors.TabIndex = 0;
            this.grpFlavors.TabStop = false;
            this.grpFlavors.Text = "Flavors";
            // 
            // radBanana
            // 
            this.radBanana.AutoSize = true;
            this.radBanana.Location = new System.Drawing.Point(7, 113);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(119, 33);
            this.radBanana.TabIndex = 2;
            this.radBanana.Text = "Banana";
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.AutoSize = true;
            this.radVanilla.Location = new System.Drawing.Point(7, 74);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(110, 33);
            this.radVanilla.TabIndex = 1;
            this.radVanilla.Text = "Vanilla";
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radChocolate
            // 
            this.radChocolate.AutoSize = true;
            this.radChocolate.Checked = true;
            this.radChocolate.Location = new System.Drawing.Point(7, 35);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(147, 33);
            this.radChocolate.TabIndex = 0;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "Chocolate";
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // grpCakeTypes
            // 
            this.grpCakeTypes.Controls.Add(this.radTradCake);
            this.grpCakeTypes.Controls.Add(this.radCustomCake);
            this.grpCakeTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCakeTypes.Location = new System.Drawing.Point(403, 98);
            this.grpCakeTypes.Name = "grpCakeTypes";
            this.grpCakeTypes.Size = new System.Drawing.Size(200, 137);
            this.grpCakeTypes.TabIndex = 3;
            this.grpCakeTypes.TabStop = false;
            this.grpCakeTypes.Text = "Type Of Cake";
            // 
            // radTradCake
            // 
            this.radTradCake.AutoSize = true;
            this.radTradCake.Location = new System.Drawing.Point(20, 79);
            this.radTradCake.Name = "radTradCake";
            this.radTradCake.Size = new System.Drawing.Size(153, 33);
            this.radTradCake.TabIndex = 1;
            this.radTradCake.Text = "Traditional";
            this.radTradCake.UseVisualStyleBackColor = true;
            // 
            // radCustomCake
            // 
            this.radCustomCake.AutoSize = true;
            this.radCustomCake.Checked = true;
            this.radCustomCake.Location = new System.Drawing.Point(20, 40);
            this.radCustomCake.Name = "radCustomCake";
            this.radCustomCake.Size = new System.Drawing.Size(120, 33);
            this.radCustomCake.TabIndex = 0;
            this.radCustomCake.TabStop = true;
            this.radCustomCake.Text = "Custom";
            this.radCustomCake.UseVisualStyleBackColor = true;
            this.radCustomCake.CheckedChanged += new System.EventHandler(this.radCustomCake_CheckedChanged);
            // 
            // lstTradCakes
            // 
            this.lstTradCakes.Enabled = false;
            this.lstTradCakes.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTradCakes.FormattingEnabled = true;
            this.lstTradCakes.ItemHeight = 21;
            this.lstTradCakes.Items.AddRange(new object[] {
            "Strawberry Cheese Cake",
            "Lemon Velvet Cake",
            "Blueberry Mousse",
            "Tiramisu"});
            this.lstTradCakes.Location = new System.Drawing.Point(403, 241);
            this.lstTradCakes.Name = "lstTradCakes";
            this.lstTradCakes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTradCakes.Size = new System.Drawing.Size(257, 109);
            this.lstTradCakes.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(716, 98);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add To Cart";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(716, 166);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(178, 44);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View Cart";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearCart.Location = new System.Drawing.Point(716, 231);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(178, 44);
            this.btnClearCart.TabIndex = 7;
            this.btnClearCart.Text = "Clear Cart";
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(716, 296);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(178, 44);
            this.btnCheckOut.TabIndex = 8;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(716, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 44);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(716, 446);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 44);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 654);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnClearCart);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstTradCakes);
            this.Controls.Add(this.grpCakeTypes);
            this.Controls.Add(this.grpCustomCake);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.lblStoreName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpCustomCake.ResumeLayout(false);
            this.grpTiers.ResumeLayout(false);
            this.grpTiers.PerformLayout();
            this.grpOccasions.ResumeLayout(false);
            this.grpOccasions.PerformLayout();
            this.grpFlavors.ResumeLayout(false);
            this.grpFlavors.PerformLayout();
            this.grpCakeTypes.ResumeLayout(false);
            this.grpCakeTypes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.GroupBox grpCustomCake;
        private System.Windows.Forms.GroupBox grpTiers;
        private System.Windows.Forms.RadioButton radTier3;
        private System.Windows.Forms.RadioButton radTier2;
        private System.Windows.Forms.RadioButton radTier1;
        private System.Windows.Forms.GroupBox grpOccasions;
        private System.Windows.Forms.RadioButton radWedding;
        private System.Windows.Forms.RadioButton radGraduation;
        private System.Windows.Forms.RadioButton radAniversary;
        private System.Windows.Forms.GroupBox grpFlavors;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
        private System.Windows.Forms.GroupBox grpCakeTypes;
        private System.Windows.Forms.RadioButton radTradCake;
        private System.Windows.Forms.RadioButton radCustomCake;
        private System.Windows.Forms.ListBox lstTradCakes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnClearCart;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

